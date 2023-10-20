using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProveedorN
    {



        //***************************************************************************************************************************** 
        //                                             CONSULTA PROVEEDORES                                                          //
        //*****************************************************************************************************************************

        public List<RespuestaConsultaProveedores> listaProveedores()
        {
            return ProveedorD.ConsultarProveedores();
        }

        //***************************************************************************************************************************** 
        //                                             ELIMINACION DE PROVEEDORES                                                        //
        //*****************************************************************************************************************************

        public bool EliminarProveedor(Guid idProveedorABorrar)
        {
            Guid idUsuarioAdmin = Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969");
            try
            {
                    ProveedorD.BorrarProveedor(idProveedorABorrar, idUsuarioAdmin);
                    return true;
            }
            catch (Exception ex)
            {
                    return false;
            }
        }

        public bool AgregarProveedor(string nombre, string apellido, string cuit, string email)
        {
            Guid idUsuarioAdmin = Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969");
            PayloadAgregarProveedor payloadAgregarProveedor = new PayloadAgregarProveedor(idUsuarioAdmin, nombre, apellido, email, cuit);
            try
            {
                ProveedorD.CrearProveedor(payloadAgregarProveedor);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
