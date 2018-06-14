using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace sercor
{
    public partial class login : Form
    {
        //Variables posición de formulario
        //int posY = 0, posX = 0; 

        private void pnHead_MouseMove(object sender, MouseEventArgs e)
        {
            ////if (e.Button != MouseButtons.Left)
            ////{
            ////    pnHead.Cursor = Cursors.Default;
            ////    posX = e.X;
            ////    posY = e.Y;
            ////}
            ////else
            ////{
            ////    Left = Left + (e.X - posX);
            ////    Top = Top + (e.Y - posY);
            ////    pnHead.Cursor = Cursors.SizeAll;
            ////}
        }

        //CONEXION DE CARGA
        private void Conectar()
        {
            try
            {
                //conexión sercordb
                bdComun.obtenerConexion();

                lblStatus.Text = "Conectado a sercorDB";
                lblIndiactor.ForeColor = Color.Lime;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Error en conexión", "Sercor", MessageBoxButtons.OK);

                lblStatus.Text = "Desconectado";
                lblIndiactor.ForeColor = Color.OrangeRed;
                txtPsw.Enabled = false;
                txtUser.Enabled = false;
                btnlogin.Enabled = false;
            }
        }

        public login()
        {
            InitializeComponent();

            Conectar();

            btnlogin.Focus();
        }



        public Usuario UsuarioSeleccionado { get; set; }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("No ha ingresado un usuario", "Sercor", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtUser.Focus();
            }
            else if (txtPsw.Text=="") 
            {
                MessageBox.Show("No ha ingresado su contraseña", "Sercor", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtPsw.Focus();
            }
            else
            {
                UsuarioSeleccionado = UsuarioDBM.ObtenerUsuario(txtUser.Text);
                if (UsuarioSeleccionado!=null)
                {
                    string passHashed = UsuarioSeleccionado.CONTRASENA;

                    string passUnhash = Hash.sha256(txtPsw.Text);
                    if (passHashed==passUnhash)
                    {
                        //MessageBox.Show(nombreUser, "");
                        //pasar aquí el nivel de usuario

                        FormInstance.mainWindow(UsuarioSeleccionado);
                    }
                }
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //FORZAR RECONEXION
        private void lblStatus_Click(object sender, EventArgs e)
        {
            Conectar();
        }
    }
}
