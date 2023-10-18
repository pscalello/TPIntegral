using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProductosN
    {
        // La llenamos con todos los productos activos con el ID
        private static List<RespuestaConsultaProducto> Productos = ProductoD.ConsultarProductos();

        public bool CrearProducto(int host, Guid id, Guid idCategoria, string nombre, DateTime fechaAlta, DateTime? fechaBaja, double precio, int stock, Guid idUsuario, Guid idProveedor)
        {
            PayloadAgregarProducto producto = null;
            if (ValidarNombreProducto(nombre))
            {
                
                id = Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969");
                producto = new PayloadAgregarProducto(id, idCategoria, nombre, fechaAlta, fechaBaja, precio, stock, idUsuario, idProveedor);

                try
                {
                    // Producto creado con éxito
                    ProductoD.CrearProducto(producto);
                    return true;
                }
                catch (Exception ex)
                {
                    // Hubo un error al crear el usuario
                    return false;
                }

            }
            return false;


        }

        public bool ValidarNombreProducto(string nombre)
        {

            foreach (var nombreEnLista in Productos)
            {
                if (nombreEnLista.nombre == nombre)
                {
                    return false; // Nombre de producto repetido
                }
            }

            return true; // Cumple con la condicion
        }
    }
}
