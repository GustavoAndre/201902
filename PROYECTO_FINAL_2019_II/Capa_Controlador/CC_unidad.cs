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
    public class CC_unidad
    {
        CM_unidad objUni = new CM_unidad();
        public DataTable ListaUnidad(int idUnidad)
        {
            SqlParameter[] parParametros = new SqlParameter[1];
            parParametros[0] = new SqlParameter();
            parParametros[0].ParameterName = "@idUnidadMedida";
            parParametros[0].SqlDbType = SqlDbType.Int;
            parParametros[0].Value = idUnidad;
            //
            DataTable dtt = objUni.ListarUnidad(parParametros, "USP_ListarUnidadMedida");
            return dtt;
        }
    }
}
