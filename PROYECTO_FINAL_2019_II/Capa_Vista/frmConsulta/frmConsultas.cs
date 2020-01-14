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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
            //AbrirFormularioEnPanel(new frmConsultaProdxCate());
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {

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

        private void EMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmConsultaProdxCate());
        }

        private void sTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EmpleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmConsultaEmpleadoPedidos());
        }

        private void DETALLEDECOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmConsultaDetallePedido());
        }

        private void AreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmConsultaEmpleadoxArea());
        }

        private void DetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
