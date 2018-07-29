﻿using System;
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
            int j = 0;
            for (int i = 0; i <= UsuarioDBM.Usuarios().Count; i++)
            {
                if (j != UsuarioDBM.Usuarios().Count)
                {
                    cbmUsuario.Items.Add(UsuarioDBM.Usuarios()[i].USUARIO);
                    j++;
                }
            }
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
            int pri1, pri2;

            if (admin1.Checked == true && admin2.Checked==true && admin3.Checked==true && admin4.Checked==true)
            {
                pri1 = 15;
            }
            else if(admin2.Checked==true && admin3.Checked==true && admin4.Checked==true)
            {
                pri1=14;
            }else if (admin1.Checked==true && admin3.Checked==true && admin4.Checked==true)
            {
                pri1 = 13;
            }else if (admin1.Checked==true && admin2.Checked==true && admin4.Checked==true)
            {
                pri1 = 12;
            }else if (admin1.Checked==true && admin2.Checked==true && admin3.Checked==true)
            {
                pri1 = 11;
            }else if (admin3.Checked==true && admin4.Checked==true)
            {
                pri1 = 10;
            }else if(admin2.Checked==true && admin4.Checked == true)
            {
                pri1 = 9;
            }else if(admin2.Checked==true && admin3.Checked == true)
            {
                pri1 = 8;
            }else if(admin1.Checked==true && admin4.Checked == true)
            {
                pri1 = 7;
            }else if(admin1.Checked==true && admin3.Checked == true)
            {
                pri1 = 6;
            }else if(admin1.Checked==true && admin2.Checked == true)
            {
                pri1 = 5;
            }else if (admin4.Checked == true)
            {
                pri1 = 4;
            }else if (admin3.Checked == true)
            {
                pri1 = 3;
            }else if (admin2.Checked == true)
            {
                pri1 = 2;
            }else if (admin1.Checked == true)
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
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
        }
    }
}