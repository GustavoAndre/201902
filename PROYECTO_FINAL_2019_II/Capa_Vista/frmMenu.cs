using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using System.Threading;

namespace Capa_Vista
{
    public partial class frmMenu : Form
    {
        frmAcceso objAcc = new frmAcceso();
        frmProducto objProd = new frmProducto();
        frmCalendario objcalendar = new frmCalendario();
        
        public frmMenu(string nombre,string cargo)
        {
            //Thread t = new Thread(new ThreadStart(StartForm));
            //t.Start();  
            //Thread.Sleep(5000);
            InitializeComponent();
            //t.Abort();
            timer_hora.Start();
            lblusuario.Text = nombre;
            lblCargo.Text = cargo;
            AbrirFormularioEnPanel(new frmDatosEmpresa());

        }
        public frmMenu()
        {
            InitializeComponent();
        }
        public void StartForm()
        {
            Application.Run(new frmSplash());
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            //if (lblCargo.Text != "Administrativo de almacén")
            //{
            //    btnReportes.Enabled = false;
            //    nUEVOUSUARIOToolStripMenuItem.Enabled = false;
            //    btnFormato12_1.Enabled = false;
            //    btnFormato13_1.Enabled = false;
            //}

        }

        private void  AbrirFormularioEnPanel(object frmhijo)
        {
            if(this.panelPadre.Controls.Count>0)
            
                this.panelPadre.Controls.RemoveAt(0);
                Form fh = frmhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelPadre.Controls.Add(fh);
                this.panelPadre.Tag = fh;
                fh.Show();
        }



        private void BtnMantenimiento_Click(object sender, EventArgs e)
        {
          
            AbrirFormularioEnPanel(new frmMantenimiento());
            //frmMantenimiento fman = new frmMantenimiento();
            //fman.MdiParent = this;
            //fman.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            timer_hora.Stop();
            objAcc.Show();
        }

        private void timer_hora_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmOperacion());
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmConsultas());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmReportes.frmReportes());
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmHerramientas());
        }
        
        private void PictureBox1_Click(object sender, EventArgs e)
        {

            AbrirFormularioEnPanel(new frmDatosEmpresa());
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NUEVOPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCalendario_Click(object sender, EventArgs e)
        {
            objcalendar.ShowDialog();
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void NUEVOUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario objUsu = new frmUsuario();
            objUsu.ShowDialog();
        }

        private void BtnInformacion_Click(object sender, EventArgs e)
        {
            frmInformacionSistema objfrmSis = new frmInformacionSistema();
            objfrmSis.ShowDialog();
            
        }
    }
}
