using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace sercor
{
    public class FacturaDBM
    {
        public static int Agregar(Factura pFactura)
        {
            int retorno = 0;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "Insert into factura values ('{0}','{1}','{2}', '{3}', '{4}', '{5}','{6}','{7}')",
                pFactura.ID_FACTURA, pFactura.ID_CLIENTE, pFactura.ID_USUARIO, pFactura.IVA,
                pFactura.TOTAL, pFactura.FECHA,pFactura.FACTOR_DESCUENTO,pFactura.VALOR_DESCONTADO),conexion);

            retorno = comando.ExecuteNonQuery();

            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }
        public static String  obtenerFechaSistema()
        {
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand("select date_format(now(),\"%Y-%m-%d %H:%m:%s\")",conexion);
            MySqlDataReader _reader = comando.ExecuteReader();
            _reader.Read();
            String fechaHora = _reader.GetString(0);
            //fechaHora = fechaHora.Replace("/", "-");
            conexion.Close();
            return fechaHora;
        }

        public static Factura UltimoID()
        {
            Factura pFactura = new Factura();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM factura order by ID_FACTURA DESC LIMIT 1;"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pFactura.ID_FACTURA = _reader.GetInt32(0);
                pFactura.ID_CLIENTE = _reader.GetString(1);
                pFactura.ID_USUARIO = _reader.GetInt32(2);
                pFactura.IVA = _reader.GetDecimal(3);
                pFactura.TOTAL= _reader.GetDecimal(4);
                pFactura.FECHA = _reader.GetString(5);
            }
            conexion.Close();
            return pFactura;
        }

        public static List<Factura> Historial(string idCliente)
        {
            List<Factura> _lista = new List<Factura>();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM factura where ID_CLIENTE='{0}'",idCliente), conexion);

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Factura pFactura = new Factura();

                pFactura.ID_FACTURA = _reader.GetInt32(0);
                pFactura.ID_CLIENTE = _reader.GetString(1);
                pFactura.ID_USUARIO = _reader.GetInt32(2);
                pFactura.IVA =_reader.GetDecimal(3);
                pFactura.TOTAL = _reader.GetDecimal(4);
                pFactura.FECHA = _reader.GetString(5);

                _lista.Add(pFactura);
            }
            conexion.Close();
            return _lista;
        }
    }
}
