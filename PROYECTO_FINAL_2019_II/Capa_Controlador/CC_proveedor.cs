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
    public class CC_proveedor
    {
        CM_proveedor objprovCM = new CM_proveedor();
        public DataTable ListarProveedor(int Idprov)
        {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter();
                parameters[0].ParameterName = "@IdProv";
                parameters[0].SqlDbType = SqlDbType.Int;
                parameters[0].Value = Idprov;

                DataTable dt = objprovCM.ListarProveedor(parameters, "USP_listarProveedor");
                return dt;
        }

        public int AgregarProveedor(Proveedor objProv)
        {
            int idProv = 0;
            try
            {
                SqlParameter[] parparameters = new SqlParameter[13];
                parparameters[0] = new SqlParameter();
                parparameters[0].ParameterName = "@idProv";
                parparameters[0].SqlDbType = SqlDbType.Int;
                parparameters[0].SqlValue = objProv.IdPro;
                parparameters[0].Direction = ParameterDirection.Output;

                parparameters[1] = new SqlParameter();
                parparameters[1].ParameterName = "@rucCom";
                parparameters[1].SqlDbType = SqlDbType.Int;
                parparameters[1].SqlValue = objProv.RucCom;

                parparameters[2] = new SqlParameter();
                parparameters[2].ParameterName = "@nomCom";
                parparameters[2].SqlDbType = SqlDbType.VarChar;
                parparameters[2].Size = 200;
                parparameters[2].SqlValue = objProv.NomCom;

                parparameters[3] = new SqlParameter();
                parparameters[3].ParameterName = "@nomCon";
                parparameters[3].SqlDbType = SqlDbType.VarChar;
                parparameters[3].Size = 200;
                parparameters[3].SqlValue = objProv.NomCon;

                parparameters[4] = new SqlParameter();
                parparameters[4].ParameterName = "@apePatCon";
                parparameters[4].SqlDbType = SqlDbType.VarChar;
                parparameters[4].Size =50;
                parparameters[4].SqlValue = objProv.ApePatCon;

                parparameters[5] = new SqlParameter();
                parparameters[5].ParameterName = "@apeMatCon";
                parparameters[5].SqlDbType = SqlDbType.VarChar;
                parparameters[5].Size = 50;
                parparameters[5].SqlValue = objProv.ApeMatCon;

                parparameters[6] = new SqlParameter();
                parparameters[6].ParameterName = "@carCon";
                parparameters[6].SqlDbType = SqlDbType.VarChar;
                parparameters[6].Size = 100;
                parparameters[6].SqlValue = objProv.CarCon;

                parparameters[7] = new SqlParameter();
                parparameters[7].ParameterName = "@dirPro";
                parparameters[7].SqlDbType = SqlDbType.VarChar;
                parparameters[7].Size = 500;
                parparameters[7].SqlValue = objProv.DirPro;

                parparameters[8] = new SqlParameter();
                parparameters[8].ParameterName = "@celPro";
                parparameters[8].SqlDbType = SqlDbType.Int;
                parparameters[8].SqlValue = objProv.CelPro;

                parparameters[9] = new SqlParameter();
                parparameters[9].ParameterName = "@corPro";
                parparameters[9].SqlDbType = SqlDbType.VarChar;
                parparameters[9].Size = 200;
                parparameters[9].SqlValue = objProv.CorPro;

                parparameters[10] = new SqlParameter();
                parparameters[10].ParameterName = "@fecRegPro";
                parparameters[10].SqlDbType = SqlDbType.Date;
                parparameters[10].SqlValue = objProv.FecRegPro;

                parparameters[11] = new SqlParameter();
                parparameters[11].ParameterName = "@codDis";
                parparameters[11].SqlDbType = SqlDbType.Int;
                parparameters[11].SqlValue = objProv.CodDis;
                
                parparameters[12] = new SqlParameter();
                parparameters[12].ParameterName = "@activo";
                parparameters[12].SqlDbType = SqlDbType.Bit;
                parparameters[12].SqlValue = objProv.Activo;

                idProv = objprovCM.agregarProveedor(parparameters, "USP_AgregarProveedor");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return idProv;
        }

        public void ActualizarProveedor(Proveedor objProv)
        {
            try
            {
                SqlParameter[] parparameters = new SqlParameter[13];
                parparameters[0] = new SqlParameter();
                parparameters[0].ParameterName = "@idPro";
                parparameters[0].SqlDbType = SqlDbType.Int;
                parparameters[0].SqlValue = objProv.IdPro;

                parparameters[1] = new SqlParameter();
                parparameters[1].ParameterName = "@rucCom";
                parparameters[1].SqlDbType = SqlDbType.Int;
                parparameters[1].SqlValue = objProv.RucCom;

                parparameters[2] = new SqlParameter();
                parparameters[2].ParameterName = "@nomCom";
                parparameters[2].SqlDbType = SqlDbType.VarChar;
                parparameters[2].Size = 200;
                parparameters[2].SqlValue = objProv.NomCom;

                parparameters[3] = new SqlParameter();
                parparameters[3].ParameterName = "@nomCon";
                parparameters[3].SqlDbType = SqlDbType.VarChar;
                parparameters[3].Size = 200;
                parparameters[3].SqlValue = objProv.NomCon;

                parparameters[4] = new SqlParameter();
                parparameters[4].ParameterName = "@apePatCon";
                parparameters[4].SqlDbType = SqlDbType.VarChar;
                parparameters[4].Size =50;
                parparameters[4].SqlValue = objProv.ApePatCon;

                parparameters[5] = new SqlParameter();
                parparameters[5].ParameterName = "@apeMatCon";
                parparameters[5].SqlDbType = SqlDbType.VarChar;
                parparameters[5].Size = 50;
                parparameters[5].SqlValue = objProv.ApeMatCon;

                parparameters[6] = new SqlParameter();
                parparameters[6].ParameterName = "@carCon";
                parparameters[6].SqlDbType = SqlDbType.VarChar;
                parparameters[6].Size = 100;
                parparameters[6].SqlValue = objProv.CarCon;

                parparameters[7] = new SqlParameter();
                parparameters[7].ParameterName = "@dirPro";
                parparameters[7].SqlDbType = SqlDbType.VarChar;
                parparameters[7].Size = 500;
                parparameters[7].SqlValue = objProv.DirPro;

                parparameters[8] = new SqlParameter();
                parparameters[8].ParameterName = "@celPro";
                parparameters[8].SqlDbType = SqlDbType.Int;
                parparameters[8].SqlValue = objProv.CelPro;

                parparameters[9] = new SqlParameter();
                parparameters[9].ParameterName = "@corPro";
                parparameters[9].SqlDbType = SqlDbType.VarChar;
                parparameters[9].Size = 200;
                parparameters[9].SqlValue = objProv.CorPro;

                parparameters[10] = new SqlParameter();
                parparameters[10].ParameterName = "@fecRegPro";
                parparameters[10].SqlDbType = SqlDbType.Date;
                parparameters[10].SqlValue = objProv.FecRegPro;

                parparameters[11] = new SqlParameter();
                parparameters[11].ParameterName = "@codDis";
                parparameters[11].SqlDbType = SqlDbType.Int;
                parparameters[11].SqlValue = objProv.CodDis;
                
                parparameters[12] = new SqlParameter();
                parparameters[12].ParameterName = "@activo";
                parparameters[12].SqlDbType = SqlDbType.Bit;
                parparameters[12].SqlValue = objProv.Activo;

                objprovCM.modificarEliminar_Proveedor(parparameters, "USP_ActualizarProveedor");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EliminarProveedor(Proveedor objProv)
        {
            try
            {
                SqlParameter[] parparameters = new SqlParameter[1];
                parparameters[0] = new SqlParameter();
                parparameters[0].ParameterName = "@idPro";
                parparameters[0].SqlDbType = SqlDbType.Int;
                parparameters[0].SqlValue = objProv.IdPro;

                objprovCM.modificarEliminar_Proveedor(parparameters, "USP_EliminarProveedor");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
