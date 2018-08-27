﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sercor
{
    class EgresoDBM
    {
        public static int Agregar(Egreso pEgreso)
        {
            int retorno = 0;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "INSERT INTO EGRESO VALUES ('{0}','{1}','{2}', '{3}', '{4}','{5}')",
                 pEgreso.ID_CAJA, pEgreso.FECHA_EGRESO, pEgreso.TIPO_EGRESO, pEgreso.MONTO, pEgreso.BENEFICIARIO, pEgreso.DESCRIPCION),
                conexion);
            retorno = comando.ExecuteNonQuery();
            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }
        public static Egreso ReporteEgresos()
        {
            Egreso pEgreso= new Egreso();
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "Select ID_PAGO, ID_CUENTA, FECHA_ABONO  , TIPO_PAGO, MONTO, DESCRIPCION, TARJETA, TIPO, REF , BANCO, CHEQUE from PAGO;"),
                conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pEgreso.ID_CAJA = _reader.GetInt32(0);
                pEgreso.FECHA_EGRESO = _reader.GetString(1);
                pEgreso.TIPO_EGRESO = _reader.GetString(2);
                pEgreso.MONTO = _reader.GetDecimal(3);
                pEgreso.BENEFICIARIO = _reader.GetString(4);
                pEgreso.DESCRIPCION = _reader.GetString(5);
            }
            conexion.Close();
            return pEgreso;
        }

        public static int UltimoEgreso()
        {
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand("select MAX(ID_CAJA) from EGRESO;", conexion);
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

    }
}
