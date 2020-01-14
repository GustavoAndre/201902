using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidad;

namespace Capa_Controlador
{
    public class CC_distrito
    {
        CM_distrito objDisCM = new CM_distrito();


        public DataTable ListarDistrito(int vId)
        {
            SqlParameter[] parParametros = new SqlParameter[1];
            parParametros[0] = new SqlParameter();
            parParametros[0].ParameterName = "@idDis";
            parParametros[0].SqlDbType = SqlDbType.Int;
            parParametros[0].Value = vId;
            
            DataTable dtt = objDisCM.ListarDistrito(parParametros, "USP_ListarDistrito");
            return dtt;
        }
        public int GuardarDistrito(Distrito objDis)
        {
            int idDis = 0;
            try
            {
                SqlParameter[] parparameters = new SqlParameter[4];
                parparameters[0] = new SqlParameter();
                parparameters[0].ParameterName = "@idDis";
                parparameters[0].SqlDbType = SqlDbType.Int;
                parparameters[0].Value = objDis.IdDis;
                parparameters[0].Direction = ParameterDirection.Output;

                parparameters[1] = new SqlParameter();
                parparameters[1].ParameterName = "@nomDis";
                parparameters[1].SqlDbType = SqlDbType.VarChar;
                parparameters[1].Size = 100;
                parparameters[1].Value = objDis.NomDis;

                parparameters[2] = new SqlParameter();
                parparameters[2].ParameterName = "@conDis";
                parparameters[2].SqlDbType = SqlDbType.VarChar;
                parparameters[2].Size = 50;
                parparameters[2].Value = objDis.ConDis;

                parparameters[3] = new SqlParameter();
                parparameters[3].ParameterName = "@activo";
                parparameters[3].SqlDbType = SqlDbType.Bit;
                parparameters[3].Value = objDis.Activo;

                idDis = objDisCM.agregarDistrito(parparameters, "USP_AgregarDistrito");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return idDis;
        }
        public void ActualizarDistrito(Distrito objDis)
        {
            
            try
            {
                SqlParameter[] parparameters = new SqlParameter[4];
                parparameters[0] = new SqlParameter();
                parparameters[0].ParameterName = "@idDis";
                parparameters[0].SqlDbType = SqlDbType.Int;
                parparameters[0].Value = objDis.IdDis;

                parparameters[1] = new SqlParameter();
                parparameters[1].ParameterName = "@nomDis";
                parparameters[1].SqlDbType = SqlDbType.VarChar;
                parparameters[1].Size = 100;
                parparameters[1].Value = objDis.NomDis;

                parparameters[2] = new SqlParameter();
                parparameters[2].ParameterName = "@conDis";
                parparameters[2].SqlDbType = SqlDbType.VarChar;
                parparameters[2].Size = 50;
                parparameters[2].Value = objDis.ConDis;

                parparameters[3] = new SqlParameter();
                parparameters[3].ParameterName = "@activo";
                parparameters[3].SqlDbType = SqlDbType.Bit;
                parparameters[3].Value = objDis.Activo;

                 objDisCM.modificarEliminar_Distrito(parparameters, "USP_ActualizarDistrito");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void EliminarDistrito(Distrito objDis)
        {

            try
            {
                SqlParameter[] parparameters = new SqlParameter[1];
                parparameters[0] = new SqlParameter();
                parparameters[0].ParameterName = "@idDis";
                parparameters[0].SqlDbType = SqlDbType.Int;
                parparameters[0].Value = objDis.IdDis;


                objDisCM.modificarEliminar_Distrito(parparameters, "USP_EliminarDistrito");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
