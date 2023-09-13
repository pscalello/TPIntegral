using Entidad;
using System;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Negocio
{

    public class UsuarioN
    {

        // Sirve para persistir datos, hasta que tengamos capa de datos. 
        public static List<UsuarioE> Usuarios = new List<UsuarioE>();


        //***************************************************************************************************************************** 
        //                                             CREACION DE USUARIO                                                           //
        //*****************************************************************************************************************************


        public bool CrearUsuario(string nombre, string apellido, string direccion, string telefono,
                                    string email, DateTime fechaAltaEmpresa, DateTime fechaNacimiento,
                                    string usuario, int host, int dni)
        {


            // VALIDACIONES DE USUARIO DE ACUERDO A REGLAS DE NEGOCIO ANTES DE INSERTAR



            UsuarioE UsuarioNuevo = null;

            if (ValidarNombreUsuario(usuario, nombre, apellido)) 

            {
                // Al crear un usuario, debe permanecesr inactivo (fecha de baja no null) y con una contraseña genérica hasta primer ingreso:
                DateTime fechaBaja = DateTime.Now;
                string Contraseña = "CAI20232";
                UsuarioNuevo = new UsuarioE(nombre, apellido, direccion, telefono, email, fechaAltaEmpresa,
                                                    fechaNacimiento, fechaBaja, usuario, host, dni, Contraseña);

                // Lo guarda en lista de esta capa, simulando DATOS
                Usuarios.Add(UsuarioNuevo);
                return true;
            }
            return false; //En caso que no pase las validaciones, le informa a PRESENTACION que el alta no fue realizada
        }


        //***************************************************************************************************************************** 
        //                                             CONSULTA DE USUARIO                                                           //
        //*****************************************************************************************************************************


        // METODO QUE CONSULTA USUARIOS EN BASE A UNA PETICION
        public List<UsuarioE> ConsultarUsuarios(int tipoConsulta, Guid id)
        {
            // Los tipos de consulta pueden ser:
            // 1: Devolver todos los usuarios
            // 2: Devolver Administradores
            // 3: Devolver Supervisores
            // 4: Devolver Vendedores
            // 5: Devolver un usuario por nro de ID

            List<UsuarioE> consultausuarios = new List<UsuarioE>();

            // Recorre la lista provisoria que simula la base de datos USUARIO y completa la lista Consultausuarios en base a los filtros definidos

            // Si es 1, devuelve todos
            if (tipoConsulta == 1) { consultausuarios = Usuarios; }

            // Si es 2, 3 o 4, le resta 1 al tipo y devuelve todos (puesto que 1 es Admin, 2 es supervisor y 3 es vendedor)

            if (tipoConsulta == 2 || tipoConsulta == 3 || tipoConsulta == 4)
            {
                foreach (var usuarioEnLista in Usuarios)
                {
                    if (usuarioEnLista.Host == tipoConsulta - 1)
                    {
                        consultausuarios.Add(usuarioEnLista);
                    }
                }
            }

            // Si es 5, busca el id
            if (tipoConsulta == 5)
                foreach (var usuarioEnLista in Usuarios)
                {
                    if (usuarioEnLista.Id == id) // Busca el usuario del id a cambiar estado
                    {
                        consultausuarios.Add(usuarioEnLista);
                    }
                }

            return consultausuarios;
        }


        //***************************************************************************************************************************** 
        //                                             AUTENTICACIÓN DE USUARIO                                                       //
        //*****************************************************************************************************************************

        public int AutenticarUsuario(string usuario, string Contraseña, int intentos)
        {

            // Recorrer la lista de usuarios y verificar las credenciales
            // Esta función puede devolver 1, 2 o 3 (ADMIN, SUPERVISOR O VENDEDOR), o
            // 0 (usuario o pass incorrecto) o -1 (probó más de 3 veces, pasa a incactivo)
            // Devolverá -2 cuándo haga falta modificar la contraseña

            if (intentos == 3) // Si intento 3 veces y encuentra el nombre de usuario (puede estar ingresando cosas inexistentes), cambiar el estado y devolver -1
            {
                foreach (var usuarioEnLista in Usuarios)
                {
                    if (usuarioEnLista.Usuario == usuario) // Busca el id a cambiar estado
                    {
                        ActivoInactivo(usuarioEnLista.Id, false); // pasa a estar inactivo
                    }
                }
                return -1;
            }

            foreach (var usuarioEnLista in Usuarios)
            {
                if (usuarioEnLista.Usuario == usuario && usuarioEnLista.Contraseña == Contraseña)
                {
                    // Si el usuario y la contraseña son correctos, valida si hace falta cambio de contraseña.
                    // Los supuestos de cambio de contraseña son 2:usu
                    // 1) Cuándo es primer ingreso (pass = CAI20232 y fecha de baja no nula)
                    // 2) Cuándo expira la contraseña (30 días después de la fecha de alta)
                    // En ambos casos la función devuelve un -2 para mostrar menú de cambio

                    DateTime fechaTope = usuarioEnLista.UltimaActualizacionContraseña.AddDays(30);
                    if ((usuarioEnLista.Contraseña == "CAI20232" && usuarioEnLista.FechaBaja != null) || fechaTope <= DateTime.Now)
                    {
                        return -2;
                    }
                    else
                    {
                        // Autenticación exitosa, devuelve valor de host para armar menu: 1 ADMIN, 2 SUPERVISOR, 3 VENDEDOR
                        return usuarioEnLista.Host;
                    }
                }
            }

            // Si no se encuentra el usuario o las credenciales no coinciden, devolver 0
            return 0;
        }


        //***************************************************************************************************************************** 
        //                                             CAMBIO DE CONTRASEÑA                                                          //
        //*****************************************************************************************************************************

        public bool CambioContraseña(string usuario, string nuevaContraseña)
        {
            UsuarioE UsuarioNuevo = null;

            // Valida que la contraseña no sea igual a la anterior, ni igual a la default, que tenga entre 8
            // y 15 caracteres y que tenga una mayúscula y un número


            foreach (var usuarioEnLista in Usuarios)
            {
                if (usuarioEnLista.Usuario == usuario)
                {
                    if (nuevaContraseña != usuarioEnLista.Contraseña &&
                        nuevaContraseña != "CAI20232" &&
                        nuevaContraseña.Length >= 8 && nuevaContraseña.Length <= 15 &&
                        nuevaContraseña.Any(char.IsUpper) && nuevaContraseña.Any(char.IsDigit))
                    {
                        // Si todas las validaciones pasan, actualiza la contraseña del usuario
                        usuarioEnLista.SetContraseña(nuevaContraseña);
                        usuarioEnLista.SetUltimaActualizacionContraseña(DateTime.Now);
                        return true;
                    }
                }
            }

            // Si no retornó verdadero, no comprobó reglas de negocio y no actualiza contraseña, devuelve falso

            return false;

        }








        // CAMBIA ESTADO ACTIVO O INACTIVO EN BASE A UN GUID Y EL ESTADO DESEADO

        private void ActivoInactivo(Guid id, bool activo)
        {
            // Recibe un ID de usuario y cambia el estado
            foreach (var usuarioEnLista in Usuarios)
            {
                if (usuarioEnLista.Id == id) // Busca el usuario del id a cambiar estado
                {
                    if (activo) // si tiene que estar activo, null a fecha de baja
                    {
                        usuarioEnLista.SetFechaBaja(null);
                    }
                    else // si tiene que estar inactivo, se pone la fecha de hoy
                    {
                        usuarioEnLista.SetFechaBaja(DateTime.Now);
                    }
                }
            }
        }



        // VALIDACIONES DE NEGOCIO

        // Valida Nombre de Usuario
        public static bool ValidarNombreUsuario(string usuario, string nombre, string apellido)
        {
            // El nombre de usuario debe de tener entre 8 y 15 caracteres
            if (usuario.Length < 8 || usuario.Length > 15)
            {
                return false; // Fuera del rango de caracteres permitidos
            }
            // El nombre de usuario no puede contener ni el nombre ni el apellido del usuario 
            if (usuario.ToUpper().Contains(nombre.ToUpper()) || usuario.ToUpper().Contains(apellido.ToUpper()))
            {
                return false; // Contiene el nombre o apellido del usuario
            }

            foreach (var usuarioEnLista in Usuarios)
            {
                if (usuarioEnLista.Usuario == usuario) 
                {
                    return false; ; // Nombre de usuario repetido
                }
            }

            return true; // Cumple con todas las condiciones
        }

        private bool NoRepeticionUsuario(UsuarioE usuario)
        {
            // Verificar si el nombre de usuario ya existe en la lista
            if (Usuarios.Contains(usuario))
            {
                Console.WriteLine("El nombre de usuario ya existe en el registro.");
                return false; // Nombre de usuario repetido
            }
            else
            {
                return true; // Nombre de usuario único
            }
        }

    }
}
