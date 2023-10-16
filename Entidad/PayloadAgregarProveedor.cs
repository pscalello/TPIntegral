using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class PayloadAgregarProveedor
    {
        public Guid idUsuario { get; private set; }
        public string nombre { get; private set; }//
        public string apellido { get; private set; }//
        public string email { get; private set; }//
        public string cuit { get; private set; }//

        public PayloadAgregarProveedor(Guid idUsuario, string nombre, string apellido, string email, string cuit)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.cuit = cuit;
        }
    }
}
