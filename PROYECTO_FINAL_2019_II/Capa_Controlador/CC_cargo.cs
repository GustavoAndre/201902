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
    public class CC_cargo
    {
        CM_cargo objCargoCM = new CM_cargo();

        public DataTable ListarCargo(int idCar)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter();
            parameters[0].ParameterName = "IdCar";
            parameters[0].SqlDbType = SqlDbType.Int;
            parameters[0].Value = idCar;

            DataTable dt = objCargoCM.ListarCargo(parameters,"USP_ListarCargo");
            return dt;
        }

        public int GuardarCargo(Cargo objCar)
        {
            int idCar = 0;
             try
            {
                SqlParameter[] parparameters = new SqlParameter[4];
                parparameters[0] = new SqlParameter();
                parparameters[0].ParameterName = "@idCar";
                parparameters[0].SqlDbType = SqlDbType.Int;
                parparameters[0].SqlValue = objCar.IdCar;
                parparameters[0].Direction = ParameterDirection.Output;

                parparameters[1] = new SqlParameter();
                parparameters[1].ParameterName = "@nomCar";
                parparameters[1].SqlDbType = SqlDbType.VarChar;
                parparameters[1].Size = 150;
                parparameters[1].SqlValue = objCar.NomCar;

                parparameters[2] = new SqlParameter();
                parparameters[2].ParameterName = "@desCar";
                parparameters[2].SqlDbType = SqlDbType.VarChar;
                parparameters[2].Size = 200;
                parparameters[2].SqlValue = objCar.DesCar;

                parparameters[3] = new SqlParameter();
                parparameters[3].ParameterName = "@activo";
                parparameters[3].SqlDbType = SqlDbType.Bit;
                parparameters[3].SqlValue = objCar.Activo;


                idCar = objCargoCM.agregarCargo(parparameters, "USP_AgregarCargo");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return idCar;
        }

        public void ActualizarCargo(Cargo objCar)
        {
            try
            {
                SqlParameter[] parparameters = new SqlParameter[4];
                parparameters[0] = new SqlParameter();
                parparameters[0].ParameterName = "@idCar";
                parparameters[0].SqlDbType = SqlDbType.Int;
                parparameters[0].SqlValue = objCar.IdCar;
                

                parparameters[1] = new SqlParameter();
                parparameters[1].ParameterName = "@nomCar";
                parparameters[1].SqlDbType = SqlDbType.VarChar;
                parparameters[1].Size = 150;
                parparameters[1].SqlValue = objCar.NomCar;

                parparameters[2] = new SqlParameter();
                parparameters[2].ParameterName = "@desCar";
                parparameters[2].SqlDbType = SqlDbType.VarChar;
                parparameters[2].Size = 200;
                parparameters[2].SqlValue = objCar.DesCar;

                parparameters[3] = new SqlParameter();
                parparameters[3].ParameterName = "@activo";
                parparameters[3].SqlDbType = SqlDbType.Bit;
                parparameters[3].SqlValue = objCar.Activo;


                objCargoCM.modificarEliminar_Cargo(parparameters, "USP_ActualizarCargo");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void EliminarCargo(Cargo objCar)
        {
            try
            {
                SqlParameter[] parparameters = new SqlParameter[1];
                parparameters[0] = new SqlParameter();
                parparameters[0].ParameterName = "@idCar";
                parparameters[0].SqlDbType = SqlDbType.Int;
                parparameters[0].SqlValue = objCar.IdCar;


                objCargoCM.modificarEliminar_Cargo(parparameters, "USP_EliminarCargo");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
