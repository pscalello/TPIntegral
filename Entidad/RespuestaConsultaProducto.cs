using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RespuestaConsultaProducto
    {

        public Guid id { get; private set; }
        public Guid idCategoria { get; private set; }
        public string nombre { get; private set; }
        public DateTime fechaAlta { get; private set; }
        public DateTime? fechaBaja { get; private set; }
        public double precio { get; private set; }
        public int stock { get; private set; }
        public Guid idUsuario { get; private set; }
        public Guid idProveedor { get; private set; }

        public RespuestaConsultaProducto(Guid id, Guid idCategoria, string nombre, DateTime fechaAlta, DateTime? fechaBaja, double precio, int stock, Guid idUsuario, Guid idProveedor)
        {
            this.id = id;
            this.idCategoria = idCategoria;
            this.nombre = nombre;
            this.fechaAlta = fechaAlta;
            this.fechaBaja = fechaBaja;
            this.precio = precio;
            this.stock = stock;
            this.idUsuario = idUsuario;
            this.idProveedor = idProveedor;
        }
    }
}
