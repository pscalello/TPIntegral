using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RespuestaConsultaProducto//
    {
        public Guid id { get; private set; }

        public int idCategoria { get; private set; }
        public Guid idUsuario { get; private set; }
        public Guid idProveedor { get; private set; }
        public string nombre { get; private set; }
        public double precio { get; private set; }
        public int stock { get; private set; }

        public RespuestaConsultaProducto(Guid id, int idCategoria, Guid idUsuario, Guid idProveedor, string nombre, double precio, int stock)
        {
            this.id = id;
            this.idCategoria = idCategoria;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
            this.idUsuario = idUsuario;
            this.idProveedor = idProveedor;
        }
    }
}
