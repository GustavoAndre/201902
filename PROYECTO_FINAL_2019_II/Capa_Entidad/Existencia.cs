using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Existencia
    {
        public int idExi { get; set; }
        public String nomExi { get; set; }
        public Boolean activo { get; set; }

        public Existencia()
        {
        }

        public Existencia(int idExi, string nomExi, bool activo)
        {
            this.idExi = idExi;
            this.nomExi = nomExi;
            this.activo = activo;
        }

        public static int vgb_operacion;
        public static void Inicializar()
        {
            vgb_operacion = 0;

        }
    }
}
