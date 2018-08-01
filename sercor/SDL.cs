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
    public partial class SDL : Form
    {
        public SDL()
        {
            InitializeComponent();
            FormInstance.puntoDecimal();

            StringBuilder sb = new StringBuilder();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivo(*.serdl)|*.serdl";
            if (ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                dgvProducto.Rows.Clear();
                this.Text = "SDL | " + ofd.FileName;
                using (System.IO.StreamReader sr=new System.IO.StreamReader(ofd.FileName,false))
                {
                    while (sr.Peek() >= 0)
                    {
                        sb.Append(sr.ReadLine());
                    }
                }
                string[] separate;
                separate = sb.ToString().Split(';');
                separate = separate.Take(separate.Count() - 1).ToArray();
                int contador = 0, contador2 = 0;
                for (int i = 0; i <= separate.Length - 1; i++)
                {
                    if (contador == 0)
                    {
                        dgvProducto.Rows.Add(1);
                    }
                    dgvProducto.Rows[contador2].Cells[contador].Value = separate[i];
                    if (contador != 7)
                    {
                        contador++;
                    }
                    else
                    {
                        contador = 0;
                        contador2++;
                    }
                }
            }
        }
        public string mensaje;
        int contador;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto cargarProducto = new Producto();
            Producto comparaProducto = new Producto();
            string codigo;
            int existencia;
            

            DialogResult existConfirm = MessageBox.Show("¿Sumar existencia de productos duplicados? Presione NO para sobreescribirlas","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            DialogResult result = MessageBox.Show("Esta operación puede causar cambios en Sercor. ¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < dgvProducto.RowCount; i++)
                {
                    //MessageBox.Show(dgvProducto.Rows[i].Cells[0].Value.ToString());
                    codigo = dgvProducto.Rows[i].Cells[0].Value.ToString();

                    cargarProducto.COD = codigo;
                    cargarProducto.NOMBRE = dgvProducto.Rows[i].Cells[1].Value.ToString();
                    cargarProducto.DESCRIPCION = dgvProducto.Rows[i].Cells[2].Value.ToString();
                    cargarProducto.CATEGORIA = dgvProducto.Rows[i].Cells[3].Value.ToString();
                    cargarProducto.SUBCATEGORIA = dgvProducto.Rows[i].Cells[4].Value.ToString();
                    cargarProducto.EXISTENCIA = Convert.ToInt32(dgvProducto.Rows[i].Cells[5].Value);
                    cargarProducto.PRECIO = Convert.ToDecimal(dgvProducto.Rows[i].Cells[6].Value);
                    cargarProducto.ESTADO = Convert.ToInt32(dgvProducto.Rows[i].Cells[7].Value);

                    comparaProducto = ProductoDBM.ObtenerProductoCod(codigo);
                    
                    if (comparaProducto.COD != null)
                    {//EXISTE
                        existencia = comparaProducto.EXISTENCIA;
                        if (existConfirm==DialogResult.Yes)
                        {
                            cargarProducto.EXISTENCIA = existencia + Convert.ToInt32(dgvProducto.Rows[i].Cells[5].Value);
                        }
                        ProductoDBM.Modificar(cargarProducto, codigo);
                        contador =+ 1;
                        //MessageBox.Show(comparaProducto.COD);
                    }
                    else//NO EXISTE
                    {
                        ProductoDBM.Agregar(cargarProducto);
                        //MessageBox.Show("Es nulo");
                    }
                }
                mensaje = "Se modificaron "+contador.ToString()+" productos existentes";
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Se ha cancelado la transferencia de productos","Sercor",MessageBoxButtons.OK,MessageBoxIcon.Information);
                mensaje = "Se canceló la operación";
            }
            else
            {
                //...
            }
        }
    }
}
