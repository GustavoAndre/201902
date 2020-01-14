using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Distrito
    {
        public int IdDis { get; set; }
        public string NomDis { get; set; }
        public string ConDis { get; set; }
        public bool Activo { get; set; }

        public Distrito()
        {
        }

        public Distrito(int idDis, string nomDis, string conDis, bool activo)
        {
            IdDis = idDis;
            NomDis = nomDis;
            ConDis = conDis;
            Activo = activo;
        }

        public static int vgb_operacion;
        public static void Inicializar()
        {
            vgb_operacion = 0;

        }
    }
}
