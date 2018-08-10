using System;
using System.Windows.Forms;

namespace sercor
{
    public partial class cambiar_estado : Form
    {
        public string mensaje;
        int codigo;
        public cambiar_estado(Trabajo trb)
        {

            InitializeComponent();

            FormInstance.puntoDecimal();

            codigo = trb.ID;

            txtCodigo.Text = trb.ID.ToString();
            chklEstado.SelectedIndex = trb.ESTADO-1;
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (chklEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Un estado debe ser seleccionado");
            }
            else
            {
                try
                {
                    Trabajo tTrabajo = new Trabajo();

                    tTrabajo.ID = Convert.ToInt32(txtCodigo.Text.Trim());
                    tTrabajo.ESTADO = chklEstado.SelectedIndex +1;
                    
                    
                    int resultado = TrabajoDBM.Modificar(tTrabajo, codigo);
                    if (resultado > 0)
                    {
                        mensaje = "Producto modificado con exito";
                        this.Close();
                    }
                    else
                    {
                        mensaje = "No es posible modificar el estado del Trabajo";
                        this.Close();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Valores incorrectos");
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("Error en la base de datos, contacte con el administrador");
                }
            }

        }

        private void chklEstado_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            /*
            
            chklEstado.SetItemChecked(chklEstado.SelectedIndex, true);*/


        }

        private void chklEstado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            chklEstado.SetItemChecked(0, false);
            chklEstado.SetItemChecked(1, false);
            chklEstado.SetItemChecked(2, false);
            chklEstado.SetItemChecked(3, false);

        }

        private void chklEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
        