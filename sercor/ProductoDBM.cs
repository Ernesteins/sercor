using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace sercor
{
    public class ProductoDBM
    {
        public static List<Producto> ObtenerProductos()
        {
            List<Producto> _lista = new List<Producto>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT ID_PRODUCTO, NOMBRE, DESCRIPCION, CATEGORIA, SUBCATEGORIA, EXISTENCIA, PRECIO FROM producto"), bdComun.obtenerConexion());

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Producto pProducto = new Producto();

                pProducto.COD = _reader.GetInt32(0);
                pProducto.NOMBRE = _reader.GetString(1);
                pProducto.DESCRIPCION = _reader.GetString(2);
                pProducto.CATEGORIA= _reader.GetString(3);
                pProducto.SUBCATEGORIA= _reader.GetString(4);
                pProducto.EXISTENCIA= _reader.GetInt32(5);
                pProducto.PRECIO = _reader.GetFloat(6);
                //pProducto.ESTADO= _reader.GetInt32(7);

                _lista.Add(pProducto);
            }
            return _lista;
        }

        public static Producto ObtenerProductoCod(int pCod)
        {
            Producto pProducto = new Producto();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT ID_PRODUCTO, NOMBRE, DESCRIPCION, CATEGORIA, SUBCATEGORIA, EXISTENCIA, PRECIO FROM producto  where ID_PRODUCTO='{0}'", pCod), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pProducto.COD = _reader.GetInt32(0);
                pProducto.NOMBRE = _reader.GetString(1);
                pProducto.DESCRIPCION = _reader.GetString(2);
                pProducto.CATEGORIA = _reader.GetString(3);
                pProducto.SUBCATEGORIA = _reader.GetString(4);
                pProducto.EXISTENCIA = _reader.GetInt32(5);
                pProducto.PRECIO = _reader.GetFloat(6);

            }

            conexion.Close();
            return pProducto;

        }
    }
}
