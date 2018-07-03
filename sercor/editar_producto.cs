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
    public partial class editar_producto : Form
    {
        public string mensaje;
        string codigo;
        public editar_producto(Producto producto)
        {
            InitializeComponent();

            FormInstance.puntoDecimal();

            codigo = producto.COD;

            txtCodigo.Text = producto.COD;
            txtNombre.Text = producto.NOMBRE;
            txtDescripcion.Text = producto.DESCRIPCION;
            txtCategoria.Text = producto.CATEGORIA;
            txtSubcategoria.Text = producto.SUBCATEGORIA;
            txtExistencia.Text = Convert.ToString(producto.EXISTENCIA);
            txtPrecio.Text = Convert.ToString(producto.PRECIO);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" | txtNombre.Text == "" | txtDescripcion.Text == "" | txtCategoria.Text == "" | txtSubcategoria.Text == "" | txtExistencia.Text == "" | txtPrecio.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else
            {
                try{
                    Producto pProducto = new Producto();

                    pProducto.COD = txtCodigo.Text.Trim();
                    pProducto.NOMBRE = txtNombre.Text.Trim();
                    pProducto.DESCRIPCION = txtDescripcion.Text.Trim();
                    pProducto.CATEGORIA = txtCategoria.Text.Trim();
                    pProducto.SUBCATEGORIA = txtSubcategoria.Text.Trim();
                    pProducto.EXISTENCIA = Convert.ToInt32(txtExistencia.Text);

                    txtPrecio.Text = txtPrecio.Text.Replace(",", ".");

                    pProducto.PRECIO = Decimal.Round(Convert.ToDecimal(txtPrecio.Text), 2);
                    pProducto.ESTADO = 1;

                    int resultado = ProductoDBM.Modificar(pProducto, codigo);
                    if (resultado > 0)
                    {
                        mensaje = "Producto modificado con exito";
                        this.Close();
                    }
                    else
                    {
                        mensaje = "No es posible modificar el producto";
                        this.Close();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Valores incorrecto");
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("Producto existente");
                }

            }
        }
    }
}
