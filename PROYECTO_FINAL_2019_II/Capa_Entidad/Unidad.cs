using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Unidad
    {
        public int idUni { get; set; }
        public String nomUni { get; set; }
        public Boolean activo { get; set; }

        public Unidad()
        {
        }

        public Unidad(int idUni, string nomUni, bool activo)
        {
            this.idUni = idUni;
            this.nomUni = nomUni;
            this.activo = activo;
        }

        public static int vgb_operacion;
        public static void Inicializar()
        {
            vgb_operacion = 0;

        }
    }
}
