using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Cargo
    {
        public int IdCar { get; set; }
        public string NomCar { get; set; }
        public string DesCar { get; set; }
        public bool Activo { get; set; }

        public Cargo()
        {
        }

        public Cargo(int idCar, string nomCar, string desCar, bool activo)
        {
            IdCar = idCar;
            NomCar = nomCar;
            DesCar = desCar;
            Activo = activo;
        }

        public static int vgb_operacion;
        public static void Inicializar()
        {
            vgb_operacion = 0;

        }
    }
}
