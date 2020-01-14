using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Controlador
{
    public class CC_consultaPedidos
    {
        CM_consultaPedidos objConPedCM = new CM_consultaPedidos();
        public SqlDataReader ListarEmpleados()
        {
            try
            {
                return objConPedCM.retornaEmpleados();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public SqlDataReader PedidosEmpleado(int vId)
        {
            try
            {
                return objConPedCM.retornaPedidosEmpleado(vId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
