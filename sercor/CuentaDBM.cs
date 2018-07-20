using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sercor
{
    class CuentaDBM
    {
        public static List<Cuenta> ObtenerCuentas()
        {
            List<Cuenta> _lista = new List<Cuenta>();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT * FROM sercordb.Cuenta"), conexion);

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Cuenta cxcCuenta = new Cuenta();

                cxcCuenta.ID_CUENTA = _reader.GetInt32(0);
                cxcCuenta.ID_CLIENTE= _reader.GetString(1);
                cxcCuenta.TOTAL = _reader.GetDecimal(4);
                cxcCuenta.FORMA_P = _reader.GetInt32(5);
                cxcCuenta.SALDO= _reader.GetDecimal(6);
                cxcCuenta.ESTADO_P = _reader.GetInt32(7);
                
                _lista.Add(cxcCuenta);
            }
            conexion.Close();
            return _lista;
        }
        public static int Agregar(Cuenta cxcCuenta)
        {
            int retorno = 0;
            MySqlConnection conexion = bdComun.obtenerConexion(); 
            MySqlCommand comando = new MySqlCommand(string.Format(
                "Insert into Cuenta values ({0},'{1}',{2},{3},'{4}','{5}','{6}')",
                cxcCuenta.ID_CUENTA, cxcCuenta.ID_CLIENTE, cxcCuenta.ID_FACTURA, 
                cxcCuenta.TOTAL, cxcCuenta.FORMA_P, cxcCuenta.SALDO, cxcCuenta.ESTADO_P), conexion);

            retorno = comando.ExecuteNonQuery();

            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }
        public static int ultimacuenta()
        {
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand("select max(ID_CUENTA) from Cuenta;", conexion);
            MySqlDataReader _reader = comando.ExecuteReader();
            int last = 0;
            try {
                _reader.Read();
                last = _reader.GetInt32(0);
            } catch(System.Data.SqlTypes.SqlNullValueException) { last = 0; }

            conexion.Close();
            return last;
        }

    }
}
