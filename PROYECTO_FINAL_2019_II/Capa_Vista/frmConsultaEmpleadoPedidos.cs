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
    public partial class frmConsultaEmpleadoPedidos : Form
    {
        public frmConsultaEmpleadoPedidos()
        {
            InitializeComponent();
            ConfigurarGrilla();
        }

        CC_consultaPedidos objConPedCC = new CC_consultaPedidos();
        private void PonerTitulo()
        {
            lvPedidos.Clear();
            lvPedidos.GridLines = true;
            lvPedidos.FullRowSelect = true;
            lvPedidos.Columns.Add("IdPedido", 70, HorizontalAlignment.Center);
            lvPedidos.Columns.Add("Empleado", 120, HorizontalAlignment.Left);
            lvPedidos.Columns.Add("Producto", 70, HorizontalAlignment.Left);
            lvPedidos.Columns.Add("Fecha Pedido", 100, HorizontalAlignment.Left);
            lvPedidos.Columns.Add("Hora Pedido", 100, HorizontalAlignment.Right);
            lvPedidos.Columns.Add("Activo", 70, HorizontalAlignment.Center);

        }

        private void LlenarDatos(SqlDataReader ddr)
        {
            PonerTitulo();
            ListViewItem xPedido = null;
            while (ddr.Read())
            {
                xPedido = new ListViewItem(ddr["IdPedido"].ToString());
                xPedido.SubItems.Add(ddr["NomEmp"].ToString());
                xPedido.SubItems.Add(ddr["IdPro"].ToString());
                xPedido.SubItems.Add(ddr["FecPed"].ToString());
                xPedido.SubItems.Add(ddr["HorPed"].ToString());
                xPedido.SubItems.Add(ddr["Activo"].ToString());
                lvPedidos.Items.Add(xPedido);
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
            trvPedidos.Nodes.Clear();


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
            SqlDataReader dr = objConPedCC.ListarEmpleados();
            Padre = new TreeNode("Empleado");
            trvPedidos.Nodes.Add(Padre);
            while (dr.Read())
            {
                Padre.Nodes.Add(dr["NomEmp"].ToString());
                Padre.Nodes[Padre.Nodes.Count - 1].Tag = dr["IdEmp"];
            }
            /*'Almacenar el Id del Vendedor en forma rápida en la propiedad tag
             * de cada nodo de Vendedor esto permite saber el id del vendedor  ya que que se
             * solo se mostrará en el treview el apellido y el nombre.*/
            #endregion
            
            
        }

        private void TrvPedidos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (trvPedidos.SelectedNode.Level == 1)
            {
                switch (trvPedidos.SelectedNode.Parent.Text)
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
                    case "Empleado":
                        this.lblmsg.Text = "Pedidos del Empleado: " + trvPedidos.SelectedNode.Text;
                        //Llamar al método para listar los pedidos en el Listview
                        LlenarDatos(objConPedCC.PedidosEmpleado(int.Parse(trvPedidos.SelectedNode.Tag.ToString())));
                        break;
                }
            }
        }
    }
}
