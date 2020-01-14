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

        public void ListarProductos()
        {
            try
            {
                DataTable tablita = objProdC.ListarProductos(0);
                dgvMostrarProductos.DataSource = null;
                dgvMostrarProductos.DataSource = tablita;

                int nfilas = tablita.Rows.Count;
                for (int i = 0; i < nfilas; i++)
                {
                    if ((int)dgvMostrarProductos.Rows[i].Cells[8].Value < (int)dgvMostrarProductos.Rows[i].Cells[9].Value)
                    {
                        frmMenu objm = new frmMenu();
                        objm.btnInformacion.BackColor = Color.Red;
                    }
                }


            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void MostrarTablaDatos(int vop)
        {
            Producto.vgb_operacion = vop;

            filaActual = dgvMostrarProductos.CurrentCell.RowIndex;

            //CAPTURA LOS DATOS DE CADA COLUMNA DEL DATAGRIDVIEW Y LOS ALMACENA EN LOS ATRIBUTOS DE LA CLASE oEmpleado
            objProd.IdProducto = (int)dgvMostrarProductos.Rows[filaActual].Cells[0].Value;
            objProd.NombreProducto = (String)dgvMostrarProductos.Rows[filaActual].Cells[1].Value;
            objProd.DescripcionProducto = (String)dgvMostrarProductos.Rows[filaActual].Cells[2].Value;
            objProd.IdCategoria = (int)dgvMostrarProductos.Rows[filaActual].Cells[3].Value;
            objProd.IdAlm = (int)dgvMostrarProductos.Rows[filaActual].Cells[4].Value;
            objProd.CantidadxUnidad = (String)dgvMostrarProductos.Rows[filaActual].Cells[5].Value;
            objProd.PrecioCompra = (decimal)dgvMostrarProductos.Rows[filaActual].Cells[6].Value;
            objProd.FechaDeRegistro= (DateTime)dgvMostrarProductos.Rows[filaActual].Cells[7].Value;
            objProd.StockProducto = (int)dgvMostrarProductos.Rows[filaActual].Cells[8].Value;
            objProd.StockMinProducto = (int)dgvMostrarProductos.Rows[filaActual].Cells[9].Value;
            objProd.StockMaxProducto = (int)dgvMostrarProductos.Rows[filaActual].Cells[10].Value;
            objProd.IdUni = (int)dgvMostrarProductos.Rows[filaActual].Cells[11].Value;
            objProd.IdMer = (int)dgvMostrarProductos.Rows[filaActual].Cells[12].Value;
            objProd.Activo = (bool)dgvMostrarProductos.Rows[filaActual].Cells[13].Value;
            
            
           frmAgregarProducto frmagregar_prod = new frmAgregarProducto(objProd);
            frmagregar_prod.FormClosed += new FormClosedEventHandler(of_FormClosed);
            frmagregar_prod.StartPosition = FormStartPosition.CenterScreen;
            frmagregar_prod.ShowDialog();

        }
        private void of_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListarProductos();
        }
        private void Btnagregar_Click(object sender, EventArgs e)
        {
            
            MostrarTablaDatos(1);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            MostrarTablaDatos(2);
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            MostrarTablaDatos(3);
        }

        private void DeshabilitarControles()
        {
            btnagregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnSalir.Enabled = false;
        }

        private void FrmProducto_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
