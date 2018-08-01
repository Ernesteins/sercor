using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sercor
{
    class ProductoVendidoDBM
    {
        public static int Agregar(ProductoVendido pProducto)
        {
            int retorno = 0;

            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "Insert into producto_vendido (ID_PRODUCTO,ID_DETALLE, NOMBRE, DESCRIPCION, CATEGORIA, " +
                "SUBCATEGORIA, PRECIO, Cantidad) " +
                "values ('{0}','{1}','{2}', '{3}', '{4}', '{5}', '{6}','{7}')",
                pProducto.COD,pProducto.ID_DETALLE, pProducto.NOMBRE, pProducto.DESCRIPCION, pProducto.CATEGORIA,
                pProducto.SUBCATEGORIA, pProducto.PRECIO, pProducto.CANTIDAD), conexion);

            retorno = comando.ExecuteNonQuery();
            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }

        public static ProductoVendido ObtenerProductoCod(string pCod)
        {
            ProductoVendido pProducto = new ProductoVendido();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM producto_vendido  where ID_PRODUCTO='{0}'", pCod), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pProducto.COD = _reader.GetString(0);
                pProducto.ID_DETALLE = _reader.GetInt32(1);
                pProducto.NOMBRE = _reader.GetString(2);
                pProducto.DESCRIPCION = _reader.GetString(3);
                pProducto.CATEGORIA = _reader.GetString(4);
                pProducto.SUBCATEGORIA = _reader.GetString(5);
                pProducto.PRECIO = _reader.GetDecimal(6);
                pProducto.CANTIDAD= _reader.GetInt32(7);
            }
            conexion.Close();
            return pProducto;
        }
        public static List<ProductoVendido> ObtenerProductos()
        {
            List<ProductoVendido> _lista = new List<ProductoVendido>();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT ID_PRODUCTO, ID_DETALLE, NOMBRE, DESCRIPCION, CATEGORIA, SUBCATEGORIA, EXISTENCIA, PRECIO, ESTADO FROM producto_vendido"), conexion);

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ProductoVendido pProducto = new ProductoVendido();

                pProducto.COD = _reader.GetString(0);
                pProducto.ID_DETALLE = _reader.GetInt32(1);
                pProducto.NOMBRE = _reader.GetString(2);
                pProducto.DESCRIPCION = _reader.GetString(3);
                pProducto.CATEGORIA = _reader.GetString(4);
                pProducto.SUBCATEGORIA = _reader.GetString(5);
                pProducto.PRECIO = _reader.GetDecimal(6);
                pProducto.CANTIDAD= _reader.GetInt32(7);

                _lista.Add(pProducto);
            }
            conexion.Close();
            return _lista;
        }


    }
}
