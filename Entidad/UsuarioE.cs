using System.Net;

namespace Entidad
{
    public class UsuarioE : PersonaE
    {
        public Guid Id { get; private set; }
        public string Direccion { get; private set; }
        public string Telefono { get; private set; }
        public string Email { get; private set; }
        public DateTime FechaAlta { get; private set; }
        public DateTime? FechaBaja { get; private set; }
        public string Usuario { get; private set; }
        public int Host { get; private set; }
        public string Contraseña { get; private set; }
        public DateTime UltimaActualizacionContraseña { get; private set; }

        // Constructor vacío
        public UsuarioE()
        {
            Id = Guid.NewGuid(); // Generar un nuevo ID cuando se crea una instancia vacía.
        }

        // Constructor completo
        public UsuarioE(string nombre, string apellido, string direccion, string telefono, string email,
                        DateTime fechaAlta, DateTime fechaNacimiento, DateTime? fechaBaja, string usuario,
                        int host, int dni, string contraseña)
                        : this() // Llama al constructor vacío para generar un nuevo ID
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            FechaAlta = fechaAlta;
            FechaNacimiento = fechaNacimiento;
            FechaBaja = fechaBaja;
            Usuario = usuario;
            Host = host;
            DNI = dni;
            Contraseña = contraseña;
            UltimaActualizacionContraseña = FechaAlta;
            if (Usuario == "Administrador")
            {
                Id = Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969");
            }
        }

        // Modificacion de atrubutos
        public void SetFechaBaja(DateTime? fecha)
        {
            FechaBaja = fecha;
        }

        public void SetContraseña(string contraseña)
        {
            Contraseña = contraseña;
        }

        public void SetUltimaActualizacionContraseña(DateTime fecha)
        {
            UltimaActualizacionContraseña = fecha;
        }

        public Guid GetId(string nombreUsuario)
        {
            return Id;
        }
    }

}