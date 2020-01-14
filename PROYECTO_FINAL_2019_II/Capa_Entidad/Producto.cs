using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public String CantidadxUnidad { get; set; }
        public decimal PrecioCompra { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public int StockProducto { get; set; }
        public int StockMinProducto { get; set; }
        public int StockMaxProducto { get; set; }
        public int IdAlm { get; set; }
        public int IdCategoria { get; set; }
        public int IdUni { get; set; }
        public int IdMer { get; set; }
        public bool Activo { get; set; }

        public Producto()
        {
        }

        public Producto(int idProducto, string nombreProducto, string descripcionProducto, 
            string cantidadxUnidad, decimal precioCompra, DateTime fechaDeRegistro, int stockProducto,
            int stockMinProducto, int stockMaxProducto,int idAlm, int idCategoria, int idUni, int idMer, bool activo)
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            DescripcionProducto = descripcionProducto;
            CantidadxUnidad = cantidadxUnidad;
            PrecioCompra = precioCompra;
            FechaDeRegistro = fechaDeRegistro;
            StockProducto = stockProducto;
            StockMinProducto = stockMinProducto;
            StockMaxProducto = stockMaxProducto;
            IdAlm = idAlm;
            IdCategoria = idCategoria;
            IdUni = idUni;
            IdMer = idMer;
            Activo = activo;
        }

        public static int vgb_operacion;
        public static void Inicializar()
        {
            vgb_operacion = 0;

        }
    }
}
