using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Capa_Modelo
{
    public class CM_consultaPedidos
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);
        SqlConnection Conexion { get => conexion; set => conexion = value; }

        public CM_consultaPedidos()
        {
        }

        public SqlDataReader retornaEmpleados()
        {
            try
            {
                conexion.Close();
                SqlDataReader dr = null;
                SqlCommand cmd = new SqlCommand("USP_ListarEmpleado02", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                dr = cmd.ExecuteReader();
                return dr;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

            }
        }

        public SqlDataReader retornaPedidosEmpleado(int vId)
        {
            try
            {
                conexion.Close();
                SqlDataReader dr = null;
                SqlCommand cmd = new SqlCommand("USP_PedidosEmpleado", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmp", vId);
                conexion.Open();
                dr = cmd.ExecuteReader();
                return dr;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
