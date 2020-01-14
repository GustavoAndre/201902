using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Capa_Vista
{
    public partial class frmReporteDespachoProductoxMes : Form
    {
        public frmReporteDespachoProductoxMes()
        {
            InitializeComponent();
            LLenarComboAño();
        }
        void LLenarComboAño()
        {
            for (int i = 2000; i < 2030; i++)
            {
                cboAño.Items.Add(i);
            }
        }
        void MostrarReportexPedido(String vMes)
        {

            try
            {


                CrystalDecisions.Shared.ParameterValues oPvCollection = new CrystalDecisions.Shared.ParameterValues();//parametro   
                CrystalDecisions.Shared.ParameterDiscreteValue oPdv = new CrystalDecisions.Shared.ParameterDiscreteValue();//valor del parametro
                ReportDocument oRptDoc = new ReportDocument();

                oPvCollection.Clear();
                frmReportes.CR_DespachoProductoxMes rpv = new frmReportes.CR_DespachoProductoxMes();

                rpv.SetParameterValue("@Mes", vMes);
                rpv.SetParameterValue("@Año", cboAño.SelectedItem);

                crvReporteDespachoProductoxMes.ReportSource = rpv;
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

        private void BtnEnero_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("Enero");
        }

        private void BtnFebrero_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("Febrero");
        }

        private void BtnMarzo_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("Marzo");
        }

        private void BtnAbril_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("Abril");
        }

        private void BtnMayo_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("Mayo");
        }

        private void BtnJunio_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("Junio");
        }

        private void BtnJulio_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("Julio");
        }

        private void BtnAgosto_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("Agosto");
        }

        private void BtnSeptiembre_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("Septiembre");
        }

        private void BtnOctubre_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("Octubre");
        }

        private void BtnNoviembre_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("Noviembre");
        }

        private void BtnDiciembre_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("Diciembre");
        }
    }
}
