using Autofac;
using Autofac.Integration.Web;
using Dominio;
using Infraestructura;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using WebForms;

namespace WebForms
{
    public class Global : HttpApplication,IContainerProviderAccessor
    {
        static IContainerProvider _containerProvider;

        public IContainerProvider ContainerProvider
        {
            get { return _containerProvider; }
        }

        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciarse la aplicación
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();
            //Autofac: http://docs.autofac.org/en/latest/integration/webforms.html
            var builder = new ContainerBuilder();
            builder.RegisterType<Customer>().As<ICustomer>().InstancePerRequest();
            builder.RegisterType<CustomerService>().As<ICustomerService>().InstancePerRequest();
            builder.RegisterType<CustomerDbContext>().As<ICustomerDbContext>().InstancePerRequest();

            _containerProvider = new ContainerProvider(builder.Build());
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Código que se ejecuta al cerrarse la aplicación

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Código que se ejecuta cuando se produce un error sin procesar

        }
    }
}
