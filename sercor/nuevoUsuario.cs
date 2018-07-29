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
    public partial class nuevoUsuario : Form
    {
        public nuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtUser.Text=="" || txtContrasenia.Text == "")
            {
                MessageBox.Show("No ha ingresado un usuario o contraseña");
                txtUser.Select();
            }
            else
            {
                int pri1, pri2;

                if (admin1.Checked == true && admin2.Checked == true && admin3.Checked == true && admin4.Checked == true)
                {
                    pri1 = 15;
                }
                else if (admin2.Checked == true && admin3.Checked == true && admin4.Checked == true)
                {
                    pri1 = 14;
                }
                else if (admin1.Checked == true && admin3.Checked == true && admin4.Checked == true)
                {
                    pri1 = 13;
                }
                else if (admin1.Checked == true && admin2.Checked == true && admin4.Checked == true)
                {
                    pri1 = 12;
                }
                else if (admin1.Checked == true && admin2.Checked == true && admin3.Checked == true)
                {
                    pri1 = 11;
                }
                else if (admin3.Checked == true && admin4.Checked == true)
                {
                    pri1 = 10;
                }
                else if (admin2.Checked == true && admin4.Checked == true)
                {
                    pri1 = 9;
                }
                else if (admin2.Checked == true && admin3.Checked == true)
                {
                    pri1 = 8;
                }
                else if (admin1.Checked == true && admin4.Checked == true)
                {
                    pri1 = 7;
                }
                else if (admin1.Checked == true && admin3.Checked == true)
                {
                    pri1 = 6;
                }
                else if (admin1.Checked == true && admin2.Checked == true)
                {
                    pri1 = 5;
                }
                else if (admin4.Checked == true)
                {
                    pri1 = 4;
                }
                else if (admin3.Checked == true)
                {
                    pri1 = 3;
                }
                else if (admin2.Checked == true)
                {
                    pri1 = 2;
                }
                else if (admin1.Checked == true)
                {
                    pri1 = 1;
                }
                else
                {
                    pri1 = 0;
                }


                if (user1.Checked == true && user2.Checked == true && user3.Checked == true && user4.Checked == true)
                {
                    pri2 = 15;
                }
                else if (user2.Checked == true && user3.Checked == true && user4.Checked == true)
                {
                    pri2 = 14;
                }
                else if (user1.Checked == true && user3.Checked == true && user4.Checked == true)
                {
                    pri2 = 13;
                }
                else if (user1.Checked == true && user2.Checked == true && user4.Checked == true)
                {
                    pri2 = 12;
                }
                else if (user1.Checked == true && user2.Checked == true && user3.Checked == true)
                {
                    pri2 = 11;
                }
                else if (user3.Checked == true && user4.Checked == true)
                {
                    pri2 = 10;
                }
                else if (user2.Checked == true && user4.Checked == true)
                {
                    pri2 = 9;
                }
                else if (user2.Checked == true && user3.Checked == true)
                {
                    pri2 = 8;
                }
                else if (user1.Checked == true && user4.Checked == true)
                {
                    pri2 = 7;
                }
                else if (user1.Checked == true && user3.Checked == true)
                {
                    pri2 = 6;
                }
                else if (user1.Checked == true && user2.Checked == true)
                {
                    pri2 = 5;
                }
                else if (user4.Checked == true)
                {
                    pri2 = 4;
                }
                else if (user3.Checked == true)
                {
                    pri2 = 3;
                }
                else if (user2.Checked == true)
                {
                    pri2 = 2;
                }
                else if (user1.Checked == true)
                {
                    pri2 = 1;
                }
                else
                {
                    pri2 = 0;
                }

                Usuario nuevoUser = new Usuario();
                Usuario lastUser = new Usuario();
                lastUser = UsuarioDBM.UltimoUsuario();
                nuevoUser.ID_USUARIO = lastUser.ID_USUARIO + 1;
                nuevoUser.TIPO = 1;
                nuevoUser.USUARIO = txtUser.Text;
                nuevoUser.CONTRASENA = Hash.sha256(txtContrasenia.Text);
                nuevoUser.NOMBRE = txtName.Text;
                nuevoUser.APELLIDO = txtLastName.Text;
                nuevoUser.CEDULA = txtCi.Text;
                nuevoUser.DIRECCION = txtDireccion.Text;
                nuevoUser.TELEFONO = txtTelefono.Text;
                nuevoUser.PRIVILEGIO1 = pri1;
                nuevoUser.PRIVILEGIO2 = pri2;

                UsuarioDBM.Agregar(nuevoUser);

                this.Close();
            }  
        }
    }
}
