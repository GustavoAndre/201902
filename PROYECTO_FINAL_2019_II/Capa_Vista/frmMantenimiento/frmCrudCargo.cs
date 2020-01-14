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
    public partial class frmCrudCargo : Form
    {
        Cargo objcar = null;
        CC_cargo objCarCC = new CC_cargo();
        public frmCrudCargo(Cargo objCar)
        {
            objcar = objCar;
            InitializeComponent();
            MostrarDatos();
        }
        public void MostrarDatos()
        {
            if (Cargo.vgb_operacion == 2 || Cargo.vgb_operacion == 3)
            {
                txtCodCar.Text = objcar.IdCar.ToString();
                txtNomsCar.Text = objcar.NomCar.ToUpper();
                txtDesCar.Text = objcar.DesCar.ToUpper();
                chckActCar.Checked = objcar.Activo;
            }

            if (Cargo.vgb_operacion == 1)//ingresar nuevo
            {
                gb.Enabled = true;
                gb.Text = "NUEVO CARGO";
                btnGuardar.Text = "GUARDAR CARGO";
                txtNomsCar.Focus();
            }
            else if (Cargo.vgb_operacion == 2)//actualizar datos
            {
                gb.Enabled = true;
                gb.Text = "MODIFICAR CARGO";
                btnGuardar.Text = "ACTUALIZAR CARGO";
                txtNomsCar.Focus();
            }
            else  //Eliminar empleado
            {
                gb.Enabled = false;
                gb.Text = "ELIMINAR CARGO";
                btnGuardar.Text = "ELIMINAR CARGO";
            }
        }
        Boolean CopiarDatosObjeto()
        {
            Boolean ok = false;
            if (ValidarDatos())
            {
                ok = true;
                if (Cargo.vgb_operacion == 1) objcar.IdCar = 0;
                else objcar.IdCar = int.Parse(txtCodCar.Text);


                objcar.NomCar = txtNomsCar.Text;
                objcar.DesCar = txtDesCar.Text;
                objcar.Activo = chckActCar.Checked ? true : false;

            }
            return ok;
        }
        private Boolean ValidarDatos()
        {
            Boolean valor = true;
            foreach (TextBox item in gb.Controls.OfType<TextBox>().OrderBy(tb => tb.TabIndex))
            {

                if (item.Text.Equals("") && !(item.Name.Equals("txtCodCar"))) valor = false;
            }

            return valor;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            switch (Cargo.vgb_operacion)
            {
                case 1: GuardarCargo(); break;
                case 2: ActualizarCargo(); break;
                case 3: EliminarCargo(); break;
            }
        }

        void GuardarCargo()
        {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que quiere Guardar Nuevo Cargo ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CopiarDatosObjeto())
                    {
                        int idCar = objCarCC.GuardarCargo(objcar);
                        txtCodCar.Text = idCar.ToString();
                        MessageBox.Show("El Cargo se Grabó correctamente....", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        void ActualizarCargo()
        {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que quiere Actualizar los Cambios de la Tabla Cargo ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CopiarDatosObjeto())
                    {
                        objCarCC.ActualizarCargo(objcar);

                        MessageBox.Show("El Cargo se Actualizó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        void EliminarCargo()
        {

            try
            {

                if (MessageBox.Show("ESTA SEGURO DE ELIMINAR EL CARGO " + objcar.NomCar + " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objCarCC.EliminarCargo(objcar);
                    MessageBox.Show("El cargo se Elimino correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
