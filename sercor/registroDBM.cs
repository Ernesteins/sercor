using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sercor
{
    class registroDBM
    {
        public static int Agregar(registro pregistro)
        {
            int retorno = 0;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "INSERT INTO REGISTRO_INVENTARIO VALUES ('{0}','{1}','{2}', '{3}')",
                pregistro.IDREGISTRO, pregistro.FECHA, pregistro.ID_PRODUCTO, pregistro.ID_PRODUCTO,pregistro.ID_PRODUCTO_V),
                conexion);
            retorno = comando.ExecuteNonQuery();
            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }
        public static int UltimoRegistro()
        {
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand("select MAX(IDREGISTRO) from REGISTRO_INVENTARIO;", conexion);
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
    }
}
