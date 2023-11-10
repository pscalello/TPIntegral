using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class VentaN
    {
        //**************************************** 
        //         CONSULTA VENTAS              //
        //*****************************************

        //public List<dynamic> listarVentas()
        //{
            //return VentaD.ConsultarClientes();
        //}

        //*************************************
        //        ELIMINACION DE VENTAS      //
        //************************************

        public bool EliminarVenta(Guid idVenta)
        {
            Guid idUsuarioAdmin = Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969");
            try
            {
                VentaD.DevolverVenta(idVenta, idUsuarioAdmin);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //*************************************
        //        CREACION DE VENTAS         //  
        //************************************

        public bool AgregarVenta(Guid idCliente, Guid idUsuario, Guid idProducto, int cantidad)
        {
            // Guid idUsuarioAdmin = Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969");
            PayloadAgregarVenta payloadAgregarVenta = new PayloadAgregarVenta(idCliente, idUsuario, idProducto, cantidad);
            try
            {
                VentaD.CrearVenta(payloadAgregarVenta);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
