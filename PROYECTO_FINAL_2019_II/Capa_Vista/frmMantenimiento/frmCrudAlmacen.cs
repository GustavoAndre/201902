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
using Capa_Controlador;
using System.Data.SqlClient;

namespace Capa_Vista
{
    public partial class frmCrudAlmacen : Form
    {
        Almacen objAlm = new Almacen();
        CC_almacen objAlmCC = new CC_almacen();
        public frmCrudAlmacen(Almacen objAlm)
        {
            this.objAlm = objAlm;
            InitializeComponent();
            mostrarDatos();
        }
        private void mostrarDatos()
        {
            if (Almacen.vgb_operacion == 2 || Almacen.vgb_operacion == 3)
            {
                txtIdAlmacen.Text = objAlm.IdAlm.ToString();
                txtNombreAlmacen.Text = objAlm.NomAlm;
                txtDescripcionAlmacen.Text= objAlm.DesAlm;
                txtUbicacionAlmacen.Text = objAlm.UbiAlm;
                chkActivo.Checked = objAlm.Activo;

            }

            if (Almacen.vgb_operacion == 1)
            {
                gb.Enabled = true;
                gb.Text = "NUEVO ALMACEN";
                btnAceptar.Text = "Aceptar";
                txtNombreAlmacen.Focus();
            }
            else if (Almacen.vgb_operacion == 2)
            {
                gb.Enabled = true;
                gb.Text = "MODIFICAR ALMACEN";
                btnAceptar.Text = "Aceptar";
                txtNombreAlmacen.Focus();
            }
            else
            {
                gb.Enabled = false;
                gb.Text = "ELIMINAR ALMACEN";
                btnAceptar.Text = "Aceptar";
            }
        }
        void GuardarAdicionar()
        {
            try
            {
                if (CopiarDatosObjeto())
                {
                    int IdAlm= objAlmCC.GuardarAlmacen(objAlm);
                    txtIdAlmacen.Text = IdAlm.ToString();
                    MessageBox.Show("El ALMACEN " + objAlm.NomAlm + " se a insertando satisfactoriamente ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (MessageBox.Show("¿Esta seguro de actualizar el almacen : " + objAlm.NomAlm + " ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CopiarDatosObjeto())
                    {
                        objAlmCC.ActualizarAlmacen(objAlm);

                        MessageBox.Show("El almacen " + objAlm.NomAlm + " se Actualizó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                MessageBox.Show("El almacen : " + objAlm.NomAlm + " se Elimino correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objAlmCC.EliminarAlmacen(objAlm);

            }
            catch (Exception)
            {

                throw;
            }

        }
        Boolean CopiarDatosObjeto()
        {
            bool ok = false;
            if (ValidarDatos())
            {
                ok = true;
                if (Almacen.vgb_operacion == 1) objAlm.IdAlm = 0;
                else objAlm.IdAlm = int.Parse(txtIdAlmacen.Text);

                objAlm.NomAlm = txtNombreAlmacen.Text;
                objAlm.DesAlm = txtDescripcionAlmacen.Text;
                objAlm.UbiAlm = txtUbicacionAlmacen.Text;
                objAlm.Activo = chkActivo.Checked ? true : false;

            }
            return ok;
        }
        private Boolean ValidarDatos()
        {
            Boolean valor = true;
            foreach (TextBox item in gb.Controls.OfType<TextBox>().OrderBy(tb => tb.TabIndex))
            {

                if (item.Text.Equals("") && !(item.Name.Equals("txtIdAlmacen"))) valor = false;
            }

            return valor;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            switch (Almacen.vgb_operacion)
            {
                case 1: GuardarAdicionar(); break;
                case 2: GuardarActualizar(); break;
                case 3: Eliminar(); break;
            }
        }
    }
}
