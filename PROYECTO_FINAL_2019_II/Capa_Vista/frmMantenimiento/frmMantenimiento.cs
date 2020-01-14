using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista
{
    public partial class frmMantenimiento : Form
    {
      
        public frmMantenimiento()
        {
            InitializeComponent();
            AbrirFormularioEnPanel(new frmProducto());
        }
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
        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pRODUCTOSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pRODUCTOSToolStripMenuItem.BackColor = Color.White;
            pRODUCTOSToolStripMenuItem.ForeColor = Color.Black; 
            AbrirFormularioEnPanel(new frmProducto());
        }

        private void cATEGORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmCategoria());
        }

        private void pROVEEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmProveedor());
        }

        private void dISTRITOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void eMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmEmpleado());
        }

        private void cARGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmCargo());
        }

        private void FrmMantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void AREAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmArea());
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DISTRITOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmDistrito());
        }

        private void OTROSToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            
        }

        private void OTROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }

        private void DOCUMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmTipoDocumento());
        }

        private void mERCADERIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmTipoExistencia());
        }

        private void ALMACENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmAlmacen());
        }

        private void Btnmaximizar_Click(object sender, EventArgs e)
        {
            
            frmMantenimiento objman = new frmMantenimiento();
            objman.FormBorderStyle = FormBorderStyle.FixedSingle;
            objman.WindowState = FormWindowState.Maximized;
            objman.Show();
        }
    }
}
