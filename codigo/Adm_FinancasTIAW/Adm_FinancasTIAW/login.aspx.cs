using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    private IUsuarioServices _usuarioServices;
    private ICarteiraServices _carteiraServices;
    private IGastoServices _gastoServices;
    private IMetaServices _metaServices;
    public login()
    {
        Adm_FinancasTIAW.Instances.Create(out _usuarioServices, out _carteiraServices, out _metaServices, out _gastoServices);
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            var usuario = _usuarioServices.LogarUsuario(txtEmail.Text, txtPsw.Text);

            if(usuario != null) 
            {
                Session["Usuario"] = usuario.Id;
                Response.Redirect("index");
            }
        }
        catch (Exception ex)
        {

            lblRetorno.Text = "Não foi possível realizar o login" + ex.Message;
        }
    }
}