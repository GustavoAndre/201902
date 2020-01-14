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
    public partial class frmReporteEmpleadoxCargo : Form
    {
        CC_cargo objMostrarCargo = new CC_cargo();
        public frmReporteEmpleadoxCargo()
        {
            InitializeComponent();
            LLenarComboCargo();
        }

        private void LLenarComboCargo()
        {
            cboCargo.DataSource = objMostrarCargo.ListarCargo(0);
            cboCargo.DisplayMember = "NomCar";
            cboCargo.ValueMember = "IdCar";
        }
        void MostrarReportexPedido()
        {

            try
            {
               

                CrystalDecisions.Shared.ParameterValues oPvCollection = new CrystalDecisions.Shared.ParameterValues();//parametro   
                CrystalDecisions.Shared.ParameterDiscreteValue oPdv = new CrystalDecisions.Shared.ParameterDiscreteValue();//valor del parametro
                ReportDocument oRptDoc = new ReportDocument();

                oPvCollection.Clear();
                frmReportes.CR_EmpleadoxCargo rpv = new frmReportes.CR_EmpleadoxCargo();
                rpv.SetParameterValue("@NomCar", this.cboCargo.Text);
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
        private void BtnCrearReporte_Click(object sender, EventArgs e)
        {
            MostrarReportexPedido();
        }
    }
}
