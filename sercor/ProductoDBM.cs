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
           "SELECT * FROM cliente"), bdComun.obtenerConexion());

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Producto pProducto = new Producto();

                pProducto.ID_PRODUCTO = _reader.GetInt32(0);
                pProducto.ID_DETALLE = _reader.GetInt32(1);
                pProducto.NOMBRE = _reader.GetString(2);
                pProducto.DESCRIPCION = _reader.GetString(3);
                pProducto.CATEGORIA= _reader.GetString(4);
                pProducto.SUBCATEGORIA= _reader.GetString(5);
                pProducto.EXISTENCIA= _reader.GetInt32(6);
                pProducto.PRECIO = _reader.GetFloat(7);
                pProducto.ESTADO= _reader.GetInt32(8);

                _lista.Add(pProducto);
            }
            return _lista;
        }
    }
}
