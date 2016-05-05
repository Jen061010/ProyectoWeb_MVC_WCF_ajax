using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class CustomerDbContext: DbContext,ICustomerDbContext
        
       
        
    {
        public CustomerDbContext()
            : base("DefaultConnection")
        {
            var cadenaConexion = this.Database.Connection.ConnectionString;
        }

        public DbSet<Customer> Customers { get; set; }
      


    }
}
