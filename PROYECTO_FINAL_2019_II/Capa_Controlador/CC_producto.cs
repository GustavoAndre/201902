using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Modelo;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Controlador
{
    public class CC_producto
    {
        CM_producto objProCD = new CM_producto();

        
        public DataTable ListarProductos(int vId)
        {
            SqlParameter[] parParametros = new SqlParameter[1];
            parParametros[0] = new SqlParameter();
            parParametros[0].ParameterName = "@idProducto";
            parParametros[0].SqlDbType = SqlDbType.Int;
            parParametros[0].Value = vId;
            //
            DataTable dtt = objProCD.ListarProductos(parParametros, "USP_listarProducto");
            return dtt;
        }
        public int GuardarProducto( Producto objProducto)
        {

            int idProducto = 0;

            try
            {
                SqlParameter[] parParametros = new SqlParameter[14];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@idPro";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objProducto.IdProducto;
                parParametros[0].Direction = ParameterDirection.Output;


                parParametros[1] = new SqlParameter();
                parParametros[1].ParameterName = "@nomPro";
                parParametros[1].SqlDbType = SqlDbType.NVarChar;
                parParametros[1].Size = 50;
                parParametros[1].SqlValue = objProducto.NombreProducto;

                parParametros[2] = new SqlParameter();
                parParametros[2].ParameterName = "@desPro";
                parParametros[2].SqlDbType = SqlDbType.NVarChar;
                parParametros[2].Size = 50;
                parParametros[2].SqlValue = objProducto.DescripcionProducto;

                parParametros[3] = new SqlParameter();
                parParametros[3].ParameterName = "@idCat";
                parParametros[3].SqlDbType = SqlDbType.Int;
                parParametros[3].SqlValue = objProducto.IdCategoria;

                parParametros[4] = new SqlParameter();
                parParametros[4].ParameterName = "@canxUniPro";
                parParametros[4].SqlDbType = SqlDbType.NVarChar;
                parParametros[4].Size = 50;
                parParametros[4].SqlValue = objProducto.CantidadxUnidad;

                parParametros[5] = new SqlParameter();
                parParametros[5].ParameterName = "@preComPro";
                parParametros[5].SqlDbType = SqlDbType.Decimal;
                parParametros[5].SqlValue = objProducto.PrecioCompra;

                parParametros[6] = new SqlParameter();
                parParametros[6].ParameterName = "@fecRegPro";
                parParametros[6].SqlDbType = SqlDbType.DateTime;
                parParametros[6].SqlValue = objProducto.FechaDeRegistro;

                parParametros[7] = new SqlParameter();
                parParametros[7].ParameterName = "@stoPro";
                parParametros[7].SqlDbType = SqlDbType.Int;
                parParametros[7].SqlValue = objProducto.StockProducto;

                parParametros[8] = new SqlParameter();
                parParametros[8].ParameterName = "@stoMinPro";
                parParametros[8].SqlDbType = SqlDbType.Int;
                parParametros[8].SqlValue = objProducto.StockMinProducto;

                parParametros[9] = new SqlParameter();
                parParametros[9].ParameterName = "@stoMaxPro";
                parParametros[9].SqlDbType = SqlDbType.Int;
                parParametros[9].SqlValue = objProducto.StockMaxProducto;

                parParametros[10] = new SqlParameter();
                parParametros[10].ParameterName = "@idUni";
                parParametros[10].SqlDbType = SqlDbType.Int;
                parParametros[10].SqlValue = objProducto.IdUni;

                parParametros[11] = new SqlParameter();
                parParametros[11].ParameterName = "@idMer";
                parParametros[11].SqlDbType = SqlDbType.Int;
                parParametros[11].SqlValue = objProducto.IdMer;

                parParametros[12] = new SqlParameter();
                parParametros[12].ParameterName = "@activo";
                parParametros[12].SqlDbType = SqlDbType.Bit;
                parParametros[12].SqlValue = objProducto.Activo;

                parParametros[13] = new SqlParameter();
                parParametros[13].ParameterName = "@idAlm";
                parParametros[13].SqlDbType = SqlDbType.Int;
                parParametros[13].SqlValue = objProducto.IdAlm;

                idProducto = objProCD.AgregarProducto(parParametros, "USP_AgregarProducto");


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return idProducto;
        }

        public void actualizarProducto(Producto objProducto)
        {

            try
            {
                SqlParameter[] parParametros = new SqlParameter[14];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@idPro";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objProducto.IdProducto;


                parParametros[1] = new SqlParameter();
                parParametros[1].ParameterName = "@nomPro";
                parParametros[1].SqlDbType = SqlDbType.NVarChar;
                parParametros[1].Size = 50;
                parParametros[1].SqlValue = objProducto.NombreProducto;

                parParametros[2] = new SqlParameter();
                parParametros[2].ParameterName = "@desPro";
                parParametros[2].SqlDbType = SqlDbType.NVarChar;
                parParametros[2].Size = 50;
                parParametros[2].SqlValue = objProducto.DescripcionProducto;

                parParametros[3] = new SqlParameter();
                parParametros[3].ParameterName = "@idCat";
                parParametros[3].SqlDbType = SqlDbType.Int;
                parParametros[3].SqlValue = objProducto.IdCategoria;

                parParametros[4] = new SqlParameter();
                parParametros[4].ParameterName = "@canxUniPro";
                parParametros[4].SqlDbType = SqlDbType.NVarChar;
                parParametros[4].Size = 50;
                parParametros[4].SqlValue = objProducto.CantidadxUnidad;

                parParametros[5] = new SqlParameter();
                parParametros[5].ParameterName = "@preComPro";
                parParametros[5].SqlDbType = SqlDbType.Decimal;
                parParametros[5].SqlValue = objProducto.PrecioCompra;

                parParametros[6] = new SqlParameter();
                parParametros[6].ParameterName = "@fecRegPro";
                parParametros[6].SqlDbType = SqlDbType.DateTime;
                parParametros[6].SqlValue = objProducto.FechaDeRegistro;

                parParametros[7] = new SqlParameter();
                parParametros[7].ParameterName = "@stoPro";
                parParametros[7].SqlDbType = SqlDbType.Int;
                parParametros[7].SqlValue = objProducto.StockProducto;

                parParametros[8] = new SqlParameter();
                parParametros[8].ParameterName = "@stoMinPro";
                parParametros[8].SqlDbType = SqlDbType.Int;
                parParametros[8].SqlValue = objProducto.StockMinProducto;

                parParametros[9] = new SqlParameter();
                parParametros[9].ParameterName = "@stoMaxPro";
                parParametros[9].SqlDbType = SqlDbType.Int;
                parParametros[9].SqlValue = objProducto.StockMaxProducto;

                parParametros[10] = new SqlParameter();
                parParametros[10].ParameterName = "@idUni";
                parParametros[10].SqlDbType = SqlDbType.Int;
                parParametros[10].SqlValue = objProducto.IdUni;

                parParametros[11] = new SqlParameter();
                parParametros[11].ParameterName = "@idMer";
                parParametros[11].SqlDbType = SqlDbType.Int;
                parParametros[11].SqlValue = objProducto.IdMer;

                parParametros[12] = new SqlParameter();
                parParametros[12].ParameterName = "@activo";
                parParametros[12].SqlDbType = SqlDbType.Bit;
                parParametros[12].SqlValue = objProducto.Activo;

                parParametros[13] = new SqlParameter();
                parParametros[13].ParameterName = "@idAlm";
                parParametros[13].SqlDbType = SqlDbType.Int;
                parParametros[13].SqlValue = objProducto.IdAlm;

                objProCD.ModificarEliminar_Producto(parParametros, "USP_ActualizarProducto");


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void eliminarProducto(Producto objProducto)
        {


            try
            {
                SqlParameter[] parParametros = new SqlParameter[1];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@idProd";
                parParametros[0].SqlDbType = SqlDbType.Int;
                parParametros[0].SqlValue = objProducto.IdProducto;

                objProCD.ModificarEliminar_Producto(parParametros, "USP_EliminarProducto");


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public DataTable ConsultaProdxCat(int IdCat)
        {
            SqlParameter[] parParametros = new SqlParameter[1];
            parParametros[0] = new SqlParameter();
            parParametros[0].ParameterName = "@idCat";
            parParametros[0].SqlDbType = SqlDbType.Int;
            parParametros[0].Value = IdCat;
            //
            DataTable dtt = objProCD.ListarProductos(parParametros, "USP_ListarProductoxCategoria");
            return dtt;

        }
    }
}
