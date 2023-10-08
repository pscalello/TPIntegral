using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelos
{
    public class RespuestaConsultaUsuarios
    {
        public Guid id { get; private set; }
        
        public string nombre { get; private set; }
        public string apellido { get; private set; }
        public int dni { get; private set; }
        public string nombreUsuario { get; private set; }
        public int host { get; private set; }

        public RespuestaConsultaUsuarios(Guid id, string nombre, string apellido, int dni, string nombreUsuario, int host)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.nombreUsuario = nombreUsuario;
            this.host = host;
        }
    }
}
