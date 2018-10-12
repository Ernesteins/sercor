using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sercor
{
    class RegistroDBM
    {
        public static int Agregar(Registro pregistro)
        {
            int retorno = 0;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "INSERT INTO REGISTRO_INVENTARIO VALUES ('{0}','{1}','{2}', '{3}', '{4}')",
                pregistro.IDREGISTRO, pregistro.FECHA, pregistro.ID_PRODUCTO, pregistro.ID_PRODUCTO_V,pregistro.CANTIDAD),
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
