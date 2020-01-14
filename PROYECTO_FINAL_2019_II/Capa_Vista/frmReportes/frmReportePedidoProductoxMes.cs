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
    public partial class frmReportePedidoProductoxMes : Form
    {
        public frmReportePedidoProductoxMes()
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

                //
                oPvCollection.Clear();
                frmReportes.CR_PedidoProductoxMes rpv = new frmReportes.CR_PedidoProductoxMes();

                rpv.SetParameterValue("@Mes", vMes);
                rpv.SetParameterValue("@Año", cboAño.SelectedItem);
                crvReportePedidoProductoxMes.ReportSource = rpv;

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
        private void imgMesActual()
        {
            if (DateTime.Now.Month == 11)
            {
                
            }
        }

        private void BtnEnero_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("ENERO");
        }

        private void BtnFebrero_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("FEBRERO");
        }

        private void BtnMarzo_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("MARZO");
        }

        private void BtnAbril_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("ABRIL");
        }

        private void BtnMayo_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("MAYO");
        }

        private void BtnJunio_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("JUNIO");
        }

        private void BtnJulio_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("JULIO");
        }

        private void BtnAgosto_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("AGOSTO");
        }

        private void BtnSeptiembre_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("SEPTIEMBRE");
        }

        private void BtnOctubre_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("OCTUBRE");
        }

        private void BtnNoviembre_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("NOVIEMBRE");
        }

        private void BtnDiciembre_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido("DICIEMBRE");
        }
        
    }
}
