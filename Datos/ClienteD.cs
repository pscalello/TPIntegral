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
    public static class ClienteD
    {

        public static void CrearCliente(PayloadAgregarCliente cliente)
        {
            var jsonRequest = JsonConvert.SerializeObject(cliente);

            HttpResponseMessage response = WebHelper.Post("Cliente/AgregarCliente", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.StatusCode.ToString());
            }
        }

        public static void BorrarCliente(Guid idClienteABorrar)
        {
            Dictionary<String, Guid> map = new Dictionary<string, Guid>();
            map.Add("id", idClienteABorrar);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteConBody("Cliente/BajaCliente", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

        }

        public static List<RespuestaConsultaCliente> ConsultarClientes()
        {
            HttpResponseMessage response = WebHelper.Get("Cliente/GetClientes"); 

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados"); //da error acá
            }
            var reader = new StreamReader(response.Content.ReadAsStream());

            List<RespuestaConsultaCliente> respuesta = JsonConvert.DeserializeObject<List<RespuestaConsultaCliente>>(reader.ReadToEnd());

            return respuesta;
        }


    }
}