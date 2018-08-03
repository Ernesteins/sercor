﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sercor
{
    class PagoDBM
    {
        public static int Pagar(Pago pPago)
        {
            int retorno = 0;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "INSERT INTO PAGO VALUES ('{0}','{1}','{2}', '{3}','{4}','{5}')",
                pPago.ID_PAGO,pPago.ID_CUENTA, pPago.FECHA_ABONO, pPago.TIPO_PAGO, pPago.MONTO, pPago.DESCRIPCION),
                conexion);
            retorno = comando.ExecuteNonQuery();
            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }

        public static Pago ConsultarPagos(int ID_CUENTA)
        {
            Pago pPago = new Pago();
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT ID_PAGO, ID_CUENTA, FECHA_ABONO, TIPO_PAGO, MONTO, DESCRIPCION FROM PAGO where ID_CUENTA ='{0}' ", ID_CUENTA),
                conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pPago.ID_CUENTA = _reader.GetInt32(0);
                pPago.ID_CUENTA= _reader.GetInt32(1);
                pPago.FECHA_ABONO= _reader.GetString(2);
                pPago.TIPO_PAGO = _reader.GetInt32(3);
                pPago.MONTO = _reader.GetDecimal(4);
                pPago.DESCRIPCION = _reader.GetString(5);
            }
            conexion.Close();
            return pPago;
        }

        public static int UltimoPagoID()
        {
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand("select MAX(ID_PAGO) from PAGO;", conexion);
            MySqlDataReader _reader = comando.ExecuteReader();
            int last = 0;
            _reader.Read();
            if (!_reader.IsDBNull(0))
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
    }
}