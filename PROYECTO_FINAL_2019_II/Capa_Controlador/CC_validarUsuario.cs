using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_Entidad;
using Capa_Modelo;

namespace Capa_Controlador
{
    public class CC_validarUsuario
    {
        CM_validarUsuario objValidarUsuario = new CM_validarUsuario();
        CM_validarUsuario objTablitas = new CM_validarUsuario();
        DataSet dst = null;
        
        public DataTable validarUsuario(Usuario obj )
       {
            DataTable dt = objValidarUsuario.validarUsuario(obj);
            if (dt!=null)
            {

                return dt;
            }
            else
            {
                return null;
            }
       }

       
            

            public DataSet listarTablitas()
            {
                try
                {
                    dst = objTablitas.RetornarTablitas();

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return dst;
            }
    }
}
