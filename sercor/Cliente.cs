using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sercor
{
    public class Cliente
    {
        public int ID_CLIENTE { get; set; }
        public string NOMBRE { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }

        //Constructor de objeto
        public Cliente() { }

        public Cliente(int pId, string pNombre, string pDireccion, string pTelefono)

        {
            this.ID_CLIENTE = pId;
            this.NOMBRE = pNombre;
            this.DIRECCION = pDireccion;
            this.TELEFONO = pTelefono;
        }
    }
}
