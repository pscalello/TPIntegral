using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Utilidades
{
    public class PayloadLogin
    {
        public string nombreUsuario { get; private set; }
        public string contraseña { get; private set; }

        public PayloadLogin(string nombreUsuario, string contraseña)
        {
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
        }
    }
}
