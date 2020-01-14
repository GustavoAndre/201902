using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Almacen
    {
        public int IdAlm { get; set; }
        public String NomAlm { get; set; }
        public String DesAlm { get; set; }
        public String UbiAlm { get; set; }
        public bool Activo { get; set; }

        public Almacen()
        {
        }

        public Almacen(int idAlm, string nomAlm, string desAlm, string ubiAlm, bool activo)
        {
            IdAlm = idAlm;
            NomAlm = nomAlm;
            DesAlm = desAlm;
            UbiAlm = ubiAlm;
            Activo = activo;
        }
        public static int vgb_operacion;
        public static void Inicializar()
        {
            vgb_operacion = 0;

        }
    }
}
