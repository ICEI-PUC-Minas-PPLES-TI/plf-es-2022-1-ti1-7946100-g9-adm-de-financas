<%@ Application Language="C#" %>
<%@ Import Namespace="Adm_FinancasTIAW" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        var orm = new HoskeORM("sql10.freemysqlhosting.net","sql10503044","hiqVcMwtn2","sql10503044",HoskeORM.DBType.Mysql);
        HoskeORM.DBContext.Add(typeof(TipoGasto));
        HoskeORM.DBContext.Add(typeof(Usuario));
        HoskeORM.DBContext.Add(typeof(Carteira));
        HoskeORM.DBContext.Add(typeof(Meta));
        HoskeORM.DBContext.Add(typeof(Gasto));
        var dbcontext = new HoskeORM.DBContext();
        dbcontext.Migrate();
        //HoskeORM.Replace(new TipoGasto() { Tipo = "Transporte" });
        //HoskeORM.Replace(new TipoGasto() { Tipo = "Alimentação" });
        //HoskeORM.Replace(new TipoGasto() { Tipo = "Saúde" });
        //HoskeORM.Replace(new TipoGasto() { Tipo = "Lazer" });
        //HoskeORM.Replace(new TipoGasto() { Tipo = "Educação" });
        //HoskeORM.Replace(new TipoGasto() { Tipo = "Outros" });

        RouteConfig.RegisterRoutes(RouteTable.Routes);
        BundleConfig.RegisterBundles(BundleTable.Bundles);
    }

</script>
