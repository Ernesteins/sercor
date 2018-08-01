using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sercor
{
    class DetalleDBM
    {
        public static int Agregar(Detalle pDetalle)
        {
            int retorno = 0;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "Insert into detalle values ('{0}','{1}')",
                pDetalle.ID_DETALLE, pDetalle.SUBTOTAL), conexion);

            retorno = comando.ExecuteNonQuery();
            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }

        public static int UltimoDetalle()
        {
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT MAX(ID_DETALLE) FROM detalle;"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
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
