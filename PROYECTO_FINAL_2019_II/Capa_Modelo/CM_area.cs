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
    public class CM_area
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);
        DataTable dt = null;
        SqlCommand cmd = null;
        SqlDataAdapter dap = null;

        public DataTable listarArea(SqlParameter[] parparametros, String nomSP)
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
        public int agregarArea(SqlParameter[] parParametros, String spNombre)
        {

            try
            {
                //Instanciar Objetos
                cmd = new SqlCommand();
                cmd.Connection = conexion;
                conexion.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = spNombre;
                cmd.Parameters.AddRange(parParametros);
                //Ejecutar el sp mediante cmd
                cmd.ExecuteNonQuery();
                return (int)cmd.Parameters[0].Value;
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
        }
        public void modificarEliminar_Area(SqlParameter[] parParametros, String spNombre)
        {
            try
            {
                //Instanciar Objetos
                cmd = new SqlCommand();
                cmd.Connection = conexion;
                conexion.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = spNombre;
                cmd.Parameters.AddRange(parParametros);
                //Ejecutar el sp mediante cmd
                cmd.ExecuteNonQuery();

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
        }
    }
}
