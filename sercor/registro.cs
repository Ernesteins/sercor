﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sercor
{
    class Registro
    {
        public int IDREGISTRO { get; set; }
        public string FECHA { get; set; }
        public string ID_PRODUCTO { get; set; }
        public string ID_PRODUCTO_V { get; set; }
        public int CANTIDAD{ get; set; }

        public Registro(int iDREGISTRO, string fECHA, string iD_PRODUCTO, string iD_PRODUCTO_V, int cantidad)
        {
            this.IDREGISTRO = iDREGISTRO;
            this.FECHA = fECHA;
            this.ID_PRODUCTO = iD_PRODUCTO;
            this.ID_PRODUCTO_V = iD_PRODUCTO_V;
            this.CANTIDAD= cantidad;
        }

        public Registro() { }
    }
    
}
