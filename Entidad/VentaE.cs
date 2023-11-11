using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class VentaE : RespuestaConsultaVenta
    {
        public Guid id {  get; set; }
        public int cantidad { get; set; }
        public string fechaAlta { get; set; }
        public int estado { get; set; }
        public Guid idCliente { get; set; }

        public VentaE(
            Guid id, int cantidad, string fechaAlta, int estado, Guid idCliente
            ) 
            : base(id, cantidad, fechaAlta, estado)
        {
            this.id = id;
            this.cantidad = cantidad;
            this.fechaAlta = fechaAlta;
            this.estado = estado;
            this.idCliente = idCliente;
        } 
    }
}
