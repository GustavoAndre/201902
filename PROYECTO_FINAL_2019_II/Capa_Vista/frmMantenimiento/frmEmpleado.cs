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
    public partial class frmEmpleado : Form
    {
        CC_Empleado objEmpCC = new CC_Empleado();
        Empleado objEmpleado = null;
        public int filaActual;
        public frmEmpleado()
        {
            InitializeComponent();
            ListarEmpleados();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            
        }

        private void MostrarTablaDatos(int vop)
        {
            Empleado.vgb_operacion = vop;

            objEmpleado = new Empleado();
            filaActual = dgvListarEmpleado.CurrentCell.RowIndex;

            objEmpleado.IdEmp = (int)dgvListarEmpleado.Rows[filaActual].Cells[0].Value;
            objEmpleado.ApePatEmp = (String)dgvListarEmpleado.Rows[filaActual].Cells[1].Value;
            objEmpleado.ApeMatEmp = (String)dgvListarEmpleado.Rows[filaActual].Cells[2].Value;
            objEmpleado.NomEmp = (String)dgvListarEmpleado.Rows[filaActual].Cells[3].Value;
            objEmpleado.FecNacEmp = (DateTime)dgvListarEmpleado.Rows[filaActual].Cells[4].Value;
            objEmpleado.FecIngEmp = (DateTime)dgvListarEmpleado.Rows[filaActual].Cells[5].Value;
            objEmpleado.SexEmp = char.Parse(dgvListarEmpleado.Rows[filaActual].Cells[6].Value.ToString());
            objEmpleado.TelEmp = (int)dgvListarEmpleado.Rows[filaActual].Cells[7].Value;
            objEmpleado.CelEmp = (int)dgvListarEmpleado.Rows[filaActual].Cells[8].Value;
            objEmpleado.CorEmp = (String)dgvListarEmpleado.Rows[filaActual].Cells[9].Value.ToString();
            objEmpleado.ObsEmp = (string)dgvListarEmpleado.Rows[filaActual].Cells[10].Value;
            objEmpleado.IdDis = (int)dgvListarEmpleado.Rows[filaActual].Cells[11].Value;
            objEmpleado.IdCar = (int)dgvListarEmpleado.Rows[filaActual].Cells[12].Value;
            objEmpleado.IdAre = (int)dgvListarEmpleado.Rows[filaActual].Cells[13].Value;
            objEmpleado.Activo = (bool)dgvListarEmpleado.Rows[filaActual].Cells[14].Value;

            frmCrudEmpleado frmobjEmp = new frmCrudEmpleado(objEmpleado);
            frmobjEmp.FormClosed += new FormClosedEventHandler(Of_FormClosed);
            frmobjEmp.ShowDialog();
            frmobjEmp.StartPosition = FormStartPosition.CenterScreen;
            //DeshabilitarControles();

        }
        private void Of_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListarEmpleados();
        }
        private void DeshabilitarControles()
        {
            btnNuevo.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnSalir.Enabled = false;
        }
        private void ListarEmpleados()
        {
            try
            {
                DataTable dt = objEmpCC.ListarEmpleado(0);
                dgvListarEmpleado.DataSource = null;
                dgvListarEmpleado.DataSource = dt;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //private void AbrirFormularioEnPanel(object frmhijo)
        //{
        //    if (this.panelPadre.Controls.Count > 0)

        //        this.panelPadre.Controls.RemoveAt(0);
        //    Form fh = frmhijo as Form;
        //    fh.TopLevel = false;
        //    fh.Dock = DockStyle.Fill;
        //    this.panelPadre.Controls.Add(fh);
        //    this.panelPadre.Tag = fh;
        //    fh.Show();
        //}
        private void BtnNuevo_Click(object sender, EventArgs e)
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
