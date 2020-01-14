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
using CrystalDecisions.CrystalReports.Engine;

namespace Capa_Vista
{
    public partial class frmReporteProductosxAlmacen : Form
    {
        CC_almacen objAlm = new CC_almacen();
        public frmReporteProductosxAlmacen()
        {
            InitializeComponent();
            LLenarComboCargo();
        }
        private void LLenarComboCargo()
        {
            cboAlmacen.DataSource = objAlm.ListarAlmacen(0);
            cboAlmacen.DisplayMember = "NomAlm";
            cboAlmacen.ValueMember = "IdAlm";
        }
        void MostrarReportexPedido()
        {

            try
            {
                CrystalDecisions.Shared.ParameterValues oPvCollection = new CrystalDecisions.Shared.ParameterValues();//parametro   
                CrystalDecisions.Shared.ParameterDiscreteValue oPdv = new CrystalDecisions.Shared.ParameterDiscreteValue();//valor del parametro
                ReportDocument oRptDoc = new ReportDocument();

                oPvCollection.Clear();
                frmReportes.CR_ProductoxAlmacen rpv = new frmReportes.CR_ProductoxAlmacen();
                rpv.SetParameterValue("@nomAlm", this.cboAlmacen.Text);
                crvProductoxAlmacen.ReportSource = rpv;
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

        private void BtnCrearReporte_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido();
        }
    }
}
