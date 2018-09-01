using System;
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

        public static Detalle ObtenerDetalle(int pDetalle)
        {
            Detalle _detalle = new Detalle();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT * FROM detalle where ID_DETALLE='{0}'", pDetalle), conexion);

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                

                _detalle.ID_DETALLE = _reader.GetInt32(0);
                _detalle.SUBTOTAL = _reader.GetDecimal(1);


            }
            conexion.Close();
            return _detalle;
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
