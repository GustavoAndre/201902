using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Area
    {
        public int IdArea { get; set; }
        public string NomArea { get; set; }
        public bool Activo { get; set; }

        public Area()
        {
        }

        public Area(int idArea, string nomArea, bool activo)
        {
            IdArea = idArea;
            NomArea = nomArea;
            Activo = activo;
        }

        public static int vgb_operacion;
        public static void Inicializar()
        {
            vgb_operacion = 0;

        }
    }
}
