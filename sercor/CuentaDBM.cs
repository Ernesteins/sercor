using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                "Insert into Cuenta values ('{0}','{1}','{2}','{3}','{4}')",
                cxcCuenta.ID_CUENTA, cxcCuenta.ID_CLIENTE,cxcCuenta.TOTAL, 
                cxcCuenta.SALDO, cxcCuenta.ESTADO_P), conexion);

            retorno = comando.ExecuteNonQuery();
            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }
        public static int clientedelacuenta(int idcuenta)
        {
            int idcliente = 0;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("select ID_cliente from Cuenta where id_cuenta = {0};",idcuenta), conexion);
            MySqlDataReader _reader = comando.ExecuteReader();
            idcliente = _reader.GetInt32(0);
            return idcliente;
        }
        public static int cuentadelcliente(int idcliente)
        {
            int idcuenta = 0;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("select ID_cuenta from Cuenta where id_cliente = ;",idcliente), conexion);
            MySqlDataReader _reader = comando.ExecuteReader();
            idcuenta = _reader.GetInt32(0);
            return idcuenta;
        }


        public static int ultimacuenta()
        {
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand("select max(ID_CUENTA) from Cuenta;", conexion);
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

        public static decimal consultarsaldo(int idcuenta)
        {
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("select saldo from Cuenta where id_cuenta = '{0}';",idcuenta), conexion);
            MySqlDataReader _reader = comando.ExecuteReader();
            decimal saldo = 0;
            _reader.Read();

            if (!_reader.IsDBNull(0))
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
