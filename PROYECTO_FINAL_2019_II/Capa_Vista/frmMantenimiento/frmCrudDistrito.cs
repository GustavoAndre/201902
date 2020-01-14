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
    public partial class frmCrudDistrito : Form
    {
        Distrito objdis = null;
        CC_distrito objDisCC = new CC_distrito();
        public frmCrudDistrito(Distrito objDis)
        {
            InitializeComponent();
            objdis = objDis;
            MostrarDatos();
        }
        public void MostrarDatos()
        {
            if (Distrito.vgb_operacion == 2 || Distrito.vgb_operacion == 3)
            {
                txtCodigoDistrito.Text = objdis.IdDis.ToString();
                txtNombre.Text = objdis.NomDis.ToUpper();
                txtCon.Text = objdis.ConDis.ToUpper();
                chckActivo.Checked = objdis.Activo;
            }

            if (Distrito.vgb_operacion == 1)//ingresar nuevo
            {
                gb.Enabled = true;
                gb.Text = "NUEVO DISTRITO";
                btnAceptar.Text = "GUARDAR DISTRITO";
                txtNombre.Focus();
            }
            else if (Distrito.vgb_operacion == 2)//actualizar datos
            {
                gb.Enabled = true;
                gb.Text = "MODIFICAR DISTRITO";
                btnAceptar.Text = "ACTUALIZAR DISTRITO";
                txtNombre.Focus();
            }
            else  //Eliminar empleado
            {
                gb.Enabled = false;
                gb.Text = "ELIMINAR DISTRITO";
                btnAceptar.Text = "ELIMINAR DISTRITO";
            }
        }
        Boolean CopiarDatosObjeto()
        {
            Boolean ok = false;
            if (ValidarDatos())
            {
                ok = true;
                if (Distrito.vgb_operacion == 1)objdis.IdDis = 0;
                else objdis.IdDis = int.Parse(txtCodigoDistrito.Text);


                objdis.NomDis = txtNombre.Text;
                objdis.ConDis = txtCon.Text;
                objdis.Activo = chckActivo.Checked ? true : false;

            }
            return ok;
        }
        private Boolean ValidarDatos()
        {
            Boolean valor = true;
            foreach (TextBox item in gb.Controls.OfType<TextBox>().OrderBy(tb => tb.TabIndex))
            {

                if (item.Text.Equals("") && !(item.Name.Equals("txtCodigoDistrito"))) valor = false;
            }

            return valor;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //frmDistrito objdis = new frmDistrito();
            //objdis.LimpiarTB();
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            switch (Distrito.vgb_operacion)
            {
                case 1: GuardarDistrito(); break;
                case 2: ActualizarDistrito(); break;
                case 3: EliminarDistrito(); break;
            }
        }

        void GuardarDistrito()
        {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que quiere Guardar Nuevo Distrito ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CopiarDatosObjeto())
                    {
                        int IdDis =objDisCC.GuardarDistrito(objdis) ;
                        txtCodigoDistrito.Text = IdDis.ToString();
                        MessageBox.Show("El Distrito se Grabó correctamente....", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        void ActualizarDistrito()
        {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que quiere Actualizar los Cambios del Distrito ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CopiarDatosObjeto())
                    {
                        objDisCC.ActualizarDistrito(objdis);

                        MessageBox.Show("El Distrito se Actualizó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        void EliminarDistrito()
        {
           
            try
            {
                
                if (MessageBox.Show("ESTA SEGURO DE ELIMINAR EL DISTRITO " +objdis.NomDis+ " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objDisCC.EliminarDistrito(objdis);
                    MessageBox.Show("El distrito se Elimino correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
