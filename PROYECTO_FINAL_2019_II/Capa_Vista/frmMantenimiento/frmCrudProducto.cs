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
    public partial class frmAgregarProducto : Form
    {
        Producto objProd = new Producto();
        CC_unidad objUnidad = new CC_unidad();
        CC_existencia objExi = new CC_existencia();
        CC_almacen objAlm = new CC_almacen();
        CC_producto objProdCC = new CC_producto();
        CC_categoria objcate = new CC_categoria();
        public frmAgregarProducto(Producto producto)
        {
            InitializeComponent();
            objProd = producto;
            mostrarDatos();
            LlenarCombos();
        }

        private void LlenarCombos()
        {
            cboCate.DataSource = objcate.ListarCategorias(0);
            cboCate.DisplayMember = "NomCat";
            cboCate.ValueMember = "IdCat";

            cboUni.DataSource = objUnidad.ListaUnidad(0);
            cboUni.DisplayMember = "nomUni";
            cboUni.ValueMember = "idUni";

            cboMer.DataSource = objExi.ListaExistencia(0);
            cboMer.DisplayMember = "nomMer";
            cboMer.ValueMember= "idMer";

            cboAlmacen.DataSource = objAlm.ListarAlmacen(0);
            cboAlmacen.DisplayMember = "nomAlm";
            cboAlmacen.ValueMember = "idAlm";
        }

        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void mostrarDatos()
        {
            if (Producto.vgb_operacion == 2 || Producto.vgb_operacion == 3)
            {
                txtCodigoProducto.Text = objProd.IdProducto.ToString();
                txtNombreProducto.Text = objProd.NombreProducto;
                txtDesc.Text = objProd.DescripcionProducto;
                cboCate.SelectedValue = objProd.IdCategoria;
                cboAlmacen.SelectedValue = objProd.IdAlm;
                txtCanxUni.Text = objProd.CantidadxUnidad.ToString();
                txtPrecioCompraProducto.Text = objProd.PrecioCompra.ToString();
                dtpFecIng.Value = objProd.FechaDeRegistro;
                txtStockProducto.Text = objProd.StockProducto.ToString();
                txtStockMin.Text = objProd.StockMinProducto.ToString();
                txtStockMaximo.Text = objProd.StockMaxProducto.ToString();
                cboUni.SelectedValue = objProd.IdUni;
                cboMer.SelectedValue = objProd.IdMer;
                chkActivo.Checked = objProd.Activo;

            }

            if (Producto.vgb_operacion == 1)
            {
                gb.Enabled = true;
                gb.Text = "NUEVO PRODUCTO";
                btnGuardar.Text = "Aceptar";
                txtNombreProducto.Focus();
            }
            else if (Producto.vgb_operacion == 2)
            {
                gb.Enabled = true;
                gb.Text = "MODIFICAR PRODUCTO";
                btnGuardar.Text = "Aceptar";
                txtNombreProducto.Focus();
            }
            else 
            {
                gb.Enabled = false;
                gb.Text = "ELIMINAR PRODUCTO";
                btnGuardar.Text = "Aceptar";
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            switch (Producto.vgb_operacion)
            {
                case 1: GuardarAdicionar(); break;
                case 2: GuardarActualizar(); break;
                case 3: Eliminar();break;
            }
        }

        void GuardarAdicionar()
        {
            try
            {
                    if (CopiarDatosObjeto())
                    {
                        int IdProd = objProdCC.GuardarProducto(objProd);
                       txtCodigoProducto.Text = IdProd.ToString();
                        MessageBox.Show("El producto "+objProd.NombreProducto+" se a insertando satisfactoriamente ","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (MessageBox.Show("¿Esta seguro de actualizar el producto : "+objProd.NombreProducto+" ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CopiarDatosObjeto())
                    {
                        objProdCC.actualizarProducto(objProd);

                        MessageBox.Show("El producto "+objProd.NombreProducto+" se Actualizó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("El Producto : "+objProd.NombreProducto+" se Elimino correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objProdCC.eliminarProducto(objProd);

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
                if (Producto.vgb_operacion == 1) objProd.IdProducto = 0;
                else objProd.IdProducto = int.Parse(txtCodigoProducto.Text);
                
                 
                objProd.NombreProducto = txtNombreProducto.Text;
                objProd.DescripcionProducto = txtDesc.Text;
                objProd.IdCategoria = int.Parse(cboCate.SelectedValue.ToString());
                objProd.IdAlm = int.Parse(cboAlmacen.SelectedValue.ToString());
                objProd.CantidadxUnidad = txtCanxUni.Text;
                objProd.PrecioCompra = decimal.Parse(txtPrecioCompraProducto.Text);
                objProd.FechaDeRegistro = dtpFecIng.Value;
                objProd.StockProducto = int.Parse(txtStockProducto.Text);
                objProd.StockMinProducto = int.Parse(txtStockMin.Text);
                objProd.StockMaxProducto = int.Parse(txtStockMaximo.Text);
                objProd.IdUni= int.Parse(cboUni.SelectedValue.ToString());
                objProd.IdMer = int.Parse(cboMer.SelectedValue.ToString());
                objProd.Activo = chkActivo.Checked ? true : false;

            }
            return ok;
        }
        private Boolean ValidarDatos()
        {
            Boolean valor = true;
            foreach (TextBox item in gb.Controls.OfType<TextBox>().OrderBy(tb => tb.TabIndex))
            {

                if (item.Text.Equals("") && !(item.Name.Equals("txtCodigoProducto"))) valor = false;
            }

            return valor;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void FrmAgregarProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
