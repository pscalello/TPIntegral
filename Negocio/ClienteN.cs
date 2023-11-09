using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteN
    {

        //**************************************** 
        //        CONSULTA CLIENTES              //
        //*****************************************

        public List<RespuestaConsultaCliente> listaClientes()
        {
            return ClienteD.ConsultarClientes();
        }

        //*************************************
        //        ELIMINACION DE CLIENTES   //                                                   //
        //************************************

        public bool EliminarClientes(Guid idClienteABorrar)
        {
           // Guid idUsuarioAdmin = Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969");
            try
            {
                ClienteD.BorrarCliente(idClienteABorrar);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //*************************************
        //        CREACION DE CLIENTES   //                                                   //
        //************************************

        public bool AgregarCliente(string nombre, string apellido, int dni, string domicilio, string telefono, string email, DateTime fechaNacimiento)
        {
            Guid idUsuarioAdmin = Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969");
            PayloadAgregarCliente payloadAgregarCliente = new PayloadAgregarCliente(idUsuarioAdmin, nombre,apellido, dni, domicilio, telefono, email, fechaNacimiento);
            try
            {
                ClienteD.CrearCliente(payloadAgregarCliente);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
