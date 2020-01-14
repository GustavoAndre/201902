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
    public class CC_Empleado
    {
        CM_empleado objEmpCM = new CM_empleado();

        public DataTable ListarEmpleado(int IdEmp)
        {
            SqlParameter[] parParametros = new SqlParameter[1];
            parParametros[0] = new SqlParameter();
            parParametros[0].ParameterName = "@IdEmp";
            parParametros[0].SqlDbType = SqlDbType.Int;
            parParametros[0].Value = IdEmp;
            
            DataTable dtt = objEmpCM.ListarEmpleado(parParametros, "USP_ListarEmpleado");
            return dtt;
        }

        public int guardarEmpleado(Empleado objEmp)
        {
            int IdEmp = 0;
            try
            {
                SqlParameter[] parParametros = new SqlParameter[15];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@idEmp";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objEmp.IdEmp;
                parParametros[0].Direction = ParameterDirection.Output;

                parParametros[1] = new SqlParameter();
                parParametros[1].ParameterName = "@apePatEmp";
                parParametros[1].SqlDbType = SqlDbType.NVarChar;
                parParametros[1].Size = 50;
                parParametros[1].SqlValue = objEmp.ApePatEmp;

                parParametros[2] = new SqlParameter();
                parParametros[2].ParameterName = "@apeMatEmp";
                parParametros[2].SqlDbType = SqlDbType.NVarChar;
                parParametros[2].Size = 50;
                parParametros[2].SqlValue = objEmp.ApeMatEmp;

                parParametros[3] = new SqlParameter();
                parParametros[3].ParameterName = "@nomEmp";
                parParametros[3].SqlDbType = SqlDbType.NVarChar;
                parParametros[3].Size = 50;
                parParametros[3].SqlValue = objEmp.NomEmp;

                parParametros[4] = new SqlParameter();
                parParametros[4].ParameterName = "@fecNacEmp";
                parParametros[4].SqlDbType = SqlDbType.DateTime;
                parParametros[4].SqlValue = objEmp.FecNacEmp;

                parParametros[5] = new SqlParameter();
                parParametros[5].ParameterName = "@fecIngEmp";
                parParametros[5].SqlDbType = SqlDbType.DateTime;
                parParametros[5].SqlValue = objEmp.FecIngEmp;

                parParametros[6] = new SqlParameter();
                parParametros[6].ParameterName = "@SexEmp";
                parParametros[6].SqlDbType = SqlDbType.Char;
                parParametros[6].Size = 1;
                parParametros[6].SqlValue = objEmp.SexEmp;

                parParametros[7] = new SqlParameter();
                parParametros[7].ParameterName = "@telEmp";
                parParametros[7].SqlDbType = SqlDbType.Int;
                parParametros[7].SqlValue = objEmp.TelEmp;

                parParametros[8] = new SqlParameter();
                parParametros[8].ParameterName = "@celEmp";
                parParametros[8].SqlDbType = SqlDbType.Int;

                parParametros[8].SqlValue = objEmp.CelEmp;

                parParametros[9] = new SqlParameter();
                parParametros[9].ParameterName = "@corEmp";
                parParametros[9].SqlDbType = SqlDbType.NVarChar;
                parParametros[9].Size = 50;
                parParametros[9].SqlValue = objEmp.CorEmp;

                parParametros[10] = new SqlParameter();
                parParametros[10].ParameterName = "@obsEmp";
                parParametros[10].SqlDbType = SqlDbType.NVarChar;
                parParametros[10].Size = 50;
                parParametros[10].SqlValue = objEmp.ObsEmp;

                parParametros[11] = new SqlParameter();
                parParametros[11].ParameterName = "@idDis";
                parParametros[11].SqlDbType = SqlDbType.Int;
                parParametros[11].SqlValue = objEmp.IdDis;

                parParametros[12] = new SqlParameter();
                parParametros[12].ParameterName = "@idCar";
                parParametros[12].SqlDbType = SqlDbType.Int;
                parParametros[12].SqlValue = objEmp.IdCar;

                parParametros[13] = new SqlParameter();
                parParametros[13].ParameterName = "@idAre";
                parParametros[13].SqlDbType = SqlDbType.Int;
                parParametros[13].SqlValue = objEmp.IdAre;

                parParametros[14] = new SqlParameter();
                parParametros[14].ParameterName = "@activo";
                parParametros[14].SqlDbType = SqlDbType.Bit;
                parParametros[14].SqlValue = objEmp.Activo;

                
                 IdEmp = objEmpCM.agregarEmpleado(parParametros, "USP_AgregarEmpleado");


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return IdEmp;
        }

        public void ActualizarEmpleado(Empleado objEmp)
        {
            try
            {
                SqlParameter[] parParametros = new SqlParameter[15];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@idEmp";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objEmp.IdEmp;
               

                parParametros[1] = new SqlParameter();
                parParametros[1].ParameterName = "@idCar";
                parParametros[1].SqlDbType = SqlDbType.Int;

                parParametros[1].SqlValue = objEmp.IdCar;

                parParametros[2] = new SqlParameter();
                parParametros[2].ParameterName = "@apePatEmp";
                parParametros[2].SqlDbType = SqlDbType.NVarChar;
                parParametros[2].Size = 50;
                parParametros[2].SqlValue = objEmp.ApePatEmp;

                parParametros[3] = new SqlParameter();
                parParametros[3].ParameterName = "@apeMatEmp";
                parParametros[3].SqlDbType = SqlDbType.NVarChar;
                parParametros[3].Size = 50;
                parParametros[3].SqlValue = objEmp.ApeMatEmp;

                parParametros[4] = new SqlParameter();
                parParametros[4].ParameterName = "@nomEmp";
                parParametros[4].SqlDbType = SqlDbType.NVarChar;
                parParametros[4].Size = 50;
                parParametros[4].SqlValue = objEmp.NomEmp;

                parParametros[5] = new SqlParameter();
                parParametros[5].ParameterName = "@fecNacEmp";
                parParametros[5].SqlDbType = SqlDbType.DateTime;
                parParametros[5].SqlValue = objEmp.FecNacEmp;

                parParametros[6] = new SqlParameter();
                parParametros[6].ParameterName = "@fecIngEmp";
                parParametros[6].SqlDbType = SqlDbType.DateTime;
                parParametros[6].SqlValue = objEmp.FecIngEmp;

                parParametros[7] = new SqlParameter();
                parParametros[7].ParameterName = "@idDis";
                parParametros[7].SqlDbType = SqlDbType.Int;
                parParametros[7].SqlValue = objEmp.IdDis;

                parParametros[8] = new SqlParameter();
                parParametros[8].ParameterName = "@telEmp";
                parParametros[8].SqlDbType = SqlDbType.Int;
                parParametros[8].SqlValue = objEmp.TelEmp;

                parParametros[9] = new SqlParameter();
                parParametros[9].ParameterName = "@celEmp";
                parParametros[9].SqlDbType = SqlDbType.Int;

                parParametros[9].SqlValue = objEmp.CelEmp;

                parParametros[10] = new SqlParameter();
                parParametros[10].ParameterName = "@corEmp";
                parParametros[10].SqlDbType = SqlDbType.NVarChar;
                parParametros[10].Size = 50;
                parParametros[10].SqlValue = objEmp.CorEmp;

                parParametros[11] = new SqlParameter();
                parParametros[11].ParameterName = "@obsEmp";
                parParametros[11].SqlDbType = SqlDbType.NVarChar;
                parParametros[11].Size = 50;
                parParametros[11].SqlValue = objEmp.ObsEmp;

                parParametros[12] = new SqlParameter();
                parParametros[12].ParameterName = "@activo";
                parParametros[12].SqlDbType = SqlDbType.Bit;
                parParametros[12].SqlValue = objEmp.Activo;

                parParametros[13] = new SqlParameter();
                parParametros[13].ParameterName = "@idAre";
                parParametros[13].SqlDbType = SqlDbType.Int;
                parParametros[13].SqlValue = objEmp.IdAre;

                parParametros[14] = new SqlParameter();
                parParametros[14].ParameterName = "@SexEmp";
                parParametros[14].SqlDbType = SqlDbType.Char;
                parParametros[14].Size = 1;
                parParametros[14].SqlValue = objEmp.SexEmp;


                objEmpCM.modificarEliminar_Empleado(parParametros, "USP_ActualizarEmpleado");


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public void EliminarEmpleado(Empleado objEmp)
        {
            try
            {
                SqlParameter[] parParametros = new SqlParameter[1];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@idEmp";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objEmp.IdEmp;
                
                objEmpCM.modificarEliminar_Empleado(parParametros, "USP_eliminarEmpleado");


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public SqlDataReader BuscarEmpleado(String vNombreEmpleado)
        {
            try
            {
                return objEmpCM.BuscarEmpleado(vNombreEmpleado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public SqlDataReader ListarAreas()
        {
            try
            {
                return objEmpCM.RetornaArea();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public SqlDataReader EmpleadosxArea(int vId)
        {
            try
            {
                return objEmpCM.EmpleadoxArea(vId); ;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
