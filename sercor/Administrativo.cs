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
    public partial class Administrativo : Form
    {
        public Administrativo()
        {
            InitializeComponent();

            refreshUsers();
        }

        private void refreshUsers()
        {
            cbmUsuario.Items.Clear();
            int j = 0;
            for (int i = 0; i <= UsuarioDBM.Usuarios().Count; i++)
            {
                if (j != UsuarioDBM.Usuarios().Count)
                {
                    cbmUsuario.Items.Add(UsuarioDBM.Usuarios()[i].USUARIO);
                    j++;
                }
            }
            cbmUsuario.SelectedIndex = 0;
        }

        private void uncheck()
        {
            admin1.Checked = false;
            admin2.Checked = false;
            admin3.Checked = false;
            admin4.Checked = false;

            user1.Checked = false;
            user2.Checked = false;
            user3.Checked = false;
            user4.Checked = false;
        }
        Usuario selectedUser { get; set; }

        private void cbmUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUser = UsuarioDBM.ObtenerUsuario(cbmUsuario.SelectedItem.ToString());
            txtCi.Text = selectedUser.CEDULA;
            txtName.Text = selectedUser.NOMBRE;
            txtLastName.Text = selectedUser.APELLIDO;
            txtTelefono.Text = selectedUser.TELEFONO;
            txtDireccion.Text = selectedUser.DIRECCION;
            txtContrasenia.Text = selectedUser.CONTRASENA;
            uncheck();
            switch (selectedUser.PRIVILEGIO1)
            {
                case 0:
                    uncheck();
                    break;

                case 1:
                    admin1.Checked = true;
                    break;

                case 2:
                    admin2.Checked = true;
                    break;

                case 3:
                    admin3.Checked = true;
                    break;

                case 4:
                    admin4.Checked = true;
                    break;

                case 5:
                    admin1.Checked = true;
                    admin2.Checked = true;
                    break;

                case 6:
                    admin1.Checked = true;
                    admin3.Checked = true;
                    break;

                case 7:
                    admin1.Checked = true;
                    admin4.Checked = true;
                    break;

                case 8:
                    admin2.Checked = true;
                    admin3.Checked = true;
                    break;

                case 9:
                    admin2.Checked = true;
                    admin4.Checked = true;
                    break;

                case 10:
                    admin3.Checked = true;
                    admin4.Checked = true;
                    break;

                case 11://
                    admin1.Checked = true;
                    admin2.Checked = true;
                    admin3.Checked = true;
                    break;

                case 12://
                    admin1.Checked = true;
                    admin2.Checked = true;
                    admin4.Checked = true;
                    break;

                case 13://
                    admin1.Checked = true;
                    admin3.Checked = true;
                    admin4.Checked = true;
                    break;

                case 14://
                    admin2.Checked = true;
                    admin3.Checked = true;
                    admin4.Checked = true;
                    break;

                case 15://
                    admin1.Checked = true;
                    admin2.Checked = true;
                    admin3.Checked = true;
                    admin4.Checked = true;
                    break;

                default:
                    uncheck();
                    break;
            }

            switch (selectedUser.PRIVILEGIO2)
            {
                case 0:
                    uncheck();
                    break;

                case 1:
                    user1.Checked = true;
                    break;

                case 2:
                    user2.Checked = true;
                    break;

                case 3:
                    user3.Checked = true;
                    break;

                case 4:
                    user4.Checked = true;
                    break;

                case 5:
                    user1.Checked = true;
                    user2.Checked = true;
                    break;

                case 6:
                    user1.Checked = true;
                    user3.Checked = true;
                    break;

                case 7:
                    user1.Checked = true;
                    user4.Checked = true;
                    break;

                case 8:
                    user2.Checked = true;
                    user3.Checked = true;
                    break;

                case 9:
                    user2.Checked = true;
                    user4.Checked = true;
                    break;

                case 10:
                    user3.Checked = true;
                    user4.Checked = true;
                    break;

                case 11:
                    user1.Checked = true;
                    user2.Checked = true;
                    user3.Checked = true;
                    break;

                case 12:
                    user1.Checked = true;
                    user2.Checked = true;
                    user4.Checked = true;
                    break;

                case 13:
                    user1.Checked = true;
                    user3.Checked = true;
                    user4.Checked = true;
                    break;

                case 14:
                    user2.Checked = true;
                    user3.Checked = true;
                    user4.Checked = true;
                    break;

                case 15:
                    user1.Checked = true;
                    user2.Checked = true;
                    user3.Checked = true;
                    user4.Checked = true;
                    break;

                default:
                    uncheck();
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            editarUsuario _editarUsuario = new editarUsuario(selectedUser);
            _editarUsuario.ShowDialog();
            refreshUsers();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            nuevoUsuario nuevoUser = new nuevoUsuario();
            nuevoUser.ShowDialog();
            refreshUsers();
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}