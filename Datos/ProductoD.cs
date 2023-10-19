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
    public class ProductoD
    {
        public static void CrearProducto(PayloadAgregarProducto producto)
        {
            var jsonRequest = JsonConvert.SerializeObject(producto);

            HttpResponseMessage response = WebHelper.Post("Producto/AgregarProducto", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.StatusCode.ToString());
            }
        }

        public static void BorrarProducto(Guid idProductoABorrar, Guid idUsuarioAdmin)
        {
            Dictionary<String, Guid> map = new Dictionary<string, Guid>();
            map.Add("id", idProductoABorrar);
            map.Add("idUsuario", idUsuarioAdmin);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteConBody("Producto/BajaProducto", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

        }

        public static List<RespuestaConsultaProducto> ConsultarProductos()
        {
            HttpResponseMessage response = WebHelper.Get("Producto/TraerProductos");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
            var reader = new StreamReader(response.Content.ReadAsStream());

            List<RespuestaConsultaProducto> respuesta = JsonConvert.DeserializeObject<List<RespuestaConsultaProducto>>(reader.ReadToEnd());

            return respuesta;
        }



    }
}
