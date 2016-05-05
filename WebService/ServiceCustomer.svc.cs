using Dominio;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceCustomer : IServiceCustomer
    {
        readonly ICustomerService _service;
        public ServiceCustomer(ICustomerService service)
        {
            _service = service;
        }
        public Customer Add(Customer customer)
        { 
            return _service.Add(customer);
        }
        public IEnumerable<Customer> GetAlls()
        {
            return _service.GetAlls();
        }
        public IEnumerable<Customer> GetAll(string name)
        {
            return _service.GetAll(name);
        }
        public void Delete(string id)
        {
            int id_int;
            if (!Int32.TryParse(id, out id_int)) 
            {
                throw new ArgumentException("Debe ser un número");
            }
            
             _service.Delete(id_int);
        }
        public void Update(string id, Customer customer)
        {
            int id_int = Convert.ToInt32(id);
             _service.Update(id_int, customer);
        }
    }
}
