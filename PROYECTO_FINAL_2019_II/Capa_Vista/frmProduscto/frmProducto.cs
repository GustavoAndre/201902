using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador;
using Capa_Entidad;

namespace Capa_Vista
{
    public partial class frmProducto : Form
    {
        public int filaActual;
        Producto objProd = new Producto();
        CC_producto objProdC = new CC_producto();

        public frmProducto()
        {
            InitializeComponent();
            ListarProductos();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {

        }

        private void ListarProductos()
        {
            try
            {
                DataTable tablita = objProdC.ListarProductos(0);
                dgvMostrarProductos.DataSource = null;
                dgvMostrarProductos.DataSource = tablita;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private void MostrarTablaDatos(int vop)
        {
            Producto.vgb_operacion = vop;//ALMACENAMOS EL VALOR RECIBIDO A TRAVEZ DEL PARAMETRO EN EL ATRIBUTO vgb_operacion.

            /*configurar el objeto Empleado, para enviar los datos a la ventana de ingresos*/

           /* filaActual = dgvMostrarProductos.CurrentCell.RowIndex;*///Captura el indice de la fila actual

            //CAPTURA LOS DATOS DE CADA COLUMNA DEL DATAGRIDVIEW Y LOS ALMACENA EN LOS ATRIBUTOS DE LA CLASE oEmpleado
           
            //objProd.IdProducto = (int)dgvMostrarProductos.Rows[filaActual].Cells[0].Value;
            //objProd.NombreProducto = (String)dgvMostrarProductos.Rows[filaActual].Cells[1].Value;
            //objProd.PrecioCompra = (decimal)dgvMostrarProductos.Rows[filaActual].Cells[2].Value;
            //objProd.PrecioVenta = (decimal)dgvMostrarProductos.Rows[filaActual].Cells[3].Value;
            //objProd.FechaVencimiento = (DateTime)dgvMostrarProductos.Rows[filaActual].Cells[4].Value;
            //objProd.StockProducto = (int)dgvMostrarProductos.Rows[filaActual].Cells[5].Value;
            //objProd.Activo = (bool)dgvMostrarProductos.Rows[filaActual].Cells[6].Value;
           

            //frmAgregarProducto frmagregar_prod = new frmAgregarProducto(objProd);
            //frmagregar_prod.FormClosed += new FormClosedEventHandler(of_FormClosed);
            //frmagregar_prod.StartPosition = FormStartPosition.CenterScreen;
            //frmagregar_prod.Show();

        }
        //private void of_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    ListarProductos();
        //}
        private void AbrirFormularioEnPanel(object frmhijo)
        {
            if (this.panelPadre.Controls.Count > 0)

                this.panelPadre.Controls.RemoveAt(0);
                Form fh = frmhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelPadre.Controls.Add(fh);
                this.panelPadre.Tag = fh;
                fh.Show();
        }
        private void Btnagregar_Click(object sender, EventArgs e)
        {
            MostrarTablaDatos(1);
            AbrirFormularioEnPanel(new frmAgregarProducto(objProd));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
