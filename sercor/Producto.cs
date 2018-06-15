using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sercor
{
    public class Producto
    {
        public int ID_PRODUCTO { get; set; }
        public int ID_DETALLE { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public string CATEGORIA { get; set; }
        public string SUBCATEGORIA { get; set; }
        public int EXISTENCIA { get; set; }
        public float PRECIO { get; set; }
        public int ESTADO { get; set; }

        //Constructor de objeto
        public Producto() { }

        public Producto(int pId, int pDetalle, string pNombre, string pDescripcion, string pCategoria,
            string pSubcategoria, int pExistencia, float pPrecio, UInt16 pEstado)

        {
            this.ID_PRODUCTO = pId;
            this.ID_DETALLE = pDetalle;
            this.NOMBRE = pNombre;
            this.DESCRIPCION = pDescripcion;
            this.CATEGORIA = pCategoria;
            this.SUBCATEGORIA = pSubcategoria;
            this.EXISTENCIA = pExistencia;
            this.PRECIO = pPrecio;
            this.ESTADO = pEstado;
        }
    }
}
