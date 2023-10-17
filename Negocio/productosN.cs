using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class productosN
    {

        public bool CrearProducto(Guid id, Guid idCategoria, string nombre, DateTime fechaAlta, DateTime? fechaBaja, double precio, int stock, Guid idUsuario, Guid idProveedor)
        {

            PayloadAgregarProducto ProductoNuevo = null;
 
            //acá iria un if?
            
                //Guid id = Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969");
                ProductoNuevo = new PayloadAgregarProducto(id, idCategoria, nombre, fechaAlta, fechaBaja, precio, stock, idUsuario, idProveedor);

                try
                {
                    // Producto creado con éxito
                    ProductoD.CrearProducto(ProductoNuevo);
                    return true;
                }
                catch (Exception ex)
                {
                    // Hubo un error al crear el usuario
                    return false;
                }

            
            //return false; (faltaria un if?) //En caso que no pase las validaciones, le informa a PRESENTACION que el alta no fue realizada
        }
    }
}
