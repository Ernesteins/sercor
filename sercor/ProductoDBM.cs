﻿using System;
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
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT ID_PRODUCTO, NOMBRE, DESCRIPCION, CATEGORIA, SUBCATEGORIA, EXISTENCIA, PRECIO, ESTADO FROM producto"), conexion);

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Producto pProducto = new Producto();

                pProducto.COD = _reader.GetString(0);
                pProducto.NOMBRE = _reader.GetString(1);
                pProducto.DESCRIPCION = _reader.GetString(2);
                pProducto.CATEGORIA= _reader.GetString(3);
                pProducto.SUBCATEGORIA= _reader.GetString(4);
                pProducto.EXISTENCIA= _reader.GetInt32(5);
                pProducto.PRECIO = _reader.GetDecimal(6);
                pProducto.ESTADO= _reader.GetInt32(7);

                _lista.Add(pProducto);
            }
            conexion.Close();
            return _lista;
        }

        public static Producto ObtenerProductoCod(string pCod)
        {
            Producto pProducto = new Producto();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT ID_PRODUCTO, NOMBRE, DESCRIPCION, CATEGORIA, SUBCATEGORIA, EXISTENCIA, PRECIO FROM producto  where ID_PRODUCTO='{0}'", pCod), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pProducto.COD = _reader.GetString(0);
                pProducto.NOMBRE = _reader.GetString(1);
                pProducto.DESCRIPCION = _reader.GetString(2);
                pProducto.CATEGORIA = _reader.GetString(3);
                pProducto.SUBCATEGORIA = _reader.GetString(4);
                pProducto.EXISTENCIA = _reader.GetInt32(5);
                pProducto.PRECIO = _reader.GetDecimal(6);

            }

            conexion.Close();
            return pProducto;

        }


        public static List<Producto> ObtenerPorFiltro(string pId, string pNombre, string pDescripcion, string pCategoria,
            string pSubcategoria)
        {
            List<Producto> _lista = new List<Producto>();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM sercordb.producto where ID_PRODUCTO='{0}' or NOMBRE='{1}' or DESCRIPCION='{2}' or CATEGORIA='{3}' or SUBCATEGORIA='{4}'", pId,
                 pNombre, pDescripcion, pCategoria, pSubcategoria), conexion);

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Producto pProducto = new Producto();

                pProducto.COD = _reader.GetString(0);
                pProducto.NOMBRE = _reader.GetString(1);
                pProducto.DESCRIPCION = _reader.GetString(2);
                pProducto.CATEGORIA = _reader.GetString(3);
                pProducto.SUBCATEGORIA = _reader.GetString(4);
                pProducto.EXISTENCIA = _reader.GetInt32(5);
                pProducto.PRECIO = _reader.GetDecimal(6);
                pProducto.ESTADO = _reader.GetInt32(7);

                _lista.Add(pProducto);
            }
            conexion.Close();
            return _lista;
        }

        public static int Agregar(Producto pProducto)
        {
            int retorno = 0;

            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "Insert into producto (ID_PRODUCTO, NOMBRE, DESCRIPCION, CATEGORIA, " +
                "SUBCATEGORIA, EXISTENCIA, PRECIO, ESTADO) " +
                "values ('{0}','{1}','{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                pProducto.COD, pProducto.NOMBRE, pProducto.DESCRIPCION, pProducto.CATEGORIA,
                pProducto.SUBCATEGORIA, pProducto.EXISTENCIA, pProducto.PRECIO, pProducto.ESTADO), conexion);

            retorno = comando.ExecuteNonQuery();

            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }
    }
}
