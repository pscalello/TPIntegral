using Datos;
//using Datos.Modelos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Negocio
{
    public class UsuarioN
    {


        // La llenamos con todos los usuarios activos con el ID de superusuario
        private static List<RespuestaConsultaUsuarios> Usuarios = UsuarioD.ConsultarUsuarios(Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969"));



        //***************************************************************************************************************************** 
        //                                             CREACION DE USUARIO                                                           //
        //*****************************************************************************************************************************


        public bool CrearUsuario(int host, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario)
        {

            PayloadAgregarUsuario UsuarioNuevo = null;
            if (ValidarNombreUsuario(nombreUsuario, nombre, apellido)) 

            {
                string contraseña = "CAI20232";
                Guid idUsuario = Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969");
                UsuarioNuevo = new PayloadAgregarUsuario(idUsuario, host, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña);
                
                try
                {
                    // Usuario creado con éxito
                    UsuarioD.CrearUsuario(UsuarioNuevo);
                    return true;
                }
                catch (Exception ex)
                {
                    // Hubo un error al crear el usuario
                    return false;
                }

            }
            return false; //En caso que no pase las validaciones, le informa a PRESENTACION que el alta no fue realizada
        }

        // Valida Nombre de Usuario
        public bool ValidarNombreUsuario(string usuario, string nombre, string apellido)
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
                if (usuarioEnLista.nombreUsuario == usuario)
                {
                    return false; // Nombre de usuario repetido
                }
            }

            return true; // Cumple con todas las condiciones
        }


        //***************************************************************************************************************************** 
        //                                             ELIMINACION DE USUARIO                                                         //
        //*****************************************************************************************************************************

        public bool EliminarUsuario(Guid idUsuario)
        {
            Guid idUsuarioAdmin = Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969");
            try
            {
                    UsuarioD.BorrarUsuario(idUsuario, idUsuarioAdmin);
                    return true;
            }
            catch (Exception ex)
            {
                    return false;
            }
        }

        //***************************************************************************************************************************** 
        //                                             CONSULTA DE USUARIO                                                           //
        //*****************************************************************************************************************************


        // METODO QUE CONSULTA USUARIOS EN BASE A UNA PETICION
        public List<RespuestaConsultaUsuarios> ConsultarUsuarios(int tipoConsulta, string id, Guid idAdmin)
        {
            Guid idParseado = Guid.Parse("00000000-0000-0000-0000-000000000000"); // GUID default, instanciado para evitar errores

            // Los tipos de consulta pueden ser:
            // 1: Devolver todos los usuarios
            // 2: Devolver Supervisores
            // 3: Devolver Vendedores
            // 4: Devolver Administradores
            // 5: Devolver un usuario por nro de ID

            List<RespuestaConsultaUsuarios> consultaUsuarios = UsuarioD.ConsultarUsuarios(idAdmin);
            List<RespuestaConsultaUsuarios> usuariosADevolver = new List<RespuestaConsultaUsuarios>();

            // Recorre la lista provisoria que simula la base de datos USUARIO y completa la lista Consultausuarios en base a los filtros definidos

            // Si es 1, devuelve todos
            if (tipoConsulta == 1) { usuariosADevolver = consultaUsuarios; }

            // Si es 2, 3 o 4, le resta 1 al tipo y devuelve todos (puesto que 1 es Admin, 2 es supervisor y 3 es vendedor)

            if (tipoConsulta == 2 || tipoConsulta == 3 || tipoConsulta == 4)
            {
                foreach (RespuestaConsultaUsuarios usuarioEnLista in consultaUsuarios)
                {
                    if (usuarioEnLista.host == tipoConsulta - 1)
                    {
                        usuariosADevolver.Add(usuarioEnLista);
                    }
                }
            }

            // Si es 5, busca el id
            if (tipoConsulta == 5) {
                try
                {
                    idParseado = Guid.Parse(id);
                    foreach (RespuestaConsultaUsuarios usuarioEnLista in consultaUsuarios)
                    {
                        if (usuarioEnLista.id == idParseado) // Busca el usuario del id a cambiar estado
                        {
                            usuariosADevolver.Add(usuarioEnLista);
                        }
                    }
                    if (!usuariosADevolver.Any())
                    {
                        Console.WriteLine("Usuario no encontrado. Es posible que se encuentre inactivo o que no exista.");
                    }
                } catch
                {
                    Console.WriteLine("ID inválido. Recuerde que el formato del guid es XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX, " +
                        "donde cada X representa un carácter numérico." + "\n");
                }
            }

            return usuariosADevolver;
        }


        //***************************************************************************************************************************** 
        //                                             AUTENTICACIÓN DE USUARIO                                                       //
        //*****************************************************************************************************************************

        public string Login(LoginE loginE)
        {
            // Esta funcion puede devolver un ID, o bien
            // -1 para indicar que no coincide usuario y contraseña. o bien
            // -2 para indicar que debe modificar su contraseña
            try
            {
                string respuesta;
                respuesta = UsuarioD.Login(loginE);
                if (loginE.Contraseña == "CAI20232") // si no hay excepción, se loguea y esta es la password, retorna -2
                {
                    return "-2";
                }
                else
                {
                    return respuesta;
                }
                return UsuarioD.Login(loginE); // Si es correcta, devuelve ID de usuario. Sino, devuelve una excepcion
            }
            catch (Exception ex) // Si captura excepcion, el logueo no fue correcto.
            {
                return "-1";
            }
        }


        //***************************************************************************************************************************** 
        //                                             CAMBIO DE CONTRASEÑA                                                          //
        //*****************************************************************************************************************************

        public bool CambioContraseña(string usuario, string viejaContraseña, string nuevaContraseña)
        {
            UsuarioE UsuarioNuevo = null;

            // Valida que la contraseña no sea igual a la anterior, ni igual a la default, que tenga entre 8
            // y 15 caracteres y que tenga una mayúscula y un número

                    if (// nuevaContraseña != usuarioEnLista.Contraseña &&
                        nuevaContraseña != "CAI20232" &&
                        nuevaContraseña.Length >= 8 && nuevaContraseña.Length <= 15 &&
                        nuevaContraseña.Any(char.IsUpper) && nuevaContraseña.Any(char.IsDigit))
                    {
                        // Si todas las validaciones pasan, actualiza la contraseña del usuario
                        UsuarioD.CambiarContraseña(usuario, viejaContraseña, nuevaContraseña);
                        return true;
                    }

            // Si no retornó verdadero, no comprobó reglas de negocio y no actualiza contraseña, devuelve falso

            return false;

        }

        public Guid BuscarId(string nombreUsuario)
        {
            // busca entre todos los usuarios el que tenga el mismo nombre de usuario, y devuelve el Id.
            return Usuarios.Find((usuario) => usuario.nombreUsuario == nombreUsuario).id;
        }

        public int BuscarHostUsuario(Guid idUsuario)
        {

            List<RespuestaConsultaUsuarios> listaUsuarios = UsuarioD.ConsultarUsuarios(Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969"));
            try
            {
                return listaUsuarios.Find((usuario) => usuario.id == idUsuario).host;
            }
            catch (Exception ex)
            {
                return 0;   
            }
        }

        public List<RespuestaConsultaUsuarios> listaUsuarios ()
        {
            return UsuarioD.ConsultarUsuarios(Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969"));
        }




        public bool DarUsuariodeBaja(string nombreUsuarioABorrar, Guid idUsuarioAdmin)
        {
            RespuestaConsultaUsuarios usuarioADarDeBaja = null;
            Guid idUsuarioADarDeBaja = Guid.Parse("00000000-0000-0000-0000-000000000000"); // GUID default, instanciado para evitar errores;

            List<RespuestaConsultaUsuarios> listaUsuarios = UsuarioD.ConsultarUsuarios(idUsuarioAdmin);

            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (listaUsuarios[i].nombreUsuario == nombreUsuarioABorrar)
                {
                    usuarioADarDeBaja = listaUsuarios[i];
                    try
                    {
                        //idUsuarioADarDeBaja = usuarioADarDeBaja.id;
                        UsuarioD.BorrarUsuario(idUsuarioADarDeBaja, idUsuarioAdmin);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Error al borrar el usuario, revise sus permisos.");
                        break;
                    }
                }
            }

            if (usuarioADarDeBaja != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        // CAMBIA ESTADO ACTIVO O INACTIVO EN BASE A UN GUID Y EL ESTADO DESEADO

        //private void ActivoInactivo(Guid id, bool activo)
        //{
        //    // Recibe un ID de usuario y cambia el estado
        //    foreach (var usuarioEnLista in Usuarios)
        //    {
        //        if (usuarioEnLista.id == id) // Busca el usuario del id a cambiar estado
        //        {
        //            if (activo) // si tiene que estar activo, null a fecha de baja
        //            {
        //                usuarioEnLista.SetFechaBaja(null);
        //            }
        //            else // si tiene que estar inactivo, se pone la fecha de hoy
        //            {
        //                usuarioEnLista.SetFechaBaja(DateTime.Now);
        //            }
        //        }
        //    }
        //}



        // VALIDACIONES DE NEGOCIO



        private bool NoRepeticionUsuario(RespuestaConsultaUsuarios usuario)
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
