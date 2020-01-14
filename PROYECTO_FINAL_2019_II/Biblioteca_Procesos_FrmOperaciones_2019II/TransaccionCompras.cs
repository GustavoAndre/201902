using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca_Procesos_FrmOperaciones_2019II
{
    public class TransaccionCompras
    {
        private const String Conex = "Data Source=.;database=BD_PROYECTO_FINAL_2019II; Integrated Security=true;";
        public DataSet getListas()
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conex);
                SqlDataAdapter Dap = new SqlDataAdapter("USP_ListarEmpleado02", cn);
                DataSet Dst = new DataSet();
                //Llenar el dataset
                Dap.Fill(Dst, "tEmpleados");
                Dap.SelectCommand.CommandText = "USP_ListarProveedor02";
                Dap.Fill(Dst, "tProveedores");
                Dap.SelectCommand.CommandText = "USP_ListarProducto02";
                Dap.Fill(Dst, "tProductos");
                Dap.SelectCommand.CommandText = "USP_ListarTipoOperacion";
                Dap.Fill(Dst, "tTipoOperacion");
                Dap.SelectCommand.CommandText = "USP_ListarTipoDocumento";
                Dap.Fill(Dst, "tTipoDocumento");
                Dap.SelectCommand.CommandText = "USP_ListarTipoExistencia";
                Dap.Fill(Dst, "tTipoExistencia");
                Dap.SelectCommand.CommandText = "USP_ListarUnidadMedida";
                Dap.Fill(Dst, "tUnidadMedida");
                return Dst;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }// TRAEMOS LAS TABLAS PARA LLENAR LOS COMBOS

        public DataTable getProducto(int vIdPro)
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conex);
                SqlDataAdapter Dap = new SqlDataAdapter("USP_DatosProducto", cn);
                DataTable Dt = new DataTable();
                Dap.SelectCommand.CommandType = CommandType.StoredProcedure;
                Dap.SelectCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = vIdPro;
                Dap.Fill(Dt);
                return Dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int setPedido(int vIdProv, int vIdEmp, DateTime vFecha,int vIdDoc,int vIdOpe,Boolean vactivo)
        {
            try
            {

                SqlConnection cn = new SqlConnection(Conex);
                SqlCommand Cmd = new SqlCommand("USP_AdicionarPedido", cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@IdPed", SqlDbType.Int)).Direction = ParameterDirection.Output;
                Cmd.Parameters.Add(new SqlParameter("@IdProv", SqlDbType.Int)).Value = vIdProv;
                Cmd.Parameters.Add(new SqlParameter("@IdEmp", SqlDbType.Int)).Value = vIdEmp;
                Cmd.Parameters.Add(new SqlParameter("@FecPed", SqlDbType.SmallDateTime)).Value = vFecha;
                Cmd.Parameters.Add(new SqlParameter("@IdDoc", SqlDbType.Int)).Value = vIdDoc;
                Cmd.Parameters.Add(new SqlParameter("@IdOpe", SqlDbType.Int)).Value = vIdOpe;
                Cmd.Parameters.Add(new SqlParameter("@Activo", SqlDbType.Bit)).Value = vactivo;
                //Cmd.Parameters.Add(new SqlParameter("@Monto", SqlDbType.Money)).Value = vMonto;
                cn.Open();
                Cmd.ExecuteScalar();
                return int.Parse(Cmd.Parameters["@IdPed"].Value.ToString());
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public int setDespacho( int vIdEmp, DateTime vFecha, int vIdDoc, int vIdOpe, Boolean vactivo)
        {
            try
            {

                SqlConnection cn = new SqlConnection(Conex);
                SqlCommand Cmd = new SqlCommand("USP_AdicionarDespacho", cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@IdDes", SqlDbType.Int)).Direction = ParameterDirection.Output;
                Cmd.Parameters.Add(new SqlParameter("@IdEmp", SqlDbType.Int)).Value = vIdEmp;
                Cmd.Parameters.Add(new SqlParameter("@FecDes", SqlDbType.SmallDateTime)).Value = vFecha;
                Cmd.Parameters.Add(new SqlParameter("@idDoc", SqlDbType.Int)).Value = vIdDoc;
                Cmd.Parameters.Add(new SqlParameter("@idOpe", SqlDbType.Int)).Value = vIdOpe;
                Cmd.Parameters.Add(new SqlParameter("@activo", SqlDbType.Bit)).Value = vactivo;
               
                cn.Open();
                Cmd.ExecuteScalar();
                return int.Parse(Cmd.Parameters["@IdDes"].Value.ToString());
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void SetActualizarProductoPedidos(int vIdPro, short vCant)
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conex);
                SqlCommand Cmd = new SqlCommand("USP_ActualizarStockPedidos", cn);

                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@idProd", SqlDbType.Int)).Value = vIdPro;
                Cmd.Parameters.Add(new SqlParameter("@Can", SqlDbType.SmallInt)).Value = vCant;
                cn.Open();
                Cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void SetActualizarProductoDespachos(int vIdPro, short vCant)
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conex);
                SqlCommand Cmd = new SqlCommand("USP_ActualizarStockDespachos", cn);

                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@idProd", SqlDbType.Int)).Value = vIdPro;
                Cmd.Parameters.Add(new SqlParameter("@Can", SqlDbType.SmallInt)).Value = vCant;
                cn.Open();
                Cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void setDetalle(int vIdPedido, int vIdPro, decimal vPrecio, short vCantidad,Boolean vactivo)
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conex);
                SqlCommand Cmd = new SqlCommand("USP_AdicionarDetalle", cn);

                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@IdPed", SqlDbType.Int)).Value = vIdPedido;
                Cmd.Parameters.Add(new SqlParameter("@IdProd", SqlDbType.Int)).Value = vIdPro;
                Cmd.Parameters.Add(new SqlParameter("@preCompra", SqlDbType.Money)).Value = vPrecio;
                Cmd.Parameters.Add(new SqlParameter("@Can", SqlDbType.SmallInt)).Value = vCantidad;
                Cmd.Parameters.Add(new SqlParameter("@activo", SqlDbType.Bit)).Value = vactivo;
                cn.Open();
                Cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void setDetalleDespacho(int vIdPedido, int vIdPro, decimal vPrecio, short vCantidad, Boolean vactivo)
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conex);
                SqlCommand Cmd = new SqlCommand("USP_AdicionarDetalleDespacho", cn);

                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@IdDes", SqlDbType.Int)).Value = vIdPedido;
                Cmd.Parameters.Add(new SqlParameter("@IdPro", SqlDbType.Int)).Value = vIdPro;
                Cmd.Parameters.Add(new SqlParameter("@PreCompra", SqlDbType.Money)).Value = vPrecio;
                Cmd.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.SmallInt)).Value = vCantidad;
                Cmd.Parameters.Add(new SqlParameter("@activo", SqlDbType.Bit)).Value = vactivo;
                cn.Open();
                Cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable getPedidos()
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conex);
                SqlDataAdapter Dap = new SqlDataAdapter("USP_ListarPedidosDelDia", cn);
                DataTable Dt = new DataTable();
                Dap.Fill(Dt);
                return Dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable getDespachos()
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conex);
                SqlDataAdapter Dap = new SqlDataAdapter("USP_ListarDespachosDelDia", cn);
                DataTable Dt = new DataTable();
                Dap.Fill(Dt);
                return Dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
