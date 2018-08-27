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


        public static List<Egreso> ReporteEgresos()
        {
            List<Egreso> _lista = new List<Egreso>();
            
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "Select ID_CAJA,FECHA_EGRESO,TIPO_EGRESO,BENEFICIARIO,MONTO,DESCRIPCION from egreso;"),
                conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Egreso pEgreso = new Egreso();
                pEgreso.ID_CAJA = _reader.GetInt32(0);
                pEgreso.FECHA_EGRESO = _reader.GetString(1);
                pEgreso.TIPO_EGRESO = _reader.GetString(2);
                pEgreso.MONTO = _reader.GetDecimal(3);
                pEgreso.BENEFICIARIO = _reader.GetString(4);
                pEgreso.DESCRIPCION = _reader.GetString(5);
                _lista.Add(pEgreso);
            }
            conexion.Close();
            return _lista;
        }
        public static List<Egreso> ReporteEgresosFecha(String fechainicio, string fechafin)
        {
            List<Egreso> _lista = new List<Egreso>();

            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "Select ID_CAJA,FECHA_EGRESO,TIPO_EGRESO,BENEFICIARIO,MONTO,DESCRIPCION from egreso  WHERE FECHA_EGRESO >'{0}' AND FECHA_EGRESO < '{1}';",fechainicio,fechafin),
                conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Egreso pEgreso = new Egreso();
                pEgreso.ID_CAJA = _reader.GetInt32(0);
                pEgreso.FECHA_EGRESO = _reader.GetString(1);
                pEgreso.TIPO_EGRESO = _reader.GetString(2);
                pEgreso.MONTO = _reader.GetDecimal(3);
                pEgreso.BENEFICIARIO = _reader.GetString(4);
                pEgreso.DESCRIPCION = _reader.GetString(5);
                _lista.Add(pEgreso);
            }
            conexion.Close();
            return _lista;
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
