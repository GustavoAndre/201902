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
    public class CC_existencia
    {
        CM_existencia objExi = new CM_existencia();
        public DataTable ListaExistencia(int idExistencia)
        {
            SqlParameter[] parParametros = new SqlParameter[1];
            parParametros[0] = new SqlParameter();
            parParametros[0].ParameterName = "@idTipoExistencia";
            parParametros[0].SqlDbType = SqlDbType.Int;
            parParametros[0].Value = idExistencia;
            //
            DataTable dtt = objExi.ListarExistencia(parParametros, "USP_ListarTipoExistencia");
            return dtt;
        }
    }
}
