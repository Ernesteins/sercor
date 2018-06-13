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
    public partial class sercormain : Form
    {
        //CAMBIO DE MENU
        private void menuToggler(int pnNumber)
        {

            pnVentas.Visible = false;
            pnCxc.Visible = false;
            pnInventario.Visible = false;
            pnReportes.Visible = false;
            pnTrabajos.Visible = false;
            pnMovCaja.Visible = false;

            btnVentas.BackColor = Color.Gray;
            btnCxc.BackColor = Color.Gray;
            btnInventario.BackColor = Color.Gray;
            btnReportes.BackColor = Color.Gray;
            btnTrabajos.BackColor = Color.Gray; 
            btnMovimientos.BackColor = Color.Gray;

            btnVentas.ForeColor = Color.FromArgb(64, 64, 64);
            btnCxc.ForeColor = Color.FromArgb(64, 64, 64);
            btnInventario.ForeColor = Color.FromArgb(64, 64, 64);
            btnReportes.ForeColor = Color.FromArgb(64, 64, 64);
            btnMovimientos.ForeColor = Color.FromArgb(64, 64, 64);
            btnTrabajos.ForeColor = Color.FromArgb(64, 64, 64);
            
            switch (pnNumber)
            {
                case 1: //VENTAS
                    pnVentas.Visible = true;
                    pnVentas.Dock = DockStyle.Fill;

                    btnVentas.BackColor = Color.FromArgb(64, 64, 64);
                    btnVentas.ForeColor = Color.White;
                    break;

                case 2: //CXC
                    pnCxc.Visible = true;
                    pnCxc.Dock = DockStyle.Fill;

                    btnCxc.BackColor = Color.FromArgb(64, 64, 64);
                    btnCxc.ForeColor = Color.White;
                    break;

                case 3:
                    pnInventario.Visible = true;
                    pnInventario.Dock = DockStyle.Fill;

                    btnInventario.BackColor = Color.FromArgb(64, 64, 64);
                    btnInventario.ForeColor = Color.White;
                    break;

                case 4:
                    pnReportes.Visible = true;
                    pnReportes.Dock = DockStyle.Fill;

                    btnReportes.BackColor = Color.FromArgb(64, 64, 64);
                    btnReportes.ForeColor = Color.White;
                    break;

                case 5:
                    pnTrabajos.Visible = true;
                    pnTrabajos.Dock = DockStyle.Fill;

                    btnTrabajos.BackColor = Color.FromArgb(64, 64, 64);
                    btnTrabajos.ForeColor = Color.White;
                    break;

                case 6:
                    pnMovCaja.Visible = true;
                    pnMovCaja.Dock = DockStyle.Fill;

                    btnMovimientos.BackColor = Color.FromArgb(64, 64, 64);
                    btnMovimientos.ForeColor = Color.White;
                    break;

                default:
                    break;
            }
        }

        //REFRESCA EL AUTOCOMPLETE DEL CLIENTE
        private void autocompleteRefresh()
        {
            //CARGA EN AUTOCOMPLETE DE NOMBRE DESDE BASE DE DATOS
            var clienteNombres = new AutoCompleteStringCollection();
            //MessageBox.Show(Convert.ToString(ClienteDBM.ObtenerNombres().Count));
            int j = 0;
            for (int i = 0; i <= ClienteDBM.ObtenerNombres().Count; i++)
            {
                if (j != ClienteDBM.ObtenerNombres().Count)
                {
                    clienteNombres.Add(ClienteDBM.ObtenerNombres()[j].NOMBRE);
                    j++;
                }
            }
            txtName.AutoCompleteCustomSource = clienteNombres;
        }

        public sercormain(){
            InitializeComponent();
            menuToggler(1);

            autocompleteRefresh();
        }

        public Cliente clienteNombres { get; set; }

        private void btnVentas_Click(object sender, EventArgs e){
            menuToggler(1);  
        }

        private void btnCxc_Click(object sender, EventArgs e)
        {
            menuToggler(2);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            menuToggler(3);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            menuToggler(4);
        }

        private void btnTrabajos_Click(object sender, EventArgs e)
        {
            menuToggler(5);
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            menuToggler(6);
        }
    }
}
