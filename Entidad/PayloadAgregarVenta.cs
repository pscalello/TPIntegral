using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class PayloadAgregarVenta
    {
        public Guid idCliente;
        public Guid idUsuario;
        public Guid idProducto;
        public int cantidad;

        public PayloadAgregarVenta(Guid idCliente, Guid idUsuario, Guid idProducto, int cantidad)
        {
            this.idCliente = idCliente;
            this.idUsuario = idUsuario;
            this.idProducto = idProducto;
            this.cantidad = cantidad;
        }
    }
}
