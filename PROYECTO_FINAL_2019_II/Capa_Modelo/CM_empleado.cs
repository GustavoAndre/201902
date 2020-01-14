using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Capa_Entidad;

namespace Capa_Modelo
{
    public class CM_empleado
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);
        SqlConnection Conexion { get => conexion; set => conexion = value; }
        DataTable dt = null;
        SqlCommand cmd = null;
        SqlDataAdapter dap = null;
        
        public DataTable ListarEmpleado(SqlParameter[] parparametros, String nomSP)
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
        public int  agregarEmpleado(SqlParameter[] parParametros, String spNombre)
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
        public void modificarEliminar_Empleado(SqlParameter[] parParametros, String spNombre)
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
        public SqlDataReader BuscarEmpleado(String NombreEmpleado)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString);
                SqlCommand cmd = new SqlCommand("USP_BuscarEmpleado", conexion);
                SqlDataReader drd;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@nomEmpleado", SqlDbType.VarChar, 50)).Value = NombreEmpleado;

                conexion.Open();
                drd = cmd.ExecuteReader();

                return drd;
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public SqlDataReader RetornaArea()
        {
            try
            {
                conexion.Close();
                SqlDataReader dr = null;
                SqlCommand cmd = new SqlCommand("USP_ListarArea", conexion);
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

        public SqlDataReader EmpleadoxArea(int vId)
        {
            try
            {
                conexion.Close();
                SqlDataReader dr = null;
                SqlCommand cmd = new SqlCommand("USP_EmpleadoxArea", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdArea", vId);
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
