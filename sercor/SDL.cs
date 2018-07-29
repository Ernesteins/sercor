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
    }
}
