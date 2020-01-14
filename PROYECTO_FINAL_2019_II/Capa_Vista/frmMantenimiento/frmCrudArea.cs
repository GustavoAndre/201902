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
    public partial class frmCrudArea : Form
    {
        CC_area objAreaCC = new CC_area();
        Area objArea = null;
        public frmCrudArea(Area objarea)
        {
            objArea = objarea;
            InitializeComponent();
            MostrarDatos();
        }

        public void MostrarDatos()
        {
            if (Area.vgb_operacion == 2 || Area.vgb_operacion == 3)
            {
                txtCodAre.Text = objArea.IdArea.ToString();
                txtNomAre.Text = objArea.NomArea.ToUpper();
                chckActAre.Checked = objArea.Activo;
            }

            if (Area.vgb_operacion == 1)
            {
                gb.Enabled = true;
                gb.Text = "NUEVO AREA";
                btnAceptar.Text = "GUARDAR AREA";
                txtNomAre.Focus();
            }
            else if (Area.vgb_operacion == 2)
            {
                gb.Enabled = true;
                gb.Text = "MODIFICAR AREA";
                btnAceptar.Text = "ACTUALIZAR AREA";
                txtNomAre.Focus();
            }
            else  
            {
                gb.Enabled = false;
                gb.Text = "ELIMINAR AREA";
                btnAceptar.Text = "ELIMINAR AREA";
            }
        }
        Boolean CopiarDatosObjeto()
        {
            Boolean ok = false;
            if (ValidarDatos())
            {
                ok = true;
                if (Area.vgb_operacion == 1) objArea.IdArea = 0;
                else objArea.IdArea = int.Parse(txtCodAre.Text);


                objArea.NomArea = txtNomAre.Text;
                objArea.Activo = chckActAre.Checked ? true : false;

            }
            return ok;
        }
        private Boolean ValidarDatos()
        {
            Boolean valor = true;
            foreach (TextBox item in gb.Controls.OfType<TextBox>().OrderBy(tb => tb.TabIndex))
            {

                if (item.Text.Equals("") && !(item.Name.Equals("txtCodAre"))) valor = false;
            }

            return valor;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            switch (Area.vgb_operacion)
            {
                case 1: GuardarArea(); break;
                case 2: ActualizarArea(); break;
                case 3: EliminarArea(); break;
            }
        }

        void GuardarArea()
        {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que quiere Guardar Nueva Area ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CopiarDatosObjeto())
                    {
                        int idArea = objAreaCC.GuardarArea(objArea);
                        txtCodAre.Text = idArea.ToString();
                        MessageBox.Show("El Area se Grabó correctamente....", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        void ActualizarArea()
        {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que quiere Actualizar los Cambios de la Tabla Area ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CopiarDatosObjeto())
                    {
                        objAreaCC.ActualizarArea(objArea);

                        MessageBox.Show("El Area se Actualizó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        void EliminarArea()
        {

            try
            {

                if (MessageBox.Show("ESTA SEGURO DE ELIMINAR EL AREA" + objArea.NomArea + " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objAreaCC.EliminarArea(objArea);
                    MessageBox.Show("El area se Elimino correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
