using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidad;

namespace Capa_Modelo
{
    public class CM_validarUsuario
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);

        DataSet ds = null;
        SqlDataAdapter dap = null;

        public DataTable validarUsuario(Usuario obj)
        {
            using (SqlCommand cmd = new SqlCommand("USP_ValidarUsuario", conexion))
            {
                DataTable tbl = new DataTable();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nom", obj.usuario);
                cmd.Parameters.AddWithValue("@con", obj.contraseña);
                
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tbl);
                    if (tbl.Rows.Count == 0)
                    {
                        return null;
                    }
                    else
                    {
                        return tbl;
                    }
                }
            }
        }
        public DataSet RetornarTablitas()
        {
            try
            {
                //Instanciar Objetos
                ds = new DataSet();
                dap = new SqlDataAdapter("USP_ListarDistrito", conexion);
                dap.Fill(ds, "TablaDistrito");
                dap.SelectCommand.CommandText = "USP_ListarCargo";
                dap.Fill(ds, "TablaCargo");
                dap.SelectCommand.CommandText = "USP_ListarArea";
                dap.Fill(ds, "TablaArea");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                //conex.Dispose();
                //cmd.Dispose();
            }
            return ds;
        }


    }
}
