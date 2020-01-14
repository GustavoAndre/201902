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
using Capa_Vista;
using CrystalDecisions.CrystalReports.Engine;

namespace Capa_Vista
{
    public partial class frmReporteEmpleadoxArea : Form
    {
        CC_area objListarArea = new CC_area();
        frmArea objMostrarArea = new frmArea();
        public frmReporteEmpleadoxArea()
        {
            InitializeComponent();
           
        }
        public frmReporteEmpleadoxArea(String vArea)
        {
            InitializeComponent();
            txtArea.Text = vArea;
        }

        void MostrarReportexPedido()
        {

            try
            {
                

                CrystalDecisions.Shared.ParameterValues oPvCollection = new CrystalDecisions.Shared.ParameterValues();//parametro   
                CrystalDecisions.Shared.ParameterDiscreteValue oPdv = new CrystalDecisions.Shared.ParameterDiscreteValue();//valor del parametro
                ReportDocument oRptDoc = new ReportDocument();

                oPvCollection.Clear();
                frmReportes.CR_EmpleadoxArea rpv = new frmReportes.CR_EmpleadoxArea();
                rpv.SetParameterValue("@NomAre", this.txtArea.Text);
                crvEmpleadoxArea.ReportSource = rpv;
            }
            catch (LoadSaveReportException)
            {
                MessageBox.Show("Ruta incorrecta Verifique la ruta del reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Aviso del Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido();
        }

        private void BtnBuscarAreas_Click(object sender, EventArgs e)
        {
            objMostrarArea.FormBorderStyle = FormBorderStyle.FixedSingle;
            objMostrarArea.StartPosition = FormStartPosition.CenterScreen;
            objMostrarArea.MaximizeBox = false;
            objMostrarArea.MinimizeBox = false;
            objMostrarArea.btnNuevo.Visible = false;
            objMostrarArea.btnModificar.Visible = false;
            objMostrarArea.btnEliminar.Visible = false;
            objMostrarArea.btnSalir.Visible = false;

            objMostrarArea.txtBuscar.Visible = true;
            
            objMostrarArea.dgvListarArea.Anchor = AnchorStyles.Right;
            objMostrarArea.ShowDialog();
            objListarArea.ListarArea(0);
        }
    }
}
