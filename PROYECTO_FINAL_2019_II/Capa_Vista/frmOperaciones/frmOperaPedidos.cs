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

namespace Capa_Vista.frmOperaciones
{
    public partial class frmOperaPedidos : Form
    {
        
        private DataTable Dtb = new DataTable();
        private DataRow Drw = null;
        private DataSet Dst = new DataSet();
        private int stock;
        private decimal total;
        private int unidades;
        private short fila;
        private bool activo = true;
        public int idMer;
        public int idUni;
        public double totalIGV;
        public double igv;
        private TransaccionCompras objPedido = new TransaccionCompras();
        
        public frmOperaPedidos()
        {
            InitializeComponent();
            LlenarDatosControles();
            ConfigurarTabla();
            NuevoPedido();
            txtCodigoProducto.Text = "";
        }

        private void LlenarDatosControles()
        {
            cboIdEmp.DataSource = objPedido.getListas().Tables["tEmpleados"];
            cboIdEmp.DisplayMember = "ApePatEmp";
            cboIdEmp.ValueMember = "IdEmp";

            cboIdProveedor.DataSource = objPedido.getListas().Tables["tProveedores"];
            cboIdProveedor.DisplayMember = "NomCom";
            cboIdProveedor.ValueMember = "IdProv";


            //cboIdProd.DataSource = objPedido.getListas().Tables["tProductos"];
            //cboIdProd.DisplayMember = "NomPro";
            //cboIdProd.ValueMember = "IdPro";

            //cboIdExistencia.DataSource = objPedido.getListas().Tables["tTipoExistencia"];
            //cboIdExistencia.DisplayMember = "nomMer";
            //cboIdExistencia.ValueMember = "idMer";

            //cboIdUnidad.DataSource = objPedido.getListas().Tables["tUnidadMedida"];
            //cboIdUnidad.DisplayMember = "nomUni";
            //cboIdUnidad.ValueMember = "idUni";

            cboTipoDocumento.DataSource = objPedido.getListas().Tables["tTipoDocumento"];
            cboTipoDocumento.DisplayMember = "nomDoc";
            cboTipoDocumento.ValueMember = "idDoc";

            cboTipoOperacion.DataSource = objPedido.getListas().Tables["tTipoOperacion"];
            cboTipoOperacion.DisplayMember = "nomOpe";
            cboTipoOperacion.ValueMember = "idOpe";

            dgpedidos.DataSource = objPedido.getPedidos();

        }
        void ConfigurarTabla()
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
            dgDetalle.DataSource = Dtb;
        }
        private void NuevoPedido()
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
            txtFecPed.Text = DateTime.Now.ToShortDateString();
            Dtb.Rows.Clear();
            //txtuni.Clear();
            //txttotal.Clear();
            total = 0;
            unidades = 0;
            stock = 0;
            fila = -1;
        }
        private void MudCantidad_ValueChanged(object sender, EventArgs e)
        {
            //CANTIDAD DE ENTRADA DE PRODUCTO,NO PUEDE INGRESAR MAS DE LA CANTIDAD MAXIMA ESTABLECIDA
            if (mudCantidad.Value > 0)
            {
                int kantidad = int.Parse(mudCantidad.Value.ToString());
                int Smaximo = int.Parse(txtStockMaximo.Text) - int.Parse(txtStockActual.Text);
                if (kantidad > Smaximo)
                {
                    MessageBox.Show(this, "EL STOCK MAXIMO ES: " + txtStockMaximo.Text + "UNIDADES", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    mudCantidad.Value = 0;
                    txtPrecioTotal.Text = "";
                    txtIGV.Clear();
                    txtMontoNeto.Clear();
                    mudCantidad.Focus();
                }
                else
                {
                    txtPrecioTotal.Text = (decimal.Parse(txtPrecio.Text) * mudCantidad.Value).ToString("#,##0.00");
                    txtIGV.Text = (double.Parse(txtPrecioTotal.Text) * 0.18).ToString("#,##0.00");
                    txtMontoNeto.Text = (decimal.Parse(txtPrecioTotal.Text) + decimal.Parse( txtIGV.Text)).ToString("#,##0.00");
                }
                    
            }
            else
                txtPrecioTotal.Text = "0.00";
        }
        private void CboIdProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
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

                //if (Drw[0])
                //{

                //}
                //idMer = int.Parse( cboIdExistencia.SelectedValue.ToString());
                //idUni = int.Parse(cboIdUnidad.SelectedValue.ToString());
                //Esta fila que es se la clase DataRow la agregamos a la collección Rows
                //del DataTable Dtb
                Dtb.Rows.Add(Drw);
                /*como el copntrol DataGrid se encuentra enlazado con el DatTable
                 estos datos agregados por la nueva fila se visualizan automaticamente
                 en la Grilla*/
                total += decimal.Parse(txtPrecioTotal.Text);
                unidades += int.Parse(mudCantidad.Value.ToString());
                totalIGV += double.Parse(Drw[5].ToString());
                txtMontoTotal.Text = total.ToString("#,##0.00");
                txtUnidadesPedido.Text = unidades.ToString();
                txtTotalIGV.Text = totalIGV.ToString();
                txtCodigoProducto.Clear();
                txtPrecio.Clear();
                mudCantidad.Value = 0;
                txtPrecioTotal.Text = "0.00";
                txtIGV.Text= "0.00";
                txtMontoNeto.Text = "0.00";
                txtTipoExistencia.Text = "";
                txtUnidadMedida.Text = "";
                txtStockMaximo.Clear();
                txtStockActual.Clear();
                txtNombreProducto.Clear();
                txtCodigoProducto.Text = "";
                txtCodigoProducto.Focus();

            }
            else
            {
                MessageBox.Show("Falta Ingresar datos obligatorios en el Detalle", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegistrarPedido_Click(object sender, EventArgs e)
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
                    txtCodPed.Text = objPedido.setPedido
                        (int.Parse(cboIdProveedor.SelectedValue.ToString()),
                        int.Parse(cboIdEmp.SelectedValue.ToString()), DateTime.Parse(txtFecPed.Text),
                        int.Parse(cboTipoDocumento.SelectedValue.ToString()),
                        int.Parse(cboTipoOperacion.SelectedValue.ToString()),
                        activo).ToString();
                    //Aqui Grabar el detalle del Pedido
                    for (int i = 0; i < nfilas; i++)
                    {
                        CodiPro = int.Parse(dgDetalle[i, 0].ToString());
                        PreUni = decimal.Parse(dgDetalle[i, 2].ToString());
                        cantidad = short.Parse(dgDetalle[i, 3].ToString());
                        Aactivo = Boolean.Parse(dgDetalle[i,9].ToString());
                        //Aqui grabamos cada fila a a la tabla deTallePedido
                        objPedido.setDetalle(int.Parse(txtCodPed.Text), CodiPro, PreUni, cantidad,Aactivo);
                        //Actuqalizamos el producto en la tabla Productos
                        objPedido.SetActualizarProductoPedidos(CodiPro, cantidad);
                    }
                    //dgDetalle.DataSource = null;
                    Dtb.Clear();
                    MessageBox.Show(this, "PEDIDO N° "+txtCodPed.Text+" AGREGADO CORRECTAMENTE", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgpedidos.DataSource = objPedido.getPedidos();
                   
                }
                else
                {
                    MessageBox.Show(this, "No Hay Filas en el Detalle del pedido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Error:" + ex.Message);
            }
        }

        private void BtnNuevoPedido_Click(object sender, EventArgs e)
        {
            NuevoPedido();
        }

        private void BtnEliminarDetalle_Click(object sender, EventArgs e)
        {
            //Determina que fila de la grilla esta selecionada para ser eliminada
            fila = short.Parse(dgDetalle.CurrentCell.RowNumber.ToString());
            if (fila > -1 && Dtb.Rows.Count > 0)
            {
                total -= decimal.Parse(dgDetalle[fila, 4].ToString());
                unidades -= int.Parse(dgDetalle[fila, 3].ToString());
                txtMontoTotal.Text = total.ToString("#,##0.00");
                txtUnidadesPedido.Text = unidades.ToString();
                Dtb.Rows.RemoveAt(fila);
            }
        }

        private void CboIdProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmOperaPedidos_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Crear una tablita para los datos del producto seleccionado para el detalle
                DataTable tablita = objPedido.getProducto(int.Parse(txtCodigoProducto.Text));
                /*Pasamos el IdProducto al método
                 * Aqui tablita tendrá una sola fila con los datos del Producto
                 * estos se copiaran en los controles del groupBox Detalle
                 */
                txtNombreProducto.Text = tablita.Rows[0][1].ToString();
                txtPrecio.Text = tablita.Rows[0][5].ToString();
                txtStockActual.Text = tablita.Rows[0][7].ToString();
                txtStockMaximo.Text = tablita.Rows[0][9].ToString();
                txtUnidadMedida.Text = tablita.Rows[0][10].ToString();
                txtTipoExistencia.Text = tablita.Rows[0][12].ToString();
                mudCantidad.Value = 0;
                txtPrecioTotal.Text = "0.00";
                mudCantidad.Focus();

            }
            catch (Exception)
            {

                //Dejar Vacio para evitar el error al inicio de llenarListas 
            }
        }

        private void BtnImprimirPedido_Click(object sender, EventArgs e)
        {
            frmImprimirPedido_Despacho objimp = new frmImprimirPedido_Despacho(1,int.Parse(txtCodPed.Text));
            objimp.ShowDialog();
        }
    }
}
