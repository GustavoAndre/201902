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
    public partial class frmConsultaEmpleadoxArea : Form
    {
        CC_Empleado objemp = new CC_Empleado();
        public frmConsultaEmpleadoxArea()
        {
            InitializeComponent();
            ConfigurarGrilla();
        }
        private void PonerTitulo()
        {
            lvEmpleados.Clear();
            lvEmpleados.GridLines = true;
            lvEmpleados.FullRowSelect = true;
            lvEmpleados.Columns.Add("ID", 70, HorizontalAlignment.Center);
            lvEmpleados.Columns.Add("A. PATERNO", 100, HorizontalAlignment.Center);
            lvEmpleados.Columns.Add("A. MATERNO", 100, HorizontalAlignment.Center);
            lvEmpleados.Columns.Add("NOMBRES", 100, HorizontalAlignment.Center);
            lvEmpleados.Columns.Add("F. NACIMIENTO", 100, HorizontalAlignment.Center);
            lvEmpleados.Columns.Add("F. INGRESO", 100, HorizontalAlignment.Center);
            lvEmpleados.Columns.Add("SEXO", 100, HorizontalAlignment.Center);
            lvEmpleados.Columns.Add("TELEFONO", 120, HorizontalAlignment.Center);
            lvEmpleados.Columns.Add("CELULAR", 120, HorizontalAlignment.Center);
            lvEmpleados.Columns.Add("CORREO", 120, HorizontalAlignment.Center);
            lvEmpleados.Columns.Add("OBSERVACION", 120, HorizontalAlignment.Center);
            lvEmpleados.Columns.Add("DISTRITO", 120, HorizontalAlignment.Center);
            lvEmpleados.Columns.Add("CARGO", 120, HorizontalAlignment.Center);
            lvEmpleados.Columns.Add("AREA", 120, HorizontalAlignment.Center);
            lvEmpleados.Columns.Add("ACTIVO", 120, HorizontalAlignment.Center);

        }
        private void LlenarDatos(SqlDataReader ddr)
        {
            PonerTitulo();
            ListViewItem xEmpleado = null;
            while (ddr.Read())
            {
                xEmpleado = new ListViewItem(ddr["IdEmp"].ToString());
                xEmpleado.SubItems.Add(ddr["ApePatEmp"].ToString());
                xEmpleado.SubItems.Add(ddr["ApeMatEmp"].ToString());
                xEmpleado.SubItems.Add(ddr["NomEmp"].ToString());
                xEmpleado.SubItems.Add(ddr["FecNacEmp"].ToString());
                xEmpleado.SubItems.Add(ddr["FecIngEmp"].ToString());
                xEmpleado.SubItems.Add(ddr["SexEmp"].ToString());
                xEmpleado.SubItems.Add(ddr["TelEmp"].ToString());
                xEmpleado.SubItems.Add(ddr["CelEmp"].ToString());
                xEmpleado.SubItems.Add(ddr["CorEmp"].ToString());
                xEmpleado.SubItems.Add(ddr["ObsEmp"].ToString());
                xEmpleado.SubItems.Add(ddr["IdDis"].ToString());
                xEmpleado.SubItems.Add(ddr["IdCar"].ToString());
                xEmpleado.SubItems.Add(ddr["IdAre"].ToString());
                xEmpleado.SubItems.Add(ddr["Activo"].ToString());
                lvEmpleados.Items.Add(xEmpleado);
            }
        }
        private void ConfigurarGrilla()
        {
            /*Estas instrucciones llenan el contenido del control Treview con Países, Vendedores y Años para construir
            los nodos que se mostraran dentro del control*/
            TreeNode Padre = null;
            //Poner Formato al Control Listview
            PonerTitulo();
            //Limpiar el Treview
            trvAreas.Nodes.Clear();


            //Agregar los paises al nodo País
            #region
            //SqlDataReader dr = objConPedCC.ListarPaises();
            //Padre = new TreeNode("Países");
            //TrvPedidos.Nodes.Add(Padre);

            //Agregamos al nodo paises los paises    
            //while (dr.Read())
            //{
            //    Padre.Nodes.Add(dr["PaísDestinatario"].ToString());
            //}
            #endregion
            //Agregar los Empleados al nodo Vendedores
            #region
            SqlDataReader dr = objemp.ListarAreas();
            Padre = new TreeNode("Area");
            trvAreas.Nodes.Add(Padre);
            while (dr.Read())
            {
                Padre.Nodes.Add(dr["NomAre"].ToString());
                Padre.Nodes[Padre.Nodes.Count - 1].Tag = dr["IdAre"];
            }
            /*'Almacenar el Id del Vendedor en forma rápida en la propiedad tag
             * de cada nodo de Vendedor esto permite saber el id del vendedor  ya que que se
             * solo se mostrará en el treview el apellido y el nombre.*/
            #endregion


        }

        private void TrvAreas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (trvAreas.SelectedNode.Level == 1)
            {
                switch (trvAreas.SelectedNode.Parent.Text)
                {
                    //case "Países":
                    //    this.lblmsg.Text = "Pedidos del País de: " + trvPedidos.SelectedNode.Text;
                    //    //Llamar al método para listar los pedidos en el Listview
                    //    LlenarDatos(objMgr.Pedidos_Pais(trvPedidos.SelectedNode.Text));
                    //    break;
                    //case "Años":
                    //    this.lblmsg.Text = "Pedidos del Año: " + trvPedidos.SelectedNode.Text;
                    //    //Llamar al método para listar los pedidos en el Listview
                    //    LlenarDatos(objMgr.Pedidos_Año(int.Parse(trvPedidos.SelectedNode.Text)));
                    //    break;
                    case "Area":
                        this.lblmsg.Text = "EMPLEADOS DEL AREA DE :    " + trvAreas.SelectedNode.Text;
                        //Llamar al método para listar los pedidos en el Listview
                        LlenarDatos(objemp.EmpleadosxArea(int.Parse(trvAreas.SelectedNode.Tag.ToString())));
                        break;
                }
            }
        }
    }
}
