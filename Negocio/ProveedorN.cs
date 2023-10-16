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



    }
}
