using Datos.Utilidades;
using Entidad;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class VentaD
    {
        public static void CrearVenta(PayloadAgregarVenta venta)
        {
            var jsonRequest = JsonConvert.SerializeObject(venta);

            HttpResponseMessage response = WebHelper.Post("Venta/AgregarVenta", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.StatusCode.ToString());
            }
        }

        public static void DevolverVenta(Guid idVentaADevolver, Guid idUsuario)
        {
            Dictionary<String, Guid> map = new Dictionary<string, Guid>();
            map.Add("id", idVentaADevolver);
            map.Add("idUsuario", idUsuario);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteConBody("Venta/DevolverVenta", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

        }


        public static List<RespuestaConsultaVenta> ConsultarVentasPorCliente(Guid idCliente)
        {
            HttpResponseMessage response = WebHelper.Get($"Venta/GetVentaByCliente?id={idCliente}");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
            var reader = new StreamReader(response.Content.ReadAsStream());

            List<RespuestaConsultaVenta> respuesta = JsonConvert.DeserializeObject<List<RespuestaConsultaVenta>>(reader.ReadToEnd());

            return respuesta;
        }
    }
}
