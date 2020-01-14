using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Modelo;
using Capa_Entidad;

namespace Capa_Controlador
{
    public class CC_area
    {
        CM_area objAreaCM = new CM_area();
        public DataTable ListarArea(int idArea)
        {
            SqlParameter[] parParametros = new SqlParameter[1];
            parParametros[0] = new SqlParameter();
            parParametros[0].ParameterName = "@idArea";
            parParametros[0].SqlDbType = SqlDbType.Int;
            parParametros[0].Value = idArea;
            //
            DataTable dtt = objAreaCM.listarArea(parParametros, "USP_ListarArea");
            return dtt;
        }
        public int GuardarArea(Area objArea)
        {
            int IdArea = 0;
            try
            {
                SqlParameter[] parParametros = new SqlParameter[3];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@idArea";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objArea.IdArea;
                parParametros[0].Direction = ParameterDirection.Output;


                parParametros[1] = new SqlParameter();
                parParametros[1].ParameterName = "@nomArea";
                parParametros[1].SqlDbType = SqlDbType.VarChar;
                parParametros[1].Size = 50;
                parParametros[1].SqlValue = objArea.NomArea;

                parParametros[2] = new SqlParameter();
                parParametros[2].ParameterName = "@activo";
                parParametros[2].SqlDbType = SqlDbType.Bit;
                parParametros[2].SqlValue = objArea.Activo;

                

                /*idProducto = */
                IdArea = objAreaCM.agregarArea(parParametros, "USP_AgregarArea");


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return IdArea;
        }
        public void  ActualizarArea(Area objArea)
        {
            
            try
            {
                SqlParameter[] parParametros = new SqlParameter[3];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@idAre";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objArea.IdArea;
                


                parParametros[1] = new SqlParameter();
                parParametros[1].ParameterName = "@nomArea";
                parParametros[1].SqlDbType = SqlDbType.VarChar;
                parParametros[1].Size = 50;
                parParametros[1].SqlValue = objArea.NomArea;

                parParametros[2] = new SqlParameter();
                parParametros[2].ParameterName = "@activo";
                parParametros[2].SqlDbType = SqlDbType.Bit;
                parParametros[2].SqlValue = objArea.Activo;

                objAreaCM.modificarEliminar_Area(parParametros, "USP_ActualizarArea");


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void EliminarArea(Area objArea)
        {
            
            try
            {
                SqlParameter[] parParametros = new SqlParameter[1];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@idAre";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objArea.IdArea;


                objAreaCM.modificarEliminar_Area(parParametros, "USP_EliminarArea");


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
