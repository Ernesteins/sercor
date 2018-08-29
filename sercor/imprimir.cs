using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace sercor
{
    
    public partial class imprimir : Form
    {
        public imprimir(List<FacturaImpresion> list, int tipo, string nombre, string ruc, DateTime fecha, string direccion, string telefono, decimal subtotal,
            decimal iva0, decimal iva12, decimal total, decimal abono, decimal saldo, DateTime fechaEntrega)
        {
            InitializeComponent();
            switch (tipo)
            {
                case 1:
                    factura1.SetDataSource(list);
                    crystalReportViewer.ReportSource = factura1;

                    factura1.SetParameterValue(0, nombre);
                    factura1.SetParameterValue(1, ruc);
                    factura1.SetParameterValue(2, fecha.ToString("yyyy-MM-dd"));
                    factura1.SetParameterValue(3, direccion);
                    factura1.SetParameterValue(4, telefono);
                    factura1.SetParameterValue(5, subtotal);
                    factura1.SetParameterValue(6, iva0);
                    factura1.SetParameterValue(7, iva12);
                    factura1.SetParameterValue(8, total);
                    factura1.SetParameterValue(9, abono);
                    factura1.SetParameterValue(10, saldo);

                    factura1.SetParameterValue(11, fechaEntrega.ToString("yyyy-MM-dd"));

                    MessageBox.Show(fechaEntrega.Date.Hour.ToString());

                    factura1.SetParameterValue(12, fechaEntrega.ToString("HH:mm"));

                    crystalReportViewer.Refresh();

                    break;
            }
            
        }

        private void imprimir_Load(object sender, EventArgs e)
        {
            
            //reporte1.SetDataSource(_list);
            //crystalReportViewer.ReportSource = reporte1;
            //crystalReportViewer.Refresh();
        }
    }
}
