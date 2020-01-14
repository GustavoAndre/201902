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
using Capa_Entidad;

namespace Capa_Vista
{   //Mi segundo commit
    public partial class frmAcceso : Form
    {
        int contador;
        Usuario objUsu = new Usuario();

        

        CC_validarUsuario CC_ValidarUsuario = new CC_validarUsuario();
        
        public frmAcceso()
        {
            InitializeComponent();
        }

        private void ChckMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chckMostrarContraseña.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void FrmAcceso_Load(object sender, EventArgs e)
        {
            //CConexion objCCon = new CConexion();
            //txtusuario.Focus();
            //if (objCCon.FConexion())
            //{
            //    //MessageBox.Show("Conexion Correcta");
            //}
            //else
            //{
            //    MessageBox.Show("Conexion Incorecta");
            //}
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            objUsu.usuario = txtUsuario.Text;
            objUsu.contraseña = txtContraseña.Text;

            
            

            //bool ingresa = false;

            //do
            //{

            //    if (CC_ValidarUsuario.validarUsuario(objUsu))
            //    {
            //        //MessageBox.Show("Bienvenido" + objUsu.usuario, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        ingresa = true;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Usuario y/o Contraseña incorrecta");
            //        contador ++;
            //    }
            //} while ((contador < 3) && (ingresa == false));



            //if(ingresa == false)
            //{
            //    frmAcceso.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Bienvenido" + objUsu.usuario, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            DataTable dt = CC_ValidarUsuario.validarUsuario(objUsu);
            if (dt !=null)
            {
                string nombre = dt.Rows[0][3].ToString();
                string cargo = dt.Rows[0][4].ToString();
                frmMenu frmmenu = new frmMenu(nombre,cargo);
                MessageBox.Show("Bienvenido Usuario : " + nombre, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmmenu.Show();

                //ingresa = true;
            }
            else if(contador == 2)
            {
                MessageBox.Show("Espere 30 segundos para volver a intentarlo");
                
                this.Close();
               
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrecta", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarControles();
                contador++;
            }
        }

        private void LimpiarControles()
        {
            txtContraseña.Clear();
            txtUsuario.Clear();
        }

        private void frmAcceso_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
