using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class index : System.Web.UI.Page
{
    private IUsuarioServices _usuarioServices;
    private ICarteiraServices _carteiraServices;
    private IGastoServices _gastoServices;
    private IMetaServices _metaServices;
    private Usuario _currentUser;
    public index()
    {
        Adm_FinancasTIAW.Instances.Create(out _usuarioServices, out _carteiraServices, out _metaServices, out _gastoServices);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Usuario"] == null)
        {
            Response.Redirect("login");
            return;
        }
        else 
        {
            _currentUser = _usuarioServices.BuscarUsuario(new Usuario() { Id = Convert.ToInt32(Session["Usuario"]) });
        }

        lblNome.Text = _currentUser.Nome;
        var carteira = _carteiraServices.BuscarCarteira(new Carteira() { Usuario = _currentUser });
        lblSaldo.Text ="R$"+ carteira.Saldo.ToString();
        lblGanhoMensal.Text = carteira.GanhoMensal.ToString();
        lblMetasAtingidas.Text = 
            _metaServices.BuscarMetas(new Meta() { Usuario = _currentUser })
            .Where(x => (x.Valor - carteira.Saldo) <= 0)
            .Where(y => y.DataFim >= DateTime.Now)
            .Count()
            .ToString();
        var gastos = _gastoServices.BuscarGastos(new Gasto() { Carteira = carteira }).Where(x => x.Data.Value.Month == DateTime.Now.Month);
        lblUltGastos.Text = "R$" + gastos.Sum(x => x.Valor);
    }


    protected void btnCadGasto_Click(object sender, EventArgs e)
    {
        string nomegasto = ((Button)sender).ID.Replace("btnCad", "");
        TextBox textValorGasto = (TextBox)this.FindControl("txtCad" + nomegasto);
        if (textValorGasto.Text != "") { 
            decimal valorgasto = Convert.ToDecimal(textValorGasto.Text);
            if (valorgasto > 0) { 
                _gastoServices.AdicionarGasto(new Gasto()
                {
                    Data = DateTime.Now,
                    Carteira = new Carteira()
                    {
                        Usuario = _currentUser,
                    },
                    Tipo = new TipoGasto() { Tipo = nomegasto },
                    Valor = valorgasto

                }) ;
            }
        }
    }

    protected void btnEditarGanhoMensal_Click(object sender, EventArgs e)
    {
        if (lblGanhoMensal.Visible == true)
        {
            lblGanhoMensal.Visible = false;
            txtGanhoMensal.Visible = true;
        }
        else 
        {
            //Inserit
            var carteira = _carteiraServices.BuscarCarteira(new Carteira() { Usuario = _currentUser });
            carteira.GanhoMensal = Convert.ToDecimal(txtGanhoMensal.Text);
            _carteiraServices.AtualizarCarteira(carteira);
            lblGanhoMensal.Visible = true;
            txtGanhoMensal.Visible = false;
        }
    }
}