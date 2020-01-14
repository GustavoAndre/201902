using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador;
using Capa_Entidad;

namespace Capa_Vista
{
    public partial class frmCargo : Form
    {
        CC_cargo objCargoCC = new CC_cargo();
        Cargo objCar = new Cargo();
        public int FilaActual;
        public frmCargo()
        {
            InitializeComponent();
            ListarCargo();
        }

        private void ListarCargo()
        {
            DataTable dt = null;
            dt = objCargoCC.ListarCargo(0);
            dgvListarCargo.DataSource = null;
            dgvListarCargo.DataSource = dt;
        }
        private void CapturarDatos(int var)
        {
            Cargo.vgb_operacion = var;
            FilaActual = dgvListarCargo.CurrentCell.RowIndex;

            objCar.IdCar = (int)dgvListarCargo.Rows[FilaActual].Cells[0].Value;
            objCar.NomCar = (string)dgvListarCargo.Rows[FilaActual].Cells[1].Value;
            objCar.DesCar = (string)dgvListarCargo.Rows[FilaActual].Cells[2].Value;
            objCar.Activo = (bool)dgvListarCargo.Rows[FilaActual].Cells[3].Value;


            frmCrudCargo frmcrudcar = new frmCrudCargo(objCar);
            frmcrudcar.FormClosed += new FormClosedEventHandler(of_FormClosed);
            frmcrudcar.StartPosition = FormStartPosition.CenterScreen;
            frmcrudcar.ShowDialog();
        }
        private void of_FormClosed(object sender, FormClosedEventArgs e)
        {
           ListarCargo();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
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
    }
}
