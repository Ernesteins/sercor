﻿namespace sercor
{
    public class Producto
    {
        public string COD { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public string CATEGORIA { get; set; }
        public string SUBCATEGORIA { get; set; }
        public int EXISTENCIA { get; set; }
        public decimal PRECIO { get; set; }
        public int ESTADO { get; set; }

        //Constructor de objeto
        public Producto() { }

        public Producto(string pId, string pNombre, string pDescripcion, string pCategoria,
            string pSubcategoria, int pExistencia, decimal pPrecio, int pEstado)
        {
            this.COD = pId;
            this.NOMBRE = pNombre;
            this.DESCRIPCION = pDescripcion;
            this.CATEGORIA = pCategoria;
            this.SUBCATEGORIA = pSubcategoria;
            this.EXISTENCIA = pExistencia;
            this.PRECIO = pPrecio;
            this.ESTADO = pEstado;
        }
    }

    public class ProductoEstado
    {
        public string COD { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public string CATEGORIA { get; set; }
        public string SUBCATEGORIA { get; set; }
        public int EXISTENCIA { get; set; }
        public decimal PRECIO { get; set; }
        //public int ESTADO { get; set; }

        //Constructor de objeto
        public ProductoEstado() { }

        public ProductoEstado(string pId, string pNombre, string pDescripcion, string pCategoria,
            string pSubcategoria, int pExistencia, decimal pPrecio, int pEstado)
        {
            this.COD = pId;
            this.NOMBRE = pNombre;
            this.DESCRIPCION = pDescripcion;
            this.CATEGORIA = pCategoria;
            this.SUBCATEGORIA = pSubcategoria;
            this.EXISTENCIA = pExistencia;
            this.PRECIO = pPrecio;
            //this.ESTADO = pEstado;
        }
    }
}
