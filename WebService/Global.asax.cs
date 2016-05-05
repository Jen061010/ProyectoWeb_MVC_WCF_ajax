using Autofac;
using Autofac.Integration.Wcf;
using Dominio;
using Infraestructura;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebService
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
           
              var builder = new ContainerBuilder();

              // Register your service implementations.
              builder.RegisterType<ServiceCustomer>().As<IServiceCustomer>();
              builder.RegisterType<CustomerService>().As<ICustomerService>();
              builder.RegisterType<CustomerDbContext>().As<ICustomerDbContext>();

              // Set the dependency resolver.
              var container = builder.Build();
              AutofacHostFactory.Container = container;

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

       protected void Application_BeginRequest(object sender, EventArgs e)
        {
            

                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
                if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
                {
                    HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "POST, PUT, DELETE");

                    HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept");
                    HttpContext.Current.Response.AddHeader("Access-Control-Max-Age", "1728000");
                    HttpContext.Current.Response.End();
                }

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}