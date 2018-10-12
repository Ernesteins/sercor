namespace sercor
{
    public class FacturaImpresion
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }

        //Constructor de objeto
        public FacturaImpresion() { }

        public FacturaImpresion(string pCodigo, string pDescripcion, int pCantidad, decimal pValorUnitario, decimal pValorTotal)
        {
            this.Codigo = pCodigo;
            this.Descripcion = pDescripcion;
            this.Cantidad = pCantidad;
            this.ValorUnitario = pValorUnitario;
            this.ValorTotal = pValorTotal;
        }
    }
}
