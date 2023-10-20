using System.Net;

namespace Entidad
{
    public class UsuarioE : PersonaE
    {
        public Guid id { get; private set; }
        public string direccion { get; private set; }
        public string telefono { get; private set; }
        public string email { get; private set; }
        public DateTime fechaAlta { get; private set; }
        public DateTime? fechaBaja { get; private set; }
        public string nombreUsuario { get; private set; }
        public int host { get; private set; }
        public string contraseña { get; private set; }
        //public DateTime UltimaActualizacionContraseña { get; private set; }

        // Constructor vacío
        public UsuarioE()
        {
            id = Guid.NewGuid(); // Generar un nuevo ID cuando se crea una instancia vacía.
        }

        // Constructor completo
        public UsuarioE(string nombre, string apellido, string direccion, string telefono, string email,
                        DateTime fechaAlta, DateTime fechaNacimiento, DateTime? fechaBaja, string usuario,
                        int host, int dni, string contraseña)
                        : this() // Llama al constructor vacío para generar un nuevo ID
        {
            nombre = nombre;
            apellido = apellido;
            direccion = direccion;
            telefono = telefono;
            email = email;
            fechaAlta = fechaAlta;
            fechaNacimiento = fechaNacimiento;
            fechaBaja = fechaBaja;
            nombreUsuario = usuario;
            host = host;
            dni = dni;
            contraseña = contraseña;
//            UltimaActualizacionContraseña = FechaAlta;
        }


        // Modificacion de atrubutos
        public void SetFechaBaja(DateTime? fecha)
        {
            fechaBaja = fecha;
        }

        public void SetContraseña(string contraseña)
        {
            //aca iria un this.contraseña = contraseña; ?
            contraseña = contraseña;
        }

        //public void SetUltimaActualizacionContraseña(DateTime fecha)
        //{
        //    UltimaActualizacionContraseña = fecha;
        //}

        public Guid GetId(string nombreUsuario)
        {
            return id;
        }
    }

}