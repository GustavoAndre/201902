using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Categoria
    {
        public int IdCat { get; set; }
        public string NomCat { get; set; }
        public string DesCat { get; set; }
        public bool Activo { get; set; }

        public Categoria()
        {
        }

        public Categoria(int idCat, string nomCat, string desCat, bool activo)
        {
            IdCat = idCat;
            NomCat = nomCat;
            DesCat = desCat;
            Activo = activo;
        }

        public static int vgb_operacion;
        public static void Inicializar()
        {
            vgb_operacion = 0;

        }
    }
}
