﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace sercor
{
    public class FormInstance
    {
        public static void mainWindow()
        {
            var main = new sercormain();
            main.Show();
        }
    }
}
