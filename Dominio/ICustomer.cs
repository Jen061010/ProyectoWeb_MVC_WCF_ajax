using System;
namespace Dominio
{
    public interface ICustomer
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string Phone { get; set; }
    }
}
