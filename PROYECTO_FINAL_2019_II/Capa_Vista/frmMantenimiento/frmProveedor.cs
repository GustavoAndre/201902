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
    public partial class frmProveedor : Form
    {
        CC_proveedor objProvCC = new CC_proveedor();
        Proveedor objProv = new Proveedor();
        public int FilaActual;

        public frmProveedor()
        {
            InitializeComponent();
            ListarProveedor();
        }


        public void ListarProveedor()
        {
            DataTable dt = null;
            dt = objProvCC.ListarProveedor(0);
            dgvListarProveedor.DataSource = null;
            dgvListarProveedor.DataSource = dt;
        }

        private void CapturaDatos(int var)
        {
            Proveedor.vgb_operacion = var;
            FilaActual = dgvListarProveedor.CurrentCell.RowIndex;

            objProv.IdPro = (int)dgvListarProveedor.Rows[FilaActual].Cells[0].Value;
            objProv.RucCom = (int)dgvListarProveedor.Rows[FilaActual].Cells[1].Value;
            objProv.NomCom = (string)dgvListarProveedor.Rows[FilaActual].Cells[2].Value;
            objProv.NomCon = (string)dgvListarProveedor.Rows[FilaActual].Cells[3].Value;
            objProv.ApePatCon = (string)dgvListarProveedor.Rows[FilaActual].Cells[4].Value;
            objProv.ApeMatCon = (string)dgvListarProveedor.Rows[FilaActual].Cells[5].Value;
            objProv.CarCon = (String)dgvListarProveedor.Rows[FilaActual].Cells[6].Value;
            objProv.DirPro = (string)dgvListarProveedor.Rows[FilaActual].Cells[7].Value;
            objProv.CelPro = (int)dgvListarProveedor.Rows[FilaActual].Cells[8].Value;
            objProv.CorPro = (string)dgvListarProveedor.Rows[FilaActual].Cells[9].Value;
            objProv.FecRegPro = (DateTime)dgvListarProveedor.Rows[FilaActual].Cells[10].Value;
            objProv.CodDis = (int)dgvListarProveedor.Rows[FilaActual].Cells[11].Value;
            objProv.Activo = (bool)dgvListarProveedor.Rows[FilaActual].Cells[12].Value;

            frmCrudProveedor frmCrudProv = new frmCrudProveedor(objProv);
            frmCrudProv.FormClosed += new FormClosedEventHandler(of_FormClosed);
            frmCrudProv.StartPosition = FormStartPosition.CenterScreen;
            frmCrudProv.ShowDialog();
        }
        private void of_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListarProveedor();
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CapturaDatos(2);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            CapturaDatos(3);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            CapturaDatos(1);
        }
    }
}
