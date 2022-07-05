using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cadastro : System.Web.UI.Page
{
    private IUsuarioServices _usuarioServices;
    private ICarteiraServices _carteiraServices;
    protected void Page_Load(object sender, EventArgs e)
    {
        Adm_FinancasTIAW.Instances.Create(out _usuarioServices, out _carteiraServices, out _, out _);
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtPsw.Text == txtPsw2.Text)
            {
                if (_usuarioServices.CadastrarUsuario(txtEmail.Text, txtNome.Text, txtPsw.Text)) 
                {
                    Response.Redirect("login");
                }
            }
        }
        catch (Exception ex)
        {
            lblRetorno.Text = $"Não foi possível realizar o cadastro: {ex.Message}";
        }

    }


    
}