using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sercor
{
    public class Usuario
    {
        public int ID_USUARIO { get; set; }
        public int TIPO { get; set; }
        public string USUARIO { get; set; }
        public string CONTRASENA { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string CEDULA { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public int PRIVILEGIO1 { get; set; }
        public int PRIVILEGIO2 { get; set; }

        //Constructor de objeto
        public Usuario() { }

        public Usuario(int pId, int pTipo, string pUsuario, string pContrasena, string pNombre,
            string pApellido, string pCedula, string pDireccion, string pTelefono,
            int pPriv1, int pPriv2)

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