using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceCustomer
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/Add/",
            Method="POST")]
        Customer Add(Customer customer);

        [OperationContract]
        [WebInvoke(UriTemplate = "/Delete/{id}",
            Method="DELETE")]
        void Delete(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/Update/{id}",ResponseFormat=WebMessageFormat.Json,
            Method="PUT")]
        void Update(string id,Customer customer);

        [OperationContract]
        [WebGet(ResponseFormat=WebMessageFormat.Json)]
        IEnumerable<Customer> GetAlls();

        [OperationContract]
        [WebGet(UriTemplate = "/Customer/{name}",ResponseFormat=WebMessageFormat.Json)]
        IEnumerable<Customer> GetAll(string name);


        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
