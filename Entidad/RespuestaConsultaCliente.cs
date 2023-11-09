using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RespuestaConsultaCliente
    {
        public Guid idUsuario { get; private set; } //
        public string nombre { get; private set; } //
        public string apellido { get; private set; } //
        public int dni { get; private set; } //
        public string direccion { get; private set; } //
        public string telefono { get; private set; } //
        public string email { get; private set; } //
        public DateTime fechaNacimiento { get; private set; } //
        public string host { get; private set; } //

        public RespuestaConsultaCliente(Guid idUsuario, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string host)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
            this.host = host;
        }
    }
}
