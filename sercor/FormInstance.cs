using System.Windows.Forms;

namespace sercor
{
    public class FormInstance
    {
        public static void mainWindow(Usuario _user, Form form, bool[] _privilegio1, bool[] _privilegio2)
        {
            var main = new sercormain(_user,form,_privilegio1,_privilegio2);
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
