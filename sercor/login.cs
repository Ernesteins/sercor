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
        string server="127.0.0.1";
        string databaseName="sercorDB";
        string user="sercoruser";
        string password="S3rc0r";
        
        public login()
        {
            InitializeComponent();
            try
            {
                //Conexion MYSQL
                bdComun.obtenerConexion(server, databaseName, user, password);
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Error en conexión", "Sercor", MessageBoxButtons.OK);
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("No ha ingresado un usuario", "Sercor", MessageBoxButtons.OK);
                txtUser.Focus();
            }
            else if (txtPsw.Text=="") 
            {
                MessageBox.Show("No ha ingresado su contraseña", "Sercor", MessageBoxButtons.OK);
                txtPsw.Focus();
            }
            else
            {

            }
        }
    }
}
