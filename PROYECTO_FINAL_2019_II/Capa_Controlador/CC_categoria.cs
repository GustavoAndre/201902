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
    public class CC_categoria
    {
        Categoria objCat = new Categoria();
        CM_categoria objCatCM = new CM_categoria();


        public DataTable ListarCategorias(int IdCat)
        {
            SqlParameter[] parParametros = new SqlParameter[1];
            parParametros[0] = new SqlParameter();
            parParametros[0].ParameterName = "@IdCat";
            parParametros[0].SqlDbType = SqlDbType.Int;
            parParametros[0].Value = IdCat;
            //
            DataTable dtt = objCatCM.ListarCategorias(parParametros, "USP_ListarCategoria");
            return dtt;
        }

        public int guardarCategoria(Categoria objCat)
        {

            int idCat = 0;

            try
            {
                SqlParameter[] parParametros = new SqlParameter[4];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@idCat";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objCat.IdCat;
                parParametros[0].Direction = ParameterDirection.Output;
                

                parParametros[1] = new SqlParameter();
                parParametros[1].ParameterName = "@nomCat";
                parParametros[1].SqlDbType = SqlDbType.NVarChar;
                parParametros[1].Size = 50;
                parParametros[1].SqlValue = objCat.NomCat;

                parParametros[2] = new SqlParameter();
                parParametros[2].ParameterName = "@desCat";
                parParametros[2].SqlDbType = SqlDbType.NVarChar;
                parParametros[2].Size = 50;
                parParametros[2].SqlValue = objCat.DesCat;

                parParametros[3] = new SqlParameter();
                parParametros[3].ParameterName = "@activo";
                parParametros[3].SqlDbType = SqlDbType.Bit;
                parParametros[3].SqlValue = objCat.Activo;

                
                 idCat= objCatCM.agregarCategoria(parParametros, "USP_AgregarCategoria");


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return idCat;
        }

        public void actualizarCategoria(Categoria objCat)
        {

            try
            {
                SqlParameter[] parParametros = new SqlParameter[4];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@idCat";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objCat.IdCat;

                parParametros[1] = new SqlParameter();
                parParametros[1].ParameterName = "@nomCat";
                parParametros[1].SqlDbType = SqlDbType.NVarChar;
                parParametros[1].Size = 50;
                parParametros[1].SqlValue = objCat.NomCat;

                parParametros[2] = new SqlParameter();
                parParametros[2].ParameterName = "@desCat";
                parParametros[2].SqlDbType = SqlDbType.NVarChar;
                parParametros[2].Size = 50;
                parParametros[2].SqlValue = objCat.DesCat;

                parParametros[3] = new SqlParameter();
                parParametros[3].ParameterName = "@activo";
                parParametros[3].SqlDbType = SqlDbType.Bit;
                parParametros[3].SqlValue = objCat.Activo;

                objCatCM.modificarEliminar_Categoria(parParametros, "USP_ActualizarCategoria");


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void eliminarCategoria(Categoria objCat)
        {

            try
            {
                SqlParameter[] parParametros = new SqlParameter[1];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@idCat";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objCat.IdCat;
 
                objCatCM.modificarEliminar_Categoria(parParametros, "USP_EliminarCategoria");


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
