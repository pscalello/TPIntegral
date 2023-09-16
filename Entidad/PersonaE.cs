using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public abstract class PersonaE
    {
        public string Nombre { get;  set; }
        public string Apellido { get;  set; }
        public DateTime FechaNacimiento { get;  set; }
        public int DNI { get;  set; }
    }
}
