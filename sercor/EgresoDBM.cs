using MySql.Data.MySqlClient;
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
