using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public abstract class PersonaE
    {
        public string nombre { get;  set; }
        public string apellido { get;  set; }
        public DateTime fechaNacimiento { get;  set; }
        public int dni { get;  set; }
    }
}
