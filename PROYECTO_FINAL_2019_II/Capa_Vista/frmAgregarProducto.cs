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
        CC_producto objProdCC = new CC_producto();
        public frmAgregarProducto(Producto producto)
        {
            InitializeComponent();
            objProd = producto;
        }

        //public frmAgregarProducto()
        //{

        //}

        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void mostrarDatos()
        {
            if (Producto.vgb_operacion == 1)//ingresar nuevo
            {
                //gbxDatos.Enabled = true;
                this.Text = "Ingreso de Nuevo Empleado";
                btnGuardar.Text = "Grabar Nuevo";
                txtCodigoProducto.Focus();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            switch (Producto.vgb_operacion)
            {
                case 1: GuardarAdicionar(); break;
            }
        }

        void GuardarAdicionar()
        {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que quiere Guardar Nuevo Empleado!!!?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    

                    if (Producto.vgb_operacion == 1)
                    objProd.IdProducto = int.Parse(txtCodigoProducto.Text);
                    objProd.NombreProducto = txtNombreProducto.Text;
                    objProd.PrecioCompra =decimal.Parse(txtPrecioCompraProducto.Text);
                    objProd.PrecioVenta = decimal.Parse(txtPrecioVentaProducto.Text);
                    objProd.FechaDeIngreso =DateTime.Parse( txtFechaDeIngreso.Text);
                    objProd.StockProducto =int.Parse( txtStockProducto.Text);
                    
                    objProd.Activo = chkActivo.Checked ? true : false;

                    /*int newEmpId = */objProdCC.guardarProducto(objProd);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
