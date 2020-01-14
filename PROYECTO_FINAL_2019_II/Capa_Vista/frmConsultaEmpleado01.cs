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
    public partial class frmConsultaEmpleado01 : Form
    {
        CC_Empleado objBusEmpleado = new CC_Empleado();
        public frmConsultaEmpleado01()
        {
            InitializeComponent();
        }

        void ListarEmpleados()
        {
            
        }

        private void TxtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            SqlDataReader dr = objBusEmpleado.BuscarEmpleado(txtBuscarEmpleado.Text);
            lstEmpleados.Items.Clear();
            dgBuscarEmpleado.DataSource = null;
            while (dr.Read())
            {
                lstEmpleados.Items.Add(dr[0].ToString());
                dgBuscarEmpleado.DataSource = dr[0];
            }
        }
    }
}
