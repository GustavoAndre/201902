using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Modelo
{
    public class CM_producto
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);

        public CM_producto()
        {
        }

        //DECLARACION DE VARIABLES
        SqlCommand cmd = null;
        SqlDataAdapter dap = null;
        DataTable dt = null;

        public DataTable ListarProductos(SqlParameter[] parparametros, String nomSP)
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

        public int AgregarProducto(SqlParameter[] parParametros, String spNombre)
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

        public void ModificarEliminar_Producto(SqlParameter[] parParametros, String spNombre)
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
