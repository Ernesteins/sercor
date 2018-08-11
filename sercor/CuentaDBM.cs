﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
namespace sercor
{
    class CuentaDBM
    {
        public static List<CuentaN> ObtenerCuentasN()
        {
            List<CuentaN> _lista = new List<CuentaN>();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
            "select ID_CUENTA, ID_CLIENTE, (SELECT NOMBRE FROM CLIENTE WHERE ID_CLIENTE = ID_CLIENTE) AS NOMBRE_CLIENTE, ID_FACTURA AS ID_DOCUMENTO, TOTAL, SALDO, ESTADO_P FROM sercordb.CUENTA;"), conexion);

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                CuentaN cxcCuenta = new CuentaN();

                cxcCuenta.ID_CUENTA = _reader.GetInt32(0);
                cxcCuenta.ID_CLIENTE= _reader.GetString(1);
                cxcCuenta.NOMBRE_CLIENTE = _reader.GetString(2);
                cxcCuenta.ID_DOCUMENTO= _reader.GetInt32(3);
                cxcCuenta.TOTAL = _reader.GetDecimal(4);
                cxcCuenta.SALDO= _reader.GetDecimal(5);
                cxcCuenta.ESTADO_P = _reader.GetInt32(6);
                
                _lista.Add(cxcCuenta);
            }
            conexion.Close();
            return _lista;
        }

        public static CuentaN ObtenerCuentaNporID_cuenta(int codigo)
        {
            CuentaN cxcCuenta = new CuentaN();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
            "select ID_CUENTA, ID_CLIENTE, (SELECT NOMBRE FROM CLIENTE WHERE ID_CLIENTE = ID_CLIENTE) AS NOMBRE_CLIENTE, " +
            "ID_FACTURA AS ID_DOCUMENTO,(SELECT TIPO FROM FACTURA WHERE ID_FACTURA = ID_DOCUMENTO) AS TIPO, TOTAL, SALDO, ESTADO_P FROM CUENTA WHERE ID_CUENTA ='{0}';",codigo), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            _reader.Read();

            cxcCuenta.ID_CUENTA = _reader.GetInt32(0);
            cxcCuenta.ID_CLIENTE = _reader.GetString(1);
            cxcCuenta.NOMBRE_CLIENTE = _reader.GetString(2);
            cxcCuenta.ID_DOCUMENTO = _reader.GetInt32(3);
            cxcCuenta.TIPO = _reader.GetInt32(4);
            cxcCuenta.TOTAL = _reader.GetDecimal(5);
            cxcCuenta.SALDO = _reader.GetDecimal(6);
            cxcCuenta.ESTADO_P = _reader.GetInt32(7);

            return cxcCuenta;
        }
        public static Cuenta ObtenerCuentaporID_cuenta(int codigo)
        {
            Cuenta cxcCuenta = new Cuenta();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
            "select * from cuenta where id_cuenta = '{0}';", codigo), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            _reader.Read();

            cxcCuenta.ID_CUENTA = _reader.GetInt32(0);
            cxcCuenta.ID_CLIENTE = _reader.GetString(1);
            cxcCuenta.ID_FACTURA = _reader.GetInt32(2);
            cxcCuenta.TOTAL = _reader.GetDecimal(3);
            cxcCuenta.SALDO = _reader.GetDecimal(4);
            cxcCuenta.ESTADO_P = _reader.GetInt32(5);

            return cxcCuenta;
        }

        public static int Agregar(Cuenta cxcCuenta)
        {
            int retorno = 0;
            MySqlConnection conexion = bdComun.obtenerConexion(); 
            MySqlCommand comando = new MySqlCommand(string.Format(
                "Insert into Cuenta values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                cxcCuenta.ID_CUENTA, cxcCuenta.ID_CLIENTE, cxcCuenta.ID_FACTURA, cxcCuenta.TOTAL, 
                cxcCuenta.SALDO, cxcCuenta.ESTADO_P), conexion);

            retorno = comando.ExecuteNonQuery();
            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }
        public static string clientedelacuenta(int idcuenta)
        {
            string idcliente = "";
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("select ID_cliente from Cuenta where id_cuenta = {0};",idcuenta), conexion);
            MySqlDataReader _reader = comando.ExecuteReader();
            idcliente = _reader.GetString(0);
            return idcliente;
        }
        public static int cuentadelcliente(string idcliente)
        {
            int idcuenta = 0;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("select ID_cuenta from Cuenta where id_cliente = '{0}';",idcliente), conexion);
            MySqlDataReader _reader = comando.ExecuteReader();
            idcuenta = _reader.GetInt32(0);
            return idcuenta;
        }
        public static int cuentadeldocumento(int iddocumento)
        {
            int idcuenta = 0;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("select ID_cuenta from Cuenta where id_factura = '{0}';", iddocumento), conexion);
            MySqlDataReader _reader = comando.ExecuteReader();
            idcuenta = _reader.GetInt32(0);
            return idcuenta;
        }
        public static int documentodelacuenta(int idcuenta)
        {
            int iddocumento = 0;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("select ID_factura from Cuenta where id_cuenta = '{0}';", idcuenta), conexion);
            MySqlDataReader _reader = comando.ExecuteReader();
            iddocumento = _reader.GetInt32(0);
            return iddocumento;
        }


        public static int ultimacuenta()
        {
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand("select max(ID_CUENTA) from Cuenta;", conexion);
            MySqlDataReader _reader = comando.ExecuteReader();
            int last = 0;
            _reader.Read();

            if (!_reader.IsDBNull(0))
            //if (_reader.Read())
            {
                last = _reader.GetInt32(0);
            }
            else
            {
                last = 0;
            }
            conexion.Close();
            return last;
        }

        public static decimal consultarsaldo(int idcuenta)
        {
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("select saldo from Cuenta where id_cuenta = '{0}';",idcuenta), conexion);
            MySqlDataReader _reader = comando.ExecuteReader();
            decimal saldo = 0;
            _reader.Read();

            if (!_reader.IsDBNull(0))
            //if (_reader.Read())
            {
                saldo = _reader.GetDecimal(0);
            }
            conexion.Close();

            return saldo;
        }

        public static decimal abono(int idcuenta, decimal abono)
        {
            int retorno = 1;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("select saldo from Cuenta where id_cuenta = '{0}';", idcuenta), conexion);
            MySqlDataReader _reader = comando.ExecuteReader();
            decimal saldo = 0;
            _reader.Read();

            if (!_reader.IsDBNull(0))
            //if (_reader.Read())
            {
                saldo = _reader.GetDecimal(0);
            }
            else
            {
                return -1;
            }
            conexion.Close();

            saldo= saldo - abono;
            MySqlConnection conexion1 = bdComun.obtenerConexion();
            MySqlCommand comando1 = new MySqlCommand(string.Format("update cuenta set saldo = '{0}' where id_cuenta = '{1}';", saldo, idcuenta), conexion1);
             retorno = comando1.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }
        public static decimal ultimototal(int idcuenta)
        {
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("select total from Cuenta where id_cuenta = '{0}';", idcuenta), conexion);
            MySqlDataReader _reader = comando.ExecuteReader();
            decimal total = 0;
            _reader.Read();
            if (!_reader.IsDBNull(0))
            //if (_reader.Read())
            {
                total = _reader.GetDecimal(0);
            }
            conexion.Close();
            return total;
        }
        public static int actualizarcuenta(int idcuenta, decimal saldo, decimal total)
        {
            int retorno = 0;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "update cuenta set saldo = '{0}', total = '{1}' where id_cuenta = '{2}';",
                saldo,total,idcuenta), conexion);

            retorno = comando.ExecuteNonQuery();
            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }

    }
}
