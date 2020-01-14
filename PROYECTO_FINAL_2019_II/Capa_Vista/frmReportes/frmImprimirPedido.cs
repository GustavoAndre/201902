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
    public partial class frmImprimirPedido_Despacho : Form
    {
        public frmImprimirPedido_Despacho(int IdOpe,int Id)
        {
            InitializeComponent();
            MostrarReportexPedido(IdOpe,Id);
        }
        void MostrarReportexPedido(int idOpe,int id)
        {
            if(idOpe == 0)
            {
                try
                {
                    CrystalDecisions.Shared.ParameterValues oPvCollection = new CrystalDecisions.Shared.ParameterValues();//parametro   
                    CrystalDecisions.Shared.ParameterDiscreteValue oPdv = new CrystalDecisions.Shared.ParameterDiscreteValue();//valor del parametro
                    ReportDocument oRptDoc = new ReportDocument();
                    //
                    oPvCollection.Clear();
                    frmReportes.CR_ImprimirDespacho rpv = new frmReportes.CR_ImprimirDespacho();
                    rpv.SetParameterValue("@id", id);
                    crvImprimirPedidoDespacho.ReportSource = rpv;
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
            else
            {
                try
                {
                    CrystalDecisions.Shared.ParameterValues oPvCollection = new CrystalDecisions.Shared.ParameterValues();//parametro   
                    CrystalDecisions.Shared.ParameterDiscreteValue oPdv = new CrystalDecisions.Shared.ParameterDiscreteValue();//valor del parametro
                    ReportDocument oRptDoc = new ReportDocument();
                    //
                    oPvCollection.Clear();
                    frmReportes.CR_ImprimirPedido rpv = new frmReportes.CR_ImprimirPedido();
                    rpv.SetParameterValue("@id", id);
                    crvImprimirPedidoDespacho.ReportSource = rpv;
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
        }
    }
}
