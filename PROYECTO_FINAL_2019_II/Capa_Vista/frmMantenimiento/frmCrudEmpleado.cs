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
                cboCodDis.SelectedValue = objEmp.IdDis.ToString();
                txtTelEmp.Text = objEmp.TelEmp.ToString();
                txtCelEmp.Text = objEmp.CelEmp.ToString();
                cboSexo.Text = (objEmp.SexEmp == 'M') ? "MASCULINO" : "FEMENINO";
                txtCorEmp.Text = objEmp.CorEmp;
                txtObsEmp.Text = objEmp.ObsEmp;
                chckActivo.Checked = objEmp.Activo;
            }

            if (Empleado.vgb_operacion == 1)//ingresar nuevo
            {
                gb.Enabled = true;
                this.Text = "Ingreso de Nuevo Empleado";
                btnGuardar.Text = "Grabar Nuevo";
                txtApePatEmp.Focus();
            }
            else if (Empleado.vgb_operacion == 2)//actualizar datos
            {
                gb.Enabled = true;
                this.Text = "Modificar Datos del Empleado";
                btnGuardar.Text = "Grabar Cambios";
                txtApePatEmp.Focus();
            }
            else  //Eliminar empleado
            {
                gb.Enabled = false;
                gb.Text = "Eliminar Empleado";
                btnGuardar.Text = "Eliminar Registro";
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
            /*Combo Areas*/
            cboArea.DataSource = dst.Tables[2].DefaultView;
            cboArea.DisplayMember = "NomAre";
            cboArea.ValueMember = "IdAre";
            /*Combo Sexo*/
            String[] aSexo = { "MASCULINO", "FEMENINO" };
            Char[] aValorSexo = { 'M', 'F' };
            cboSexo.Items.AddRange(aSexo);
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
                case 3: Eliminar();break;
            }
        }


        void GuardarEmpleado()
        {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que quiere Guardar Nuevo Empleado!!!?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CopiarDatosObjeto())
                    {
                        int IdEmp = objEmpCC.guardarEmpleado(objEmp);
                        txtCodEmp.Text = IdEmp.ToString();
                        MessageBox.Show("El Empleado se Grabó correctamente....", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Falta Completar los datos...");
                    }
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
        void Eliminar()
        {
            String Mensaje;
            
            if (cboSexo.Text ==  "MASCULINO")
            {
                Mensaje = "¿ESTA SEGURO/A DE ELIMINAR AL EMPLEADO ";
            }
            else
            {
                Mensaje = "¿ESTA SEGURO/A DE ELIMINAR A LA EMPLEADA ";
            }
            try
            {
                CC_Empleado objEmpCC = new CC_Empleado();
                if (MessageBox.Show(Mensaje +objEmp.ApePatEmp+ " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objEmpCC.EliminarEmpleado(objEmp);
                    MessageBox.Show("El Empleado se Elimino correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        Boolean CopiarDatosObjeto()
        {
            Boolean ok = false;
            if (ValidarDatos())
            {
                ok = true;
                if (Empleado.vgb_operacion == 1) objEmp.IdEmp = 0;
                else objEmp.IdEmp = int.Parse(txtCodEmp.Text);
                
                    
                    objEmp.ApePatEmp = txtApePatEmp.Text;
                    objEmp.ApeMatEmp = txtApeMatEmp.Text;
                    objEmp.NomEmp = txtNomEmp.Text;
                    objEmp.FecNacEmp = DateTime.Parse(dtpFecNacEmp.Text);
                    objEmp.FecIngEmp = DateTime.Parse(txtFecIngEmp.Text);
                    objEmp.SexEmp = char.Parse(cboSexo.Text.Substring(0, 1)); 
                    objEmp.TelEmp = int.Parse(txtTelEmp.Text);
                    objEmp.CelEmp = int.Parse(txtCelEmp.Text);
                    objEmp.CorEmp = txtCorEmp.Text;
                    objEmp.ObsEmp = txtObsEmp.Text;
                    objEmp.IdDis = int.Parse(cboCodDis.SelectedValue.ToString());
                    objEmp.IdCar = int.Parse(cboCodCargo.SelectedValue.ToString());
                    objEmp.IdAre = int.Parse(cboArea.SelectedValue.ToString());
                    objEmp.Activo = chckActivo.Checked ? true : false;
                
            }
            return ok;
        }
        private Boolean ValidarDatos()
        {
            Boolean valor = true;
            foreach (TextBox item in gb.Controls.OfType<TextBox>().OrderBy(tb => tb.TabIndex))
            {

                if (item.Text.Equals("") && !(item.Name.Equals("txtCodEmp"))) valor = false;
            }

            return valor;
        }

        private void FrmCrudEmpleado_Load(object sender, EventArgs e)
        {

        }

        
    }
}
