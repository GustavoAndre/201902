using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Controlador
{
    public class CC_consultaDetallePedidos
    {
        CM_consultaDetallePedido objDetPedCC = new CM_consultaDetallePedido();
        public DataSet RetornarDataSet()
        {
            DataSet dst = new DataSet();
            try
            {
                SqlConnection cnn = objDetPedCC.Conexion;
                dst.Tables.Add(objDetPedCC.retornarPedidos());
                dst.Tables.Add(objDetPedCC.retornarDetallePedidos());
                
                //Crear objetos Ralation y agregar al dataset
                //Primera Relacion
                DataRelation r1 = new DataRelation("Ver Pedidos", dst.Tables[0].Columns["IdPedido"], dst.Tables[1].Columns["IdPedido"]);
                dst.Relations.Add(r1);
                return dst;

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
