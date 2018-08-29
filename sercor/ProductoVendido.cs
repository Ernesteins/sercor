namespace sercor
{
    class ProductoVendido
    {
        public int COD { get; set; }
        public int ID_DETALLE { get; set; }
        public string ID_PRODUCTOINVENTARIO { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public string CATEGORIA { get; set; }
        public string SUBCATEGORIA { get; set; }
        public decimal PRECIO { get; set; }
        public int CANTIDAD { get; set; }

        public ProductoVendido() { }

        public ProductoVendido(int pId, int pIdDetalle, string pProductoInventario, string pNombre, string pDescripcion, string pCategoria,
            string pSubcategoria, decimal pPrecio, int pCantidad)
        {
            this.COD = pId;
            this.ID_DETALLE = pIdDetalle;
            this.ID_PRODUCTOINVENTARIO = pProductoInventario;
            this.NOMBRE = pNombre;
            this.DESCRIPCION = pDescripcion;
            this.CATEGORIA = pCategoria;
            this.SUBCATEGORIA = pSubcategoria;
            this.PRECIO = pPrecio;
            this.CANTIDAD = pCantidad;
        }
    }

    class ProductoVendidoCustom
    {
        public string ID_PRODUCTOINVENTARIO { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal PRECIO { get; set; }
        public int CANTIDAD { get; set; }

        public ProductoVendidoCustom() { }

        public ProductoVendidoCustom(string pProductoInventario, string pDescripcion, decimal pPrecio, int pCantidad)
        {
            this.ID_PRODUCTOINVENTARIO = pProductoInventario;
            this.DESCRIPCION = pDescripcion;
            this.PRECIO = pPrecio;
            this.CANTIDAD = pCantidad;
        }
    }
}
