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
using Capa_Entidad;
using Capa_Controlador;

namespace Capa_Vista
{
    public partial class frmCrudProveedor : Form
    {
        Proveedor objProv = null;
        CC_proveedor objProvCC = new CC_proveedor();
        CC_distrito objLisDis = new CC_distrito();
        public frmCrudProveedor(Proveedor objprov)
        {
            objProv = objprov;
            InitializeComponent();
            MostrarDatos();
            LlenarCombo();
        }

        private void LlenarCombo()
        {
            cboDistrito.DataSource = objLisDis.ListarDistrito(0);
            cboDistrito.DisplayMember = "NomDis";
            cboDistrito.ValueMember = "IdDis";
        }
        public void MostrarDatos()
        {
            if (Proveedor.vgb_operacion == 2 || Proveedor.vgb_operacion == 3)
            {
                txtCodProv.Text = objProv.IdPro.ToString();
                txtRucProv.Text = objProv.RucCom.ToString();
                txtNomCom.Text = objProv.NomCom.ToUpper();
                txtNomCon.Text = objProv.NomCon.ToUpper();
                txtApePat.Text = objProv.ApePatCon.ToUpper();
                txtApeMat.Text = objProv.ApeMatCon.ToUpper();
                txtCarProv.Text = objProv.CarCon.ToString();
                txtDirProv.Text = objProv.DirPro.ToString();
                txtCelProv.Text = objProv.CelPro.ToString();
                txtCorProv.Text = objProv.CorPro.ToUpper();
                dtpFecReg.Value = objProv.FecRegPro;
                cboDistrito.SelectedValue = objProv.CodDis.ToString();

                chckActProv.Checked = objProv.Activo;
            }

            if (Proveedor.vgb_operacion == 1)
            {
                gb.Enabled = true;
                gb.Text = "NUEVO PROVEEDOR";
                btnGuardar.Text = "GUARDAR PROVEEDOR";
                txtNomCon.Focus();
            }
            else if (Proveedor.vgb_operacion == 2)
            {
                gb.Enabled = true;
                gb.Text = "MODIFICAR PROVEEDOR";
                btnGuardar.Text = "ACTUALIZAR PROVEEDOR";
                txtNomCon.Focus();
            }
            else  
            {
                gb.Enabled = false;
                gb.Text = "ELIMINAR PROVEEDOR";
                btnGuardar.Text = "ELIMINAR PROVEEDOR";
            }
        }
        Boolean CopiarDatosObjeto()
        {
            Boolean ok = false;
            if (ValidarDatos())
            {
                ok = true;
                if (Proveedor.vgb_operacion == 1) objProv.IdPro = 0;
                else objProv.IdPro = int.Parse(txtCodProv.Text);

                objProv.RucCom = int.Parse(txtRucProv.Text);
                objProv.NomCom = txtNomCom.Text.ToUpper();
                objProv.NomCon = txtNomCon.Text.ToUpper();
                objProv.ApePatCon = txtApePat.Text.ToUpper();
                objProv.ApeMatCon = txtApeMat.Text.ToUpper();
                objProv.CarCon =txtCarProv.Text.ToUpper();
                objProv.DirPro = txtDirProv.Text.ToUpper();
                objProv.CelPro = int.Parse(txtCelProv.Text);
                objProv.CorPro = txtCorProv.Text.ToUpper();
                objProv.FecRegPro = dtpFecReg.Value;
                objProv.CodDis = int.Parse(cboDistrito.SelectedValue.ToString());
                objProv.Activo = chckActProv.Checked ? true : false;

            }
            return ok;
        }
        private Boolean ValidarDatos()
        {
            Boolean valor = true;
            foreach (TextBox item in gb.Controls.OfType<TextBox>().OrderBy(tb => tb.TabIndex))
            {

                if (item.Text.Equals("") && !(item.Name.Equals("txtCodProv"))) valor = false;
            }

            return valor;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            switch (Proveedor.vgb_operacion)
            {
                case 1: GuardarProveedor(); break;
                case 2: ActualizarProveedor(); break;
                case 3: EliminarProveedor(); break;
            }
        }

        void GuardarProveedor()
        {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que quiere Guardar Nuevo Proveedor ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CopiarDatosObjeto())
                    {
                        int IdProv = objProvCC.AgregarProveedor(objProv);
                       txtCodProv.Text = IdProv.ToString();
                        MessageBox.Show("El Proveedor se Grabó correctamente....", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        void ActualizarProveedor()
        {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que quiere Actualizar los Cambios del Proveedor ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CopiarDatosObjeto())
                    {
                        objProvCC.ActualizarProveedor(objProv);

                        MessageBox.Show("El Proveedor se Actualizó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        void EliminarProveedor()
        {

            try
            {

                if (MessageBox.Show("ESTA SEGURO DE ELIMINAR EL PROVEEDOR " + objProv.NomCom + " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objProvCC.EliminarProveedor(objProv);
                    MessageBox.Show("El proveedor se Elimino correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
