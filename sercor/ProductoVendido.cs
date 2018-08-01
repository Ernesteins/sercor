using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sercor
{
    class ProductoVendido
    {
        public string COD { get; set; }
        public int ID_DETALLE { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public string CATEGORIA { get; set; }
        public string SUBCATEGORIA { get; set; }
        public decimal PRECIO { get; set; }
        public int CANTIDAD { get; set; }

        public ProductoVendido() { }

        public ProductoVendido(string pId, int pIdDetalle, string pNombre, string pDescripcion, string pCategoria,
            string pSubcategoria, decimal pPrecio, int pCantidad)
        {
            this.COD = pId;
            this.ID_DETALLE = pIdDetalle;
            this.NOMBRE = pNombre;
            this.DESCRIPCION = pDescripcion;
            this.CATEGORIA = pCategoria;
            this.SUBCATEGORIA = pSubcategoria;
            this.PRECIO = pPrecio;
            this.CANTIDAD = pCantidad;
        }
    }
    
}
