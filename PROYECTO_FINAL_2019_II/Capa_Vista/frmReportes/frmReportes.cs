using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.frmReportes
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
            //AbrirFormularioEnPanel(new frmReporteEmpleado());
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
        private void EMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void GENERALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmReporteEmpleado());
        }

        private void AREAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmReporteEmpleadoxArea());
        }

        private void CARGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmReporteEmpleadoxCargo());
        }

        private void MENSUALToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void GENERALToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmReporteProductoGeneral());
        }

        private void MESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmReporteDespachoProductoxMes());
        }

        private void MESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmReportePedidoProductoxMes());
        }

        private void PROVEEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ALMACENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmReporteProductosxAlmacen());
        }

        private void mENSUALToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fECHASALIDAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dESPACHOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mESToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmReportexMes());
        }
    }
}
