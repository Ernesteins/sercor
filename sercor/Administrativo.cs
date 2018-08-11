using System;
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

            if (cbmUsuario.SelectedItem.ToString() == "admin")
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se eliminará el usuario " + selectedUser.USUARIO + " ¿Desea proceder?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                UsuarioDBM.Delete(selectedUser.ID_USUARIO);
                MessageBox.Show("Por favor, a continuación reinicie Sercor","Sercor",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                Application.Exit();
            }
            else
            {

            } 
        }
    }
}