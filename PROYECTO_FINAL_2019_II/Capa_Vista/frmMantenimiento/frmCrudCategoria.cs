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
    public partial class frmCrudCategoria : Form
    {
        CC_categoria objCatCC = new CC_categoria();
        Categoria objCat = null;
        public frmCrudCategoria(Categoria cate)
        {
            objCat = cate;
            InitializeComponent();
            MostrarDatos();
        }

        public void MostrarDatos()
        {
            if (Categoria.vgb_operacion == 2 || Categoria.vgb_operacion == 3)
            {
                txtCodCat.Text = objCat.IdCat.ToString();
                txtNomCat.Text = objCat.NomCat.ToUpper();
                txtDesCat.Text = objCat.DesCat.ToUpper();
                chckactivo.Checked = objCat.Activo;
            }

            if (Categoria.vgb_operacion == 1)
            {
                gb.Enabled = true;
                gb.Text = "NUEVO CATEGORIA";
                btnGuardar.Text = "GUARDAR CATEGORIA";
                txtNomCat.Focus();
            }
            else if (Categoria.vgb_operacion == 2)
            {
                gb.Enabled = true;
                gb.Text = "MODIFICAR CATEGORIA";
                btnGuardar.Text = "ACTUALIZAR CATEGORIA";
                txtNomCat.Focus();
            }
            else  
            {
                gb.Enabled = false;
                gb.Text = "ELIMINAR CATEGORIA";
                btnGuardar.Text = "ELIMINAR CATEGORIA";
            }
        }

        private Boolean ValidarDatos()
        {
            Boolean valor = true;
            foreach (TextBox item in gb.Controls.OfType<TextBox>().OrderBy(tb => tb.TabIndex))
            {

                if (item.Text.Equals("") && !(item.Name.Equals("txtCodCat"))) valor = false;
            }

            return valor;
        }
        Boolean CopiarDatosObjeto()
        {
            Boolean ok = false;
            if (ValidarDatos())
            {
                ok = true;
                if (Categoria.vgb_operacion == 1) objCat.IdCat = 0;
                else objCat.IdCat = int.Parse(txtCodCat.Text);


                objCat.NomCat=txtNomCat.Text;
                objCat.DesCat = txtDesCat.Text;
                objCat.Activo = chckactivo.Checked ? true : false;

            }
            return ok;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            switch (Categoria.vgb_operacion)
            {
                case 1: GuardarCategoria(); break;
                case 2: ActualizarCategoria(); break;
                case 3: EliminarCategoria(); break;
            }
        }

        void GuardarCategoria()
        {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que quiere Guardar Nueva Categoria ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CopiarDatosObjeto())
                    {
                        int idCat = objCatCC.guardarCategoria(objCat);
                        txtCodCat.Text = idCat.ToString();
                        MessageBox.Show("Categoria se Grabó correctamente....", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        void ActualizarCategoria()
        {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que quiere Actualizar los Cambios de la Tabla Categoria ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CopiarDatosObjeto())
                    {
                        objCatCC.actualizarCategoria(objCat);

                        MessageBox.Show("Categoria se Actualizó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        void EliminarCategoria()
        {

            try
            {

                if (MessageBox.Show("ESTA SEGURO DE ELIMINAR LA CATEGORIA" + objCat.NomCat + " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objCatCC.eliminarCategoria(objCat);
                    MessageBox.Show("La categoria se Elimino correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
