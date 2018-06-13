using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sercor
{
    public class Usuario
    {
        public uint ID_USUARIO { get; set; }
        public UInt16 TIPO { get; set; }
        public string USUARIO { get; set; }
        public string CONTRASENA { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string CEDULA { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public UInt16 PRIVILEGIO1 { get; set; }
        public UInt16 PRIVILEGIO2 { get; set; }

        //Constructor de objeto
        public Usuario() { }

        public Usuario(uint pId, UInt16 pTipo, string pUsuario, string pContrasena, string pNombre,
            string pApellido, string pCedula, string pDireccion, string pTelefono,
            UInt16 pPriv1, UInt16 pPriv2)

        {
            this.ID_USUARIO = pId;
            this.TIPO = pTipo;
            this.USUARIO = pUsuario;
            this.CONTRASENA = pContrasena;
            this.NOMBRE = pNombre;
            this.APELLIDO = pApellido;
            this.CEDULA = pCedula;
            this.DIRECCION = pDireccion;
            this.TELEFONO = pTelefono;
            this.PRIVILEGIO1 = pPriv1;
            this.PRIVILEGIO2 = pPriv2;
        }
    }
}