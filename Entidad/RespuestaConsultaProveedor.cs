using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RespuestaConsultaProveedores
    {
        public Guid id { get; private set; }

        public string nombre { get; private set; }
        public string apellido { get; private set; }
        public string email { get; private set; }
        public string cuit { get; private set; }
        public DateTime fechaAlta { get; private set; }
        public DateTime? fechaBaja { get; private set; }

        public RespuestaConsultaProveedores(Guid id, string nombre, string apellido, string email, string cuit, DateTime fechaAlta, DateTime? fechaBaja)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.fechaAlta = fechaAlta;
            this.fechaBaja = fechaBaja;
        }
    }
}
