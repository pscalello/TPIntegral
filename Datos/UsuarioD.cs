using Datos.Utilidades;
using Entidad;
using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net.Http;


namespace Datos
{
    public class UsuarioD
    {
        public static void CrearUsuario(UsuarioE usuario)
        {
            var jsonRequest = JsonConvert.SerializeObject(usuario);

            HttpResponseMessage response = WebHelper.Post("Usuario/AgregarUsuario", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.StatusCode.ToString());
            }
        }

        //public static string Login(Login login)
        //{
        //    var jsonRequest = JsonConvert.SerializeObject(login);

        //    HttpResponseMessage response = WebHelper.Post("Usuario/Login", jsonRequest);

        //    if (!response.IsSuccessStatusCode)
        //    {
        //        throw new Exception("Verifique los datos ingresados");
        //    }

        //    var reader = new StreamReader(response.Content.ReadAsStream());

        //    String respuesta = reader.ReadToEnd();

        //    return respuesta;
        //}

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
    }
}