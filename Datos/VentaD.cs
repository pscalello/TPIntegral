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


        public static List<RespuestaConsultaProveedores> ConsultarVentas()
        {
            HttpResponseMessage response = WebHelper.Get("Proveedor/TraerProveedores");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
            var reader = new StreamReader(response.Content.ReadAsStream());

            List<RespuestaConsultaProveedores> respuesta = JsonConvert.DeserializeObject<List<RespuestaConsultaProveedores>>(reader.ReadToEnd());

            return respuesta;
        }
    }
}
