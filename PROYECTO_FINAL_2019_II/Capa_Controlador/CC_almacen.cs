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
    public class CC_almacen
    {
        CM_almacen objAlmacenCM = new CM_almacen();
        public DataTable ListarAlmacen(int idAlmacen)
        {
            SqlParameter[] parParametros = new SqlParameter[1];
            parParametros[0] = new SqlParameter();
            parParametros[0].ParameterName = "@idAlm";
            parParametros[0].SqlDbType = SqlDbType.Int;
            parParametros[0].Value = idAlmacen;
            //
            DataTable dtt = objAlmacenCM.ListarAlmacen(parParametros, "USP_ListarAlmacen");
            return dtt;
        }
        public int GuardarAlmacen(Almacen objAlmacen)
        {
            int IdAlmacen = 0;
            try
            {
                SqlParameter[] parParametros = new SqlParameter[5];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@idAlm";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objAlmacen.IdAlm;
                parParametros[0].Direction = ParameterDirection.Output;


                parParametros[1] = new SqlParameter();
                parParametros[1].ParameterName = "@nomAlm";
                parParametros[1].SqlDbType = SqlDbType.VarChar;
                parParametros[1].Size = 50;
                parParametros[1].SqlValue = objAlmacen.NomAlm;

                parParametros[2] = new SqlParameter();
                parParametros[2].ParameterName = "@desAlm";
                parParametros[2].SqlDbType = SqlDbType.VarChar;
                parParametros[2].Size = 50;
                parParametros[2].SqlValue = objAlmacen.DesAlm;

                parParametros[3] = new SqlParameter();
                parParametros[3].ParameterName = "@ubiAlm";
                parParametros[3].SqlDbType = SqlDbType.VarChar;
                parParametros[3].Size = 50;
                parParametros[3].SqlValue = objAlmacen.UbiAlm;

                parParametros[4] = new SqlParameter();
                parParametros[4].ParameterName = "@activo";
                parParametros[4].SqlDbType = SqlDbType.Bit;
                parParametros[4].SqlValue = objAlmacen.Activo;

                IdAlmacen= objAlmacenCM.AgregarAlmacen(parParametros, "USP_AgregarAlmacen");


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return IdAlmacen;
        }
        public void ActualizarAlmacen(Almacen objAlmacen)
        {

            try
            {
                SqlParameter[] parParametros = new SqlParameter[5];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@idAlm";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objAlmacen.IdAlm;


                parParametros[1] = new SqlParameter();
                parParametros[1].ParameterName = "@nomAlm";
                parParametros[1].SqlDbType = SqlDbType.VarChar;
                parParametros[1].Size = 50;
                parParametros[1].SqlValue = objAlmacen.NomAlm;

                parParametros[2] = new SqlParameter();
                parParametros[2].ParameterName = "@desAlm";
                parParametros[2].SqlDbType = SqlDbType.VarChar;
                parParametros[2].Size = 50;
                parParametros[2].SqlValue = objAlmacen.DesAlm;

                parParametros[3] = new SqlParameter();
                parParametros[3].ParameterName = "@ubiAlm";
                parParametros[3].SqlDbType = SqlDbType.VarChar;
                parParametros[3].Size = 50;
                parParametros[3].SqlValue = objAlmacen.UbiAlm;

                parParametros[4] = new SqlParameter();
                parParametros[4].ParameterName = "@activo";
                parParametros[4].SqlDbType = SqlDbType.Bit;
                parParametros[4].SqlValue = objAlmacen.Activo;

                objAlmacenCM.ModificarEliminar_Almacen(parParametros, "USP_ActualizarAlmacen");


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void EliminarAlmacen(Almacen objAlmacen)
        {

            try
            {
                SqlParameter[] parParametros = new SqlParameter[1];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@idAlm";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objAlmacen.IdAlm;


                objAlmacenCM.ModificarEliminar_Almacen(parParametros, "USP_EliminarAlmacen");


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
