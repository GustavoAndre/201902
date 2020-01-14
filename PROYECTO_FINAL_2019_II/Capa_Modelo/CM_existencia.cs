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
    public class CM_existencia
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);
        DataTable dt = null;
        SqlCommand cmd = null;
        SqlDataAdapter dap = null;

        public DataTable ListarExistencia(SqlParameter[] parparametros, String nomSP)
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);
            try
            {

                //Instanciar Objetos
                dt = new DataTable();

                cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nomSP;
                cmd.Parameters.AddRange(parparametros);
                dap = new SqlDataAdapter(cmd);
                dap.Fill(dt);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.Dispose();
                cmd.Dispose();
            }
            return dt;
        }
    }
}
