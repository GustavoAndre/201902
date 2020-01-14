using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Controlador;

namespace Capa_Vista
{
    public partial class frmCrudEmpleado : Form
    {
        //frmEmpleado objfrmEmp = new frmEmpleado();
        Empleado objEmp = null;
        CC_Empleado objEmpCC = new CC_Empleado();
        CC_validarUsuario objTablitas = null;
        DataSet dst = null;
        public frmCrudEmpleado(Empleado objEmpleado)
        {
            objEmp = objEmpleado;
            InitializeComponent();
            llenarCombos();
            MostrarDatos();
        }
        public void MostrarDatos()
        {
            if (Empleado.vgb_operacion == 2 || Empleado.vgb_operacion == 3)
            {
                txtCodEmp.Text = objEmp.IdEmp.ToString();
                cboCodCargo.SelectedValue = objEmp.IdCar;
                txtApePatEmp.Text = objEmp.ApePatEmp.ToUpper();
                txtApeMatEmp.Text = objEmp.ApeMatEmp.ToUpper();
                txtNomEmp.Text = objEmp.NomEmp;
                dtpFecNacEmp.Value = objEmp.FecNacEmp;
                txtFecIngEmp.Text= objEmp.FecIngEmp.ToString();
                cboCodDis.SelectedValue = objEmp.IdDis;
                txtTelEmp.Text = objEmp.TelEmp.ToString();
                txtCelEmp.Text = objEmp.CelEmp.ToString();
                //cboSexo.Text = (objEmpleado.Sexo == 'M') ? "MASCULINO" : "FEMENINO";
                txtCorEmp.Text = objEmp.CorEmp;
                txtObsEmp.Text = objEmp.ObsEmp;
                chckActivo.Checked = objEmp.Activo;
            }
        }
      

        private void llenarCombos()
        {
            objTablitas = new CC_validarUsuario();
            dst = objTablitas.listarTablitas();
            /*Combo Distritos*/
            cboCodDis.DataSource = dst.Tables[0].DefaultView;
            cboCodDis.DisplayMember = "NomDis";
            cboCodDis.ValueMember = "IdDis";
            /*Combo Cargos*/
            cboCodCargo.DataSource = dst.Tables[1].DefaultView;
            cboCodCargo.DisplayMember = "NomCar";
            cboCodCargo.ValueMember = "IdCar";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            switch (Empleado.vgb_operacion)
            {
                case 1: GuardarEmpleado(); break;
                case 2: GuardarActualizar(); break;
            }
        }


        void GuardarEmpleado()
        {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que quiere Guardar Nuevo Empleado!!!?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    if (Empleado.vgb_operacion == 1)
                    {
                        objEmp.IdEmp = int.Parse(txtCodEmp.Text);
                        objEmp.IdCar = int.Parse(cboCodCargo.SelectedValue.ToString());
                        objEmp.ApePatEmp = txtApePatEmp.Text;
                        objEmp.ApeMatEmp = txtApeMatEmp.Text;
                        objEmp.NomEmp = txtNomEmp.Text;
                        objEmp.FecNacEmp = DateTime.Parse(dtpFecNacEmp.Text);
                        objEmp.FecIngEmp = DateTime.Parse(txtFecIngEmp.Text);
                        objEmp.IdDis = int.Parse(cboCodDis.SelectedValue.ToString());
                        objEmp.TelEmp = int.Parse(txtTelEmp.Text);
                        objEmp.CelEmp = int.Parse(txtCelEmp.Text);
                        objEmp.CorEmp = txtCorEmp.Text;
                        objEmp.ObsEmp = txtObsEmp.Text;
                        objEmp.Activo = chckActivo.Checked ? true : false;
                    }
                    

                    /*int newEmpId = */
                    objEmpCC.guardarEmpleado(objEmp);
                    //txtCodigoProducto.Text = newEmpId.ToString();
                    MessageBox.Show("El Empleado se Grabó correctamente....", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falta Completar los datos...");
                }

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }
        void GuardarActualizar()
        {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que quiere Actualizar los Cambios del Empleado!!!?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CopiarDatosObjeto())
                    {
                        objEmpCC.ActualizarEmpleado(objEmp);

                        MessageBox.Show("El Empleado se Actualizó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Falta Completar los datos...");
                    }
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        Boolean CopiarDatosObjeto()
        {
            bool ok = false;
            if (ValidarDatos())
            {
                ok = true;
                if (Empleado.vgb_operacion == 2)
                {
                    objEmp.IdEmp = int.Parse(txtCodEmp.Text);
                    objEmp.IdCar = int.Parse(cboCodCargo.SelectedValue.ToString());
                    objEmp.ApePatEmp = txtApePatEmp.Text;
                    objEmp.ApeMatEmp = txtApeMatEmp.Text;
                    objEmp.NomEmp = txtNomEmp.Text;
                    objEmp.FecNacEmp = DateTime.Parse(dtpFecNacEmp.Text);
                    objEmp.FecIngEmp = DateTime.Parse(txtFecIngEmp.Text);
                    objEmp.IdDis = int.Parse(cboCodDis.SelectedValue.ToString());
                    objEmp.TelEmp = int.Parse(txtTelEmp.Text);
                    objEmp.CelEmp = int.Parse(txtCelEmp.Text);
                    objEmp.CorEmp = txtCorEmp.Text;
                    objEmp.ObsEmp = txtObsEmp.Text;
                    objEmp.Activo = chckActivo.Checked ? true : false;
                }
            }
            return ok;
        }
        private Boolean ValidarDatos()
        {
            Boolean valor = true;
            foreach (TextBox item in Controls.OfType<TextBox>().OrderBy(tb => tb.TabIndex))
            {

                if (item.Text.Equals(""));
            }

            return valor;
        }

        private void FrmCrudEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
