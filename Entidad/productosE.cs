using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class productosE
    {
        //atributos

        private Guid _id;
        private Guid _idCategoria;
        private string _nombre;
        private DateTime _fechaAlta;
        private DateTime? _fechaBaja;
        private double _precio;
        private int _stock;
        private Guid _idUsuario;
        private Guid _idProveedor;

        //propiedades

        public Guid Id { get => _id; set => _id = value; }
        public Guid IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get => _fechaBaja; set => _fechaBaja = (DateTime)value; }
        public double Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public Guid IdProveedor { get => _idProveedor; set => _idProveedor = value; }

        //metodos

        public void RegistrarProducto()
        {


        }

    }
}
