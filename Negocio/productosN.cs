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
        public List<RespuestaConsultaProducto> listaProductos()
        {
            return ProductoD.ConsultarProductos();
        }

        public bool CrearProducto(int idCategoria, Guid idUsuario, Guid idProveedor, string nombre, double precio, int stock)
        {
            PayloadAgregarProducto producto = null;
            if (ValidarNombreProducto(nombre))
            {
                producto = new PayloadAgregarProducto(idCategoria, idUsuario, idProveedor, nombre, precio, stock);

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
            try
            {
                foreach (var nombreEnLista in Productos)
                {
                    if (nombreEnLista.nombre == nombre)
                    {
                        return false; // Nombre de producto repetido
                    }
                }
            }
            catch
            {
                return true;
            }
            return true;
        }
    }
}

           