using Microsoft.Owin;
using Owin;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

[assembly: OwinStartupAttribute(typeof(Adm_FinancasTIAW.Startup))]
namespace Adm_FinancasTIAW
{
   
    public partial class Startup {
        public Startup()
        {
           

        }
        public void Configuration(IAppBuilder app) {


            ConfigureAuth(app);
        }
    }
    public class Instances 
    {
        public static void Create(out IUsuarioServices usuarioServices, out ICarteiraServices carteiraServices, out IMetaServices metaServices, out IGastoServices gastoServices) 
        {
            carteiraServices = new CarteiraServices(new CarteiraRepository());
            usuarioServices = new UsuarioServices(new UsuarioRepository(), carteiraServices);
            metaServices = new MetaServices(new MetaRepository());
            gastoServices = new GastoServices(new GastoRepository());
        }
    }
}
