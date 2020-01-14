using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace Capa_Modelo
{
    public class CM_consultaDetallePedido
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);
        public SqlConnection Conexion { get => conexion; set => conexion = value; }

        public CM_consultaDetallePedido()
        {
        }

        public DataTable retornarPedidos()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter("USP_ListarPedidos", Conexion);
                dap.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public DataTable retornarDetallePedidos()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter("USP_ListarDetallePedido", Conexion);
                dap.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
