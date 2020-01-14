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
    public class CM_almacen
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);

        DataTable dt = null;
        SqlCommand cmd = null;
        SqlDataAdapter dap = null;
        public DataTable ListarAlmacen(SqlParameter[] parameters, string nomSP)
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);
            try
            {
                dt = new DataTable();
                cmd = new SqlCommand(nomSP, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters);

                dap = new SqlDataAdapter(cmd);
                dap.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }
        public int AgregarAlmacen(SqlParameter[] parParametros, String spNombre)
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
        public void ModificarEliminar_Almacen(SqlParameter[] parParametros, String spNombre)
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
