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
    public partial class frmDistrito : Form
    {
        CC_distrito objDisCC = new CC_distrito();
        Distrito objdis = new Distrito();
        public int ActualFila;
        public frmDistrito()
        {
            InitializeComponent();
            ListarDistrito();
        }

        private void ListarDistrito()
        {
            try
            {
                DataTable tablita = objDisCC.ListarDistrito(0);
                dgvListarDistrito.DataSource = null;
                dgvListarDistrito.DataSource = tablita;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        private void CapturarDatos(int dato)
        {
            Distrito.vgb_operacion = dato;

            ActualFila = dgvListarDistrito.CurrentCell.RowIndex;

            objdis.IdDis = (int)dgvListarDistrito.Rows[ActualFila].Cells[0].Value;
            objdis.NomDis = (string)dgvListarDistrito.Rows[ActualFila].Cells[1].Value;
            objdis.ConDis = (string)dgvListarDistrito.Rows[ActualFila].Cells[2].Value;
            objdis.Activo = (bool)dgvListarDistrito.Rows[ActualFila].Cells[3].Value;


            frmCrudDistrito frmCrudDis = new frmCrudDistrito(objdis);
            //LimpiarTB();
            frmCrudDis.FormClosed += new FormClosedEventHandler(of_FormClosed);
            frmCrudDis.StartPosition = FormStartPosition.CenterScreen;
            frmCrudDis.ShowDialog();
        }

        private void of_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListarDistrito();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            CapturarDatos(1);
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CapturarDatos(2);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            CapturarDatos(3);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDistrito_Load(object sender, EventArgs e)
        {

        }
        public void LimpiarTB()
        {
            DataTable dt = (DataTable)dgvListarDistrito.DataSource;
            dt.Clear();
            dgvListarDistrito.DataSource = objDisCC.ListarDistrito(0);
        }
        
    }
}
