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
    public partial class frmAlmacen : Form
    {
        public int filaActual;
        CC_almacen objAlmCC = new CC_almacen();
        Almacen objAlm = new Almacen();
        public frmAlmacen()
        {
            InitializeComponent();
            ListarAlmacen();
        }
        public void MostrarTablaDatos(int vop)
        {
            Almacen.vgb_operacion = vop;

            filaActual = dgListarAlmacen.CurrentCell.RowIndex;

            //CAPTURA LOS DATOS DE CADA COLUMNA DEL DATAGRIDVIEW Y LOS ALMACENA EN LOS ATRIBUTOS DE LA CLASE oEmpleado
            objAlm.IdAlm = (int)dgListarAlmacen.Rows[filaActual].Cells[0].Value;
            objAlm.NomAlm = (String)dgListarAlmacen.Rows[filaActual].Cells[1].Value;
            objAlm.DesAlm = (String)dgListarAlmacen.Rows[filaActual].Cells[2].Value;
            objAlm.UbiAlm = (String)dgListarAlmacen.Rows[filaActual].Cells[3].Value;
            objAlm.Activo = (bool)dgListarAlmacen.Rows[filaActual].Cells[4].Value;


            frmCrudAlmacen frmCrudAlmacen = new frmCrudAlmacen(objAlm);
            frmCrudAlmacen.FormClosed += new FormClosedEventHandler(of_FormClosed);
            frmCrudAlmacen.StartPosition = FormStartPosition.CenterScreen;
            frmCrudAlmacen.ShowDialog();

        }
        private void of_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListarAlmacen();
        }
        public void ListarAlmacen()
        {
            try
            {
                
                dgListarAlmacen.DataSource = objAlmCC.ListarAlmacen(0);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            MostrarTablaDatos(1);
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            MostrarTablaDatos(2);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            MostrarTablaDatos(3);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
