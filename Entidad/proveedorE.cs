using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class proveedorE
    {
        //atributos

        private Guid _id;
        private Guid _idProducto;
        private string _nombreProv;
        private string _apellidoProv;
        private DateTime _fechaAlta;
        private DateTime _fechaBaja;
        private int _cuit;
        private string _email;
        private Guid _idUsuario;

        //propiedades

        public Guid Id { get => _id; set => _id = value; }
        public Guid IdProducto { get => _idProducto; set => _idProducto = value; }
        public string NombreProv { get => _nombreProv; set => _nombreProv = value; }
        public string ApellidoProv { get => _apellidoProv; set => _apellidoProv = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get => _fechaBaja; set => _fechaBaja = (DateTime)value; }
        public int Cuit { get => _cuit; set => _cuit = value; }
        public string Email { get => _email;  set => _email = value; }
        public Guid IdUsuario { get => _idUsuario;  set => _idUsuario = value;}

        //constructor vacio

        public proveedorE()
        {

            Id = Guid.NewGuid(); // Generar un nuevo ID cuando se crea una instancia vacía.
        }

        // Constructor completo
        public proveedorE(string nombreProv, string apellidoProv, DateTime fechaAlta, DateTime? fechaBaja, int cuit, string email)
                        : this() // Llama al constructor vacío para generar un nuevo ID
        {
           NombreProv = nombreProv;
           ApellidoProv = apellidoProv;
           FechaAlta = fechaAlta;
           FechaBaja = fechaBaja;
           Cuit = cuit;
           Email = email;

        }

        //Deberá permitir registrar la categoría de productos para cada proveedor (un proveedor puede estar en más de una categoría)
        //siguiendo el anexo Categoría de productos 

        public void RegistroCategoriaProd()
        {
            
        }


        public void BajaProveedor()
        {

        }
    }
}

