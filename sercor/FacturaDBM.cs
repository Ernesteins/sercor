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

            MySqlCommand comando = new MySqlCommand(string.Format(
                "Insert into clientes (ID_FACTURA, ID_CLIENTE, ID_USUARIO, IVA, " +
                "TOTAL, FECHA)values ('{0}','{1}','{2}', '{3}', '{4}', '{5}')",
                pFactura.ID_FACTURA, pFactura.ID_CLIENTE, pFactura.ID_USUARIO, pFactura.IVA,
                pFactura.TOTAL, pFactura.FECHA), bdComun.obtenerConexion());

            retorno = comando.ExecuteNonQuery();

            //1 insertado | 0 error
            return retorno;
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
                pFactura.ID_CLIENTE = _reader.GetInt32(1);
                pFactura.ID_USUARIO = _reader.GetInt32(2);
                pFactura.IVA = _reader.GetFloat(3);
                pFactura.TOTAL= _reader.GetFloat(4);
                pFactura.FECHA = _reader.GetString(5);
            }
            conexion.Close();
            return pFactura;
        }
    }
}
