using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace sercor
{
    public class FormInstance
    {
        public static void mainWindow(Usuario _user, Form form)
        {
            var main = new sercormain(_user,form);
            main.Show();
        }

        //IMPORTANTE
        public static void puntoDecimal()//CAMBIA EL FORMATO DE DECIMALES
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }
    }
}
