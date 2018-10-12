using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
namespace sercor
{
    class ProductoVendidoDBM
    {
        public static int Agregar(ProductoVendido pProducto)
        {
            int retorno = 0;

            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "Insert into producto_vendido (ID_PRODUCTO,ID_DETALLE,ID_PRODUCTOINVENTARIO, NOMBRE, DESCRIPCION, CATEGORIA, " +
                "SUBCATEGORIA, PRECIO, Cantidad) " +
                "values ('{0}','{1}','{2}', '{3}', '{4}', '{5}', '{6}','{7}','{8}')",
                pProducto.COD, pProducto.ID_DETALLE, pProducto.ID_PRODUCTOINVENTARIO, pProducto.NOMBRE, pProducto.DESCRIPCION, pProducto.CATEGORIA,
                pProducto.SUBCATEGORIA, pProducto.PRECIO, pProducto.CANTIDAD), conexion);

            retorno = comando.ExecuteNonQuery();
            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }

        //SELECT* FROM factura WHERE tipo='{0}' order by indice DESC LIMIT 1
        public static ProductoVendido ObtenerUltimoProducto()
        {
            ProductoVendido pProducto = new ProductoVendido();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM producto_vendido order by ID_PRODUCTO desc limit 1"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pProducto.COD = _reader.GetInt32(0);
                pProducto.ID_DETALLE = _reader.GetInt32(1);
                pProducto.ID_PRODUCTOINVENTARIO = _reader.GetString(2);
                pProducto.NOMBRE = _reader.GetString(3);
                pProducto.DESCRIPCION = _reader.GetString(4);
                pProducto.CATEGORIA = _reader.GetString(5);
                pProducto.SUBCATEGORIA = _reader.GetString(6);
                pProducto.PRECIO = _reader.GetDecimal(7);
                pProducto.CANTIDAD = _reader.GetInt32(8);
            }
            conexion.Close();
            return pProducto;
        }


        public static ProductoVendido ObtenerProductoCod(int pCod)
        {
            ProductoVendido pProducto = new ProductoVendido();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM producto_vendido  where ID_PRODUCTO='{0}'", pCod), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pProducto.COD = _reader.GetInt32(0);
                pProducto.ID_DETALLE = _reader.GetInt32(1);
                pProducto.ID_PRODUCTOINVENTARIO = _reader.GetString(2);
                pProducto.NOMBRE = _reader.GetString(3);
                pProducto.DESCRIPCION = _reader.GetString(4);
                pProducto.CATEGORIA = _reader.GetString(5);
                pProducto.SUBCATEGORIA = _reader.GetString(6);
                pProducto.PRECIO = _reader.GetDecimal(7);
                pProducto.CANTIDAD= _reader.GetInt32(8);
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

                pProducto.COD = _reader.GetInt32(0);
                pProducto.ID_DETALLE = _reader.GetInt32(1);
                pProducto.ID_PRODUCTOINVENTARIO = _reader.GetString(2);
                pProducto.NOMBRE = _reader.GetString(3);
                pProducto.DESCRIPCION = _reader.GetString(4);
                pProducto.CATEGORIA = _reader.GetString(5);
                pProducto.SUBCATEGORIA = _reader.GetString(6);
                pProducto.PRECIO = _reader.GetDecimal(7);
                pProducto.CANTIDAD= _reader.GetInt32(8);

                _lista.Add(pProducto);
            }
            conexion.Close();
            return _lista;
        }

        public static List<ProductoVendidoCustom> ObtenerProductosDetalle(int pDetalle)
        {
            List<ProductoVendidoCustom> _lista = new List<ProductoVendidoCustom>();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT * FROM producto_vendido where ID_DETALLE='{0}'",pDetalle), conexion);

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ProductoVendidoCustom pProducto = new ProductoVendidoCustom();

                //pProducto.COD = _reader.GetInt32(0);
                //pProducto.ID_DETALLE = _reader.GetInt32(1);
                pProducto.ID_PRODUCTOINVENTARIO = _reader.GetString(2);
                //pProducto.NOMBRE = _reader.GetString(3);
                pProducto.DESCRIPCION = _reader.GetString(4);
                //pProducto.CATEGORIA = _reader.GetString(5);
                //pProducto.SUBCATEGORIA = _reader.GetString(6);
                pProducto.PRECIO = _reader.GetDecimal(7);
                pProducto.CANTIDAD = _reader.GetInt32(8);

                _lista.Add(pProducto);
            }
            conexion.Close();
            return _lista;
        }


        public static bool productoArmazon(string id_producto)
        {
            List<ProductoVendido> _lista = new List<ProductoVendido>();
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(
           "select Descripcion from producto where Descripcion REGEXP 'ARMA' AND ID_PRODUCTO = '{0}';",id_producto), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            bool last = false;
            _reader.Read();

            if (_reader.HasRows)
            {
                last = true;
            }
            else
            {
                last = false;
            }
            conexion.Close();


            return last;
        }
        public static bool productoLuna(string id_producto)
        {
            List<ProductoVendido> _lista = new List<ProductoVendido>();
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(
           "select Descripcion from producto where Descripcion REGEXP 'LUNA' AND ID_PRODUCTO = '{0}';", id_producto), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            bool last = false;
            _reader.Read();

            if (_reader.HasRows)
            {
                last = true;
            }
            else
            {
                last = false;
            }
            conexion.Close();


            return last;
        }



    }
}
