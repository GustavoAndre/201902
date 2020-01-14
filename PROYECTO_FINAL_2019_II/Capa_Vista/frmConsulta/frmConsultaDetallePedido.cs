using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Capa_Controlador;

namespace Capa_Vista
{
    public partial class frmConsultaDetallePedido : Form
    {
        DataSet dst = null;
        CC_consultaDetallePedidos objDetPedCC = new CC_consultaDetallePedidos();
        public frmConsultaDetallePedido()
        {
            InitializeComponent();
            cargarDatos();
        }

        void cargarDatos()
        {
            dst = objDetPedCC.RetornarDataSet();
            dgConsultaDetallePedido.DataSource = dst.Tables[0].DefaultView;
        }
    }
}
