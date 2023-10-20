using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class PayloadAgregarUsuario
    {
        public Guid idUsuario { get; private set; }
        public int host { get; private set; }
        public string nombre { get; private set; }
        public string apellido { get; private set; }
        public int dni { get; private set; }
        public string direccion { get; private set; }
        public string telefono { get; private set; }
        public string email { get; private set; }
        public DateTime fechaNacimiento { get; private set; }
        public string nombreUsuario { get; private set; }
        public string contraseña { get; private set; }

        public PayloadAgregarUsuario(Guid idUsuario, int host, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario, string contraseña)
        {
            this.idUsuario = idUsuario;
            this.host = host;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
        }
    }
}
