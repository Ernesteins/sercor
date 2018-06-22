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
    }
}
