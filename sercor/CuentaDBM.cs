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

            if (_reader.HasRows)
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
