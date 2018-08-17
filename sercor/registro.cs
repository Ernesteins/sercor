using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sercor
{
    class registro
    {
        public int IDREGISTRO { get; set; }
        public string FECHA { get; set; }
        public string ID_PRODUCTO { get; set; }
        public int ID_PRODUCTO_V { get; set; }
        public int CANTIDAD{ get; set; }

        public registro(int iDREGISTRO, string fECHA, string iD_PRODUCTO, int iD_PRODUCTO_V, int cantidad)
        {
            this.IDREGISTRO = iDREGISTRO;
            this.FECHA = fECHA;
            this.ID_PRODUCTO = iD_PRODUCTO;
            this.ID_PRODUCTO_V = iD_PRODUCTO_V;
            this.CANTIDAD= cantidad;
        }

        public registro() { }
    }
    
}
