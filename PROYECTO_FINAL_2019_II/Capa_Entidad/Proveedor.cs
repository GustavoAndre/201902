using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Proveedor
    {
        public int IdPro { get; set; }
        public int RucCom { get; set; }
        public string NomCom { get; set; }
        public string NomCon { get; set; }
        public string ApePatCon { get; set; }
        public string ApeMatCon { get; set; }
        public String CarCon { get; set; }
        public string DirPro { get; set; }
        public int CelPro { get; set; }
        public string CorPro { get; set; }
        public DateTime FecRegPro { get; set; }
        public int CodDis { get; set; }
        public bool Activo { get; set; }

        public Proveedor()
        {
        }

        public Proveedor(int idPro, int rucCom, string nomCom, string nomCon,
            string apePatCon, string apeMatCon, String carCon, 
            string dirPro, int celPro, string corPro, DateTime fecRegPro,
            int codDis, bool activo)
        {
            IdPro = idPro;
            RucCom = rucCom;
            NomCom = nomCom;
            NomCon = nomCon;
            ApePatCon = apePatCon;
            ApeMatCon = apeMatCon;
            CarCon = carCon;
            DirPro = dirPro;
            CelPro = celPro;
            CorPro = corPro;
            FecRegPro = fecRegPro;
            CodDis = codDis;
            Activo = activo;
        }
        public static int vgb_operacion;
        public static void Inicializar()
        {
            vgb_operacion = 0;

        }
    }
}
