namespace sercor
{
    public class Cliente
    {
        public string ID_CLIENTE { get; set; }
        public string NOMBRE { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }

        //Constructor de objeto
        public Cliente() { }

        public Cliente(string pId, string pNombre, string pDireccion, string pTelefono)

        {
            this.ID_CLIENTE = pId;
            this.NOMBRE = pNombre;
            this.DIRECCION = pDireccion;
            this.TELEFONO = pTelefono;
        }
    }
}
