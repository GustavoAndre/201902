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
    public partial class frmArea : Form
    {
        Area objArea = new Area();
        CC_area objAreaCC = new CC_area();
        public int FilaActual;
        public frmArea()
        {
            InitializeComponent();
            ListarAreas();
        }

        private void ListarAreas()
        {
            DataTable dt = null;
            dt = objAreaCC.ListarArea(0);
            dgvListarArea.DataSource = null;
            dgvListarArea.DataSource = dt;
        }
        private void CapturarDatos(int var)
        {
            Area.vgb_operacion = var;

            FilaActual = dgvListarArea.CurrentCell.RowIndex;

            objArea.IdArea = (int)dgvListarArea.Rows[FilaActual].Cells[0].Value;
            objArea.NomArea = (string)dgvListarArea.Rows[FilaActual].Cells[1].Value;
            objArea.Activo = (bool)dgvListarArea.Rows[FilaActual].Cells[2].Value;

            frmCrudArea objfrmarea = new frmCrudArea(objArea);
            objfrmarea.FormClosed += new FormClosedEventHandler(of_FormClosed);
            objfrmarea.StartPosition = FormStartPosition.CenterScreen;
            objfrmarea.ShowDialog();
        }
        private void of_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListarAreas();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            CapturarDatos(1);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            CapturarDatos(2);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            CapturarDatos(3);
        }

        private void FrmArea_Load(object sender, EventArgs e)
        {

        }

        private void DgvListarArea_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int FilaActual = dgvListarArea.CurrentCell.RowIndex;
            String Area = (string)dgvListarArea.Rows[FilaActual].Cells[1].Value;
            frmReporteEmpleadoxArea objarea = new frmReporteEmpleadoxArea(Area);
        }
    }
}
