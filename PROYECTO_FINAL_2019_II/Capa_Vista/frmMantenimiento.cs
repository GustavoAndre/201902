﻿using System;
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
            AbrirFormularioEnPanel(new frmProducto());
        }
    }
}
