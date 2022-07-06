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
        if (!Page.IsPostBack) 
        { 
            CarregarDados();
        }

    }

    void CarregarDados() 
    {
        var carteira = _carteiraServices.BuscarCarteira(new Carteira() { Usuario = _currentUser });
        var gastos = _gastoServices.BuscarGastos(new Gasto() { Carteira = carteira }).Where(x => x.Data.Value.Month == DateTime.Now.Month);
        var gastostotal = gastos.Sum(x => x.Valor);
        lblNome.Text = _currentUser.Nome;
        lblSaldo.Text = "R$" + (carteira.Saldo - gastostotal).ToString();
        lblGanhoMensal.Text = carteira.GanhoMensal.ToString();
        lblMetasAtingidas.Text =
            _metaServices.BuscarMetas(new Meta() { Usuario = _currentUser })
            .Where(x => (x.Valor - carteira.Saldo) <= 0)
            .Where(y => y.DataFim >= DateTime.Now)
            .Count()
            .ToString();

        lblUltGastos.Text = "R$" + gastostotal;
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
        CarregarDados();
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
            //_carteiraServices.AtualizarCarteira(carteira);
            using (MySql.Data.MySqlClient.MySqlConnection cn = new MySql.Data.MySqlClient.MySqlConnection("server=mysql8002.site4now.net;database=db_a8995a_tiaw;uid=a8995a_tiaw;pwd=Matheus0508;")) { 
                cn.Open();
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand($"update carteira set ganhomensal = {Convert.ToDecimal(txtGanhoMensal.Text).ToString().Replace(",", ".")} where usuario_id = {_currentUser.Id}", cn)) 
                { 
                    cmd.ExecuteNonQuery();
                }
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand($"update carteira set saldo = {(Convert.ToDecimal(txtGanhoMensal.Text)).ToString().Replace(",",".")} where usuario_id = {_currentUser.Id}", cn))
                {
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
            lblGanhoMensal.Visible = true;
            txtGanhoMensal.Visible = false;
            CarregarDados();
        }
        
    }
}