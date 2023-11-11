using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class VentaN
    {
        //**************************************** 
        //          CONSULTA VENTAS              //
        //*****************************************

        public List<RespuestaConsultaVenta> listarVentas()
        {
            try
            {
                ClienteN clienteN = new ClienteN();

                // busca todos los clientes
                List<RespuestaConsultaCliente> listaClientes = clienteN.listaClientes();
                List<RespuestaConsultaVenta> listaVentas = new List<RespuestaConsultaVenta>();

                // busca todas las ventas de todos los clientes
                foreach (RespuestaConsultaCliente cliente in listaClientes)
                {
                    List<RespuestaConsultaVenta> respuestaConsulta = VentaD.ConsultarVentasPorCliente(cliente.id);
                    respuestaConsulta.ForEach((venta) => {
                        venta.cliente = cliente.nombre + " " + cliente.apellido;
                        // a cada venta la agrega a la lista de ventas
                        listaVentas.Add(venta);
                    }
                    );
                }

                // devuelve la lista de todas las ventas
                return listaVentas;
            }
            catch
            {
                throw new Exception("Error al cargar las ventas.");
            }
        }

        //*************************************
        //        ELIMINACION DE VENTAS      //
        //************************************

        public bool EliminarVenta(Guid idVenta, Guid idUsuario)
        {
            try
            {
                VentaD.DevolverVenta(idVenta, idUsuario);
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
