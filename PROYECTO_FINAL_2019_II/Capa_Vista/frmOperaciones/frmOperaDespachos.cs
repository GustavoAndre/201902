using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_Procesos_FrmOperaciones_2019II;

namespace Capa_Vista
{
    public partial class frmOperaDespachos : Form
    {
        private DataTable Dtb = new DataTable();
        private DataRow Drw = null;
        private DataSet Dst = new DataSet();
        private short fila;
        private int stockActual;
        private decimal total;
        private int unidades;
        private bool activo = true;
        private TransaccionCompras objDes = new TransaccionCompras();
        public frmOperaDespachos()
        {
            InitializeComponent();
            LlenarListas();
            ConfigurarDataGrid();
            NuevoDespacho();
            txtNombreProducto.Text = "";
        }
        private void LlenarListas()
        {
            cboIdEmp.DataSource = objDes.getListas().Tables["tEmpleados"];
            cboIdEmp.DisplayMember = "NomEmp";
            cboIdEmp.ValueMember = "IdEmp";

            //cboIdProd.DataSource = objDes.getListas().Tables["tProductos"];
            //cboIdProd.DisplayMember = "NomPro";
            //cboIdProd.ValueMember = "IdPro";

            cboTipoDocumento.DataSource = objDes.getListas().Tables["tTipoDocumento"];
            cboTipoDocumento.DisplayMember = "nomDoc";
            cboTipoDocumento.ValueMember = "idDoc";

            cboTipoOperacion.DataSource = objDes.getListas().Tables["tTipoOperacion"];
            cboTipoOperacion.DisplayMember = "nomOpe";
            cboTipoOperacion.ValueMember = "idOpe";

            dgDespachos.DataSource = objDes.getDespachos();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboIdProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        void ConfigurarDataGrid()
        {

            Dtb = Dst.Tables.Add();
            /*Luego Agregamos las columnas a la colleción columns del datatable virtual */
            Dtb.Columns.Add("Código", System.Type.GetType("System.Int32"));
            Dtb.Columns.Add("Producto", System.Type.GetType("System.String"));
            Dtb.Columns.Add("Precio", System.Type.GetType("System.Decimal"));
            Dtb.Columns.Add("Cantidad", System.Type.GetType("System.Int32"));
            Dtb.Columns.Add("Importe", System.Type.GetType("System.Decimal"));
            Dtb.Columns.Add("I.G.V.", System.Type.GetType("System.Double"));
            Dtb.Columns.Add("IMPORTE TOTAL", System.Type.GetType("System.Decimal"));
            Dtb.Columns.Add("Tipo de existencia", System.Type.GetType("System.String"));
            Dtb.Columns.Add("Tipo de unidad", System.Type.GetType("System.String"));
            Dtb.Columns.Add("Activo", System.Type.GetType("System.Boolean"));
            /*Ahora se enlaza el objeto DataTable con el control DataGrid*/
            dgDetalleDespachos.DataSource = Dtb;
        }
        private void NuevoDespacho()
        {
            //Limpiar controles
            foreach (Control xCtrl in groupBox1.Controls)
            {
                //if (xCtrl.GetType() == typeof(TextBox) || xCtrl.GetType() == typeof(ComboBox))
                //    xCtrl.Text = "";
                if (xCtrl is TextBox || xCtrl is ComboBox)
                {
                    xCtrl.Text = "";
                }
            }
            txtFechaDespacho.Text = DateTime.Now.ToShortDateString();
            Dtb.Rows.Clear();
            //txtuni.Clear();
            //txttotal.Clear();
            total = 0;
            unidades = 0;
            fila = -1;
        }

        private void BtnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (Decimal.Parse(txtPrecioTotal.Text) > 0)
            {
                //Instanciar el objeto DataRow
                Drw = Dtb.NewRow();
                Drw[0] = txtCodigoProducto.Text;
                Drw[1] = txtNombreProducto.Text;
                Drw[2] = decimal.Parse(txtPrecio.Text);
                Drw[3] = mudCantidad.Value;
                Drw[4] = decimal.Parse(txtPrecioTotal.Text);
                Drw[5] = decimal.Parse(txtIGV.Text);
                Drw[6] = decimal.Parse(txtMontoNeto.Text);
                Drw[7] = txtTipoExistencia.Text;
                Drw[8] = txtUnidadMedida.Text;
                Drw[9] = Boolean.Parse(activo.ToString());

                //Esta fila que es se la clase DataRow la agregamos a la collección Rows
                //del DataTable Dtb
                Dtb.Rows.Add(Drw);
                /*como el copntrol DataGrid se encuentra enlazado con el DatTable
                 estos datos agregados por la nueva fila se visualizan automaticamente
                 en la Grilla*/
                total += decimal.Parse(txtPrecioTotal.Text);
                unidades += int.Parse(mudCantidad.Value.ToString());
                txtMontoTotal.Text = total.ToString("#,##0.00");
                txtUnidadesPedido.Text = unidades.ToString();
                txtCodigoProducto.Clear();
                txtPrecio.Clear();
                mudCantidad.Value = 0;
                txtPrecioTotal.Text = "0.00";
                txtTipoExistencia.Clear();
                txtUnidadMedida.Clear();
                txtNombreProducto.Clear();
                txtCodigoProducto.Text = "";
                txtCodigoProducto.Focus();

            }
            else
            {
                MessageBox.Show("Falta Ingresar datos obligatorios en el Detalle", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (mudCantidad.Value > 0)
            {
                int kantidad = int.Parse(mudCantidad.Value.ToString());
                if (kantidad > stockActual)
                {
                    MessageBox.Show(this, "Solo Queda: " + stockActual.ToString() + "Unidades...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    mudCantidad.Value = 0;
                    txtPrecioTotal.Text = "";
                    mudCantidad.Focus();
                }
                else
                    txtPrecioTotal.Text = (decimal.Parse(txtPrecio.Text) * mudCantidad.Value).ToString("#,##0.00");
                    txtIGV.Text = (double.Parse(txtPrecioTotal.Text) * 0.18).ToString("#,##0.00");
                    txtMontoNeto.Text = (decimal.Parse(txtPrecioTotal.Text) + decimal.Parse(txtIGV.Text)).ToString("#,##0.00");
            }
            else
                txtPrecioTotal.Text = "0.00";
        }

        private void BtnRegistrarDespacho_Click(object sender, EventArgs e)
        {
            try
            {
                int nfilas = Dtb.Rows.Count;
                int CodiPro;
                decimal PreUni;
                short cantidad;
                bool Aactivo;
                if (nfilas > 0)
                {//Se deberá grabar el pedido
                    txtcodDespacho.Text = objDes.setDespacho
                        (int.Parse(cboIdEmp.SelectedValue.ToString()), DateTime.Parse(txtFechaDespacho.Text),
                        int.Parse(cboTipoDocumento.SelectedValue.ToString()),
                        int.Parse(cboTipoOperacion.SelectedValue.ToString()),
                        activo).ToString();
                    //Aqui Grabar el detalle del Pedido
                    for (int i = 0; i < nfilas; i++)
                    {
                        CodiPro = int.Parse(dgDetalleDespachos[i, 0].ToString());
                        PreUni = decimal.Parse(dgDetalleDespachos[i, 2].ToString());
                        cantidad = short.Parse(dgDetalleDespachos[i, 3].ToString());
                        Aactivo = Boolean.Parse(dgDetalleDespachos[i, 9].ToString());
                        //Aqui grabamos cada fila a a la tabla deTallePedido
                        objDes.setDetalleDespacho(int.Parse(txtcodDespacho.Text), CodiPro, PreUni, cantidad, Aactivo);
                        //Actuqalizamos el producto en la tabla Productos
                        objDes.SetActualizarProductoDespachos(CodiPro, cantidad);
                    }
                    MessageBox.Show(this, "DESPACHO N° " + txtcodDespacho.Text + " REGISTRADO CORRECTAMENTE", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgDespachos.DataSource = objDes.getDespachos();
                }
                else
                {
                    MessageBox.Show(this, "NO HAY FILAS EN EL DETALLE DE DESPACHO", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {

                throw new Exception("Error:" + ex.Message);
            }
        }

        private void BtnEliminarDetalle_Click(object sender, EventArgs e)
        {
            //Determina que fila de la grilla esta selecionada para ser eliminada
            fila = short.Parse(dgDetalleDespachos.CurrentCell.RowNumber.ToString());
            if (fila > -1 && Dtb.Rows.Count > 0)
            {
                total -= decimal.Parse(dgDetalleDespachos[fila, 4].ToString());
                unidades -= int.Parse(dgDetalleDespachos[fila, 3].ToString());
                txtMontoTotal.Text = total.ToString("#,##0.00");
                txtUnidadesPedido.Text = unidades.ToString();
                Dtb.Rows.RemoveAt(fila);
            }
        }

        private void BtnNuevoDespacho_Click(object sender, EventArgs e)
        {
            NuevoDespacho();
        }

        private void TxtCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DataTable tablita = objDes.getProducto(int.Parse(txtCodigoProducto.Text));

                txtNombreProducto.Text = tablita.Rows[0][1].ToString();
                txtPrecio.Text = tablita.Rows[0][5].ToString();
                txtStock.Text = tablita.Rows[0][7].ToString();
                txtStockMin.Text = tablita.Rows[0][8].ToString();
                txtUnidadMedida.Text = tablita.Rows[0][10].ToString();
                txtTipoExistencia.Text = tablita.Rows[0][12].ToString();
                

                stockActual = int.Parse(txtStock.Text);
                mudCantidad.Value = 0;
                txtPrecioTotal.Text = "0.00";
                mudCantidad.Focus();

            }
            catch (Exception)
            {

                //Dejar Vacio para evitar el error al inicio de llenarListas 
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            txtFechaDespacho.Enabled = true;
            txtFechaDespacho.Clear();
            txtFechaDespacho.Focus();
            
        }

        private void BtnImprimirDespacho_Click(object sender, EventArgs e)
        {
            frmImprimirPedido_Despacho objimp = new frmImprimirPedido_Despacho(0,int.Parse(txtcodDespacho.Text));
            objimp.ShowDialog();
        }
    }
}
