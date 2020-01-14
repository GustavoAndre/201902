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
using Capa_Entidad;

namespace Capa_Vista
{
    public partial class frmCategoria : Form
    {
        CC_categoria objCatCC = new CC_categoria();
        Categoria objCat = new Categoria();
        public int FilaActual;
        public frmCategoria()
        {
            InitializeComponent();
            ListarCategorias();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {

        }

        private void ListarCategorias()
        {
            dgvListarCategoria.DataSource = objCatCC.ListarCategorias(0);
        }

        private void CapturaDatos(int var)
        {
            Categoria.vgb_operacion = var;
            FilaActual = dgvListarCategoria.CurrentCell.RowIndex;

            objCat.IdCat =(int)dgvListarCategoria.Rows[FilaActual].Cells[0].Value;
            objCat.NomCat = (String)dgvListarCategoria.Rows[FilaActual].Cells[1].Value;
            objCat.DesCat = (string)dgvListarCategoria.Rows[FilaActual].Cells[2].Value;
            objCat.Activo =(bool) dgvListarCategoria.Rows[FilaActual].Cells[3].Value;

            frmCrudCategoria frmCrudCat = new frmCrudCategoria(objCat);
            frmCrudCat.FormClosed += new FormClosedEventHandler(of_FormClosed);
            frmCrudCat.StartPosition = FormStartPosition.CenterScreen;
            frmCrudCat.ShowDialog();
        }
        private void of_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListarCategorias();
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            CapturaDatos(1);
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CapturaDatos(2);

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            CapturaDatos(3);

        }
    }
}
