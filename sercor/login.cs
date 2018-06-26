using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sercor
{
    public partial class login : Form
    {
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if ((keyData != Keys.Enter) & (keyData != Keys.F2))
                return base.ProcessCmdKey(ref msg, keyData);

            if (keyData == Keys.Enter)
            {
                loginVoid();
                limpiar();
            }

            if (keyData == Keys.F2)
            {
                //aqui la accion del F2
            }

            return true;
        }

        //CONEXION DE CARGA
        private void Conectar()
        {
            try
            {
                //conexión sercordb
                MySqlConnection conexion=bdComun.obtenerConexion();
                lblStatus.Text = "Conectado a sercorDB";
                lblStatus.ForeColor = Color.DarkGreen;

                ptcStatus.BackgroundImage = sercor.Properties.Resources.success16;
                conexion.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                lblStatus.Text = "Desconectado";
                lblStatus.ForeColor = Color.Maroon;

                txtPsw.Enabled = false;
                txtUser.Enabled = false;
                btnlogin.Enabled = false;

                ptcStatus.BackgroundImage = sercor.Properties.Resources.error16;
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
            loginVoid();
            limpiar();
        }

        private void loginVoid(){
            if (txtUser.Text == "")
            {
                MessageBox.Show("No ha ingresado un usuario", "Sercor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUser.Focus();
            }
            else if (txtPsw.Text == "")
            {
                MessageBox.Show("No ha ingresado su contraseña", "Sercor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPsw.Focus();
            }
            else
            {
                UsuarioSeleccionado = UsuarioDBM.ObtenerUsuario(txtUser.Text);
                if (UsuarioSeleccionado != null)
                {
                    string passHashed = UsuarioSeleccionado.CONTRASENA;

                    string passUnhash = Hash.sha256(txtPsw.Text);
                    //crear temporalmente una app aparte, para al momento de presentar registrar usuario con Hash
                    if (passHashed == passUnhash)
                    {
                        FormInstance.mainWindow(UsuarioSeleccionado,this);
                        this.Enabled=false;
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
        private void limpiar()
        {
            txtPsw.Text = "";
            txtUser.Text = "";
            
            //*//
            txtUser.Select();
            txtUser.Focus();
        }

        //FORZAR RECONEXION
        private void lblStatus_Click(object sender, EventArgs e)
        {
            Conectar();
        }
    }
}