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
    public partial class Añadir_egreso : Form
    {
        public Añadir_egreso()
        {
            InitializeComponent();
            carga();
            //SUPER IMPORTANTE D:
            FormInstance.puntoDecimal();
        }

        private void carga()
        {
            txtID.Text = EgresoDBM.UltimoEgreso()+1.ToString();
            ddltipo.SelectedIndex = 0;
            txtBeneficiario.Text = "";
            txtMonto.Text = "";
            txtDescripcion.Text = "";
        }

        public bool esDinero(Char c)
        {
            if (Char.IsDigit(c) || Char.IsControl(c) || c == '.' || c == ',')
            {
                return false;
            }
            return true;
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (esDinero(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public string mensaje;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text=="" || txtBeneficiario.Text=="" || txtDescripcion.Text=="" || txtID.Text=="")
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else
            {
                Egreso nEgreso = new Egreso(Convert.ToInt32(txtID.Text), fecha.Value.ToString("yyyy-MM-dd HH:mm:ss"), ddltipo.SelectedText.ToString(), Convert.ToDecimal(txtMonto.Text), txtBeneficiario.Text, txtDescripcion.Text);
                if (EgresoDBM.Agregar(nEgreso) == 1)
                {
                    mensaje = "Egreso registrado con éxito";
                    carga();
                    
                }
                else
                {
                    MessageBox.Show("error al registrar tipo= {0}", nEgreso.TIPO_EGRESO);
                }
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
