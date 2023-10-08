using Datos.Utilidades;
using Entidad;
using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Net.Http;


namespace Datos
{
    public static class UsuarioD
    {
        public static void CrearUsuario(UsuarioE usuario, Guid idUsuarioCreador)
        {
            var payload = new PayloadAgregarUsuario(
                Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969"),
                usuario.Host,
                usuario.Nombre,
                usuario.Apellido,
                usuario.DNI,
                usuario.Direccion,
                usuario.Telefono,
                usuario.Email,
                usuario.FechaNacimiento,
                usuario.Usuario,
                usuario.Contraseña
                );
            var jsonRequest = JsonConvert.SerializeObject(payload);

            HttpResponseMessage response = WebHelper.Post("Usuario/AgregarUsuario", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.StatusCode.ToString());
            }
        }

        public static Guid Login(string usuario, string contraseña)
        {
            PayloadLogin login = new PayloadLogin(
                usuario,
                contraseña
                );

            var jsonRequest = JsonConvert.SerializeObject(login);

            HttpResponseMessage response = WebHelper.Post("Usuario/Login", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

            var reader = new StreamReader(response.Content.ReadAsStream());

            string respuestaString = reader.ReadToEnd().Trim(new char[] {'"', '\\'});

            //Guid respuesta = JsonConvert.Deserialize(respuestaString);

            Guid respuesta = Guid.Parse(respuestaString);

            return respuesta;
        }

        public static string CambiarContraseña(string nombreUsuario, string contraseña, string contraseñaNueva)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("nombreUsuario", nombreUsuario);
            map.Add("contraseña", contraseña);
            map.Add("contraseñaNueva", contraseñaNueva);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.Patch("Usuario/CambiarContraseña", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

            var reader = new StreamReader(response.Content.ReadAsStream());

            String respuesta = reader.ReadToEnd();

            return respuesta;
        }

        public static void BorrarUsuario(string idUsuario, string idUsuarioMaster)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", idUsuario);
            map.Add("idUsuario", idUsuarioMaster);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteConBody("Usuario/BajaUsuario", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

        }

        public static List<dynamic> ConsultarUsuarios(Guid idUsuarioMaster)
        {
            HttpResponseMessage response = WebHelper.Get("Usuario/TraerUsuariosActivos?id=" + idUsuarioMaster);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
            var reader = new StreamReader(response.Content.ReadAsStream());

            List<Object> respuesta = JsonConvert.DeserializeObject<List<dynamic>>(reader.ReadToEnd());

            return respuesta;
        }
    }
}