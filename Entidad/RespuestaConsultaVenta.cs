using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RespuestaConsultaVenta
    {
        public Guid id;
        public int cantidad;
        public string fechaAlta;
        public int estado;
        public string? cliente;

        public RespuestaConsultaVenta(Guid id, int cantidad, string fechaAlta, int estado) 
        {
            this.id = id;
            this.cantidad = cantidad;
            this.fechaAlta = fechaAlta;
            this.estado = estado;
        }
    }
}
