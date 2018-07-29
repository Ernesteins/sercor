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
    
    public partial class imprimir : Form
    {
        List<Producto> _list;
        public imprimir(List<Producto>list)
        {
            InitializeComponent();
            _list = list;
        }

        private void imprimir_Load(object sender, EventArgs e)
        {
            //reporte1.SetDataSource(_list);
            //crystalReportViewer.ReportSource = reporte1;
            crystalReportViewer.Refresh();
        }
    }
}
