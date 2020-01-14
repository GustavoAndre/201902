using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Empleado
    {
        public int IdEmp { get; set; }
       
        public string ApePatEmp { get; set; }
        public string ApeMatEmp { get; set; }
        public string NomEmp { get; set; }
        public DateTime FecNacEmp { get; set; }
        public DateTime FecIngEmp { get; set; }
        public char SexEmp { get; set; }
        public int TelEmp { get; set; }
        public int CelEmp { get; set; }
        public string CorEmp { get; set; }
        public string ObsEmp { get; set; }
        public int IdDis { get; set; }
        public int IdCar { get; set; }
        public int IdAre { get; set; }
        public bool Activo { get; set; }

        public Empleado()
        {
        }

        public Empleado(int idEmp, string apePatEmp, string apeMatEmp,
            string nomEmp, DateTime fecNacEmp, DateTime fecIngEmp, char sexEmp,
            int telEmp, int celEmp, string corEmp, string obsEmp, int idDis, int idCar, int idAre, bool activo)
        {
            IdEmp = idEmp;
            ApePatEmp = apePatEmp;
            ApeMatEmp = apeMatEmp;
            NomEmp = nomEmp;
            FecNacEmp = fecNacEmp;
            FecIngEmp = fecIngEmp;
            SexEmp = sexEmp;
            TelEmp = telEmp;
            CelEmp = celEmp;
            CorEmp = corEmp;
            ObsEmp = obsEmp;
            IdDis = idDis;
            IdCar = idCar;
            IdAre = idAre;
            Activo = activo;
        }

        public static int vgb_operacion;
        public static void Inicializar()
        {
            vgb_operacion = 0;
                                         
        }
    }
}
