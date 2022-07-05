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

        var gastos = _gastoServices.BuscarGastos(new Gasto() { Carteira = carteira });
        lblUltGastos.Text = "R$" + gastos.Sum(x => x.Valor);
    }

}