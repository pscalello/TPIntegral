using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class PayloadAgregarProducto
    {
        public int idCategoria { get; private set; }
        public Guid idUsuario { get; private set; }
        public Guid idProveedor { get; private set; }
        public string nombre { get; private set; }
        public double precio { get; private set; }
        public int stock { get; private set; }



        public PayloadAgregarProducto(int idCategoria, Guid idUsuario, Guid idProveedor, string nombre,double precio, int stock)
        {
            this.idCategoria = idCategoria;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
            this.idUsuario = idUsuario;
            this.idProveedor = idProveedor;
        }
    }
}
