using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador;

namespace Capa_Vista
{
    public partial class frmConsultaProdxCate : Form
    {
        int totalfilas;
        
        CC_categoria objcate = new CC_categoria();
        CC_producto objprod = new CC_producto();
        DataTable dt = new DataTable();
         int idCat;
        public frmConsultaProdxCate()
        {
            InitializeComponent();
            ListarCate();
            
        }
        public void ListarCate()
        {

            cboCate.DataSource = objcate.ListarCategorias(0);
            cboCate.DisplayMember = "NomCat";
            cboCate.ValueMember = "IdCat";
            
        }
        private void CboCate_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmConsultaProdxCate_Load(object sender, EventArgs e)
        {
           
            
        }

        private void CboCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                

                idCat = (int)cboCate.SelectedValue;
                 dt = objprod.ConsultaProdxCat(idCat);
                dgvProdxCate.DataSource = dt;

                totalfilas = dt.Rows.Count;
                txtTotalProductos.Text = totalfilas.ToString();
                calculos();

            }
            catch (Exception )
            {
               //vacio para que no de error
            }
        }
        public void calculos()
        {
            int cont = 0;
            int totalStock = 0;
            decimal totalprecio = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                totalprecio = totalprecio + decimal.Parse(dt.Rows[i][5].ToString());
                totalStock = totalStock+ int.Parse(dt.Rows[i][7].ToString());
                if (int.Parse(dt.Rows[i][8].ToString())<=10)
                {
                    cont++;
                }
            }
            txtProdStockMin.Text = cont.ToString();
            txtTotalPrecio.Text = totalprecio.ToString();
            txtTotalStock.Text = totalStock.ToString();
        }
    }
}
