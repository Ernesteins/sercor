using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sercor
{
    public class Cliente
    {
        public uint ID_CLIENTE { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }

        //Constructor de objeto
        public Cliente() { }

        public Cliente(uint pId, string pNombre, string pApellido, string pDireccion, string pTelefono)

        {
            this.ID_CLIENTE = pId;
            this.NOMBRE = pNombre;
            this.APELLIDO = pApellido;
            this.DIRECCION = pDireccion;
            this.TELEFONO = pTelefono;
        }
    }
}
