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
    public class ProveedorD
    {

        public static void CrearProveedor(PayloadAgregarProveedor proveedor)
        {
            var jsonRequest = JsonConvert.SerializeObject(proveedor);

            HttpResponseMessage response = WebHelper.Post("Proveedor/AgregarProveedor", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.StatusCode.ToString());
            }
        }

        public static void BorrarProveedor(Guid idProveedorABorrar, Guid idUsuarioAdmin)
        {
            Dictionary<String, Guid> map = new Dictionary<string, Guid>();
            map.Add("id", idProveedorABorrar);
            map.Add("idUsuario", idUsuarioAdmin);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteConBody("Proveedor/BajaProveedor", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

        }


        public static List<RespuestaConsultaProveedores> ConsultarProveedores()
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
