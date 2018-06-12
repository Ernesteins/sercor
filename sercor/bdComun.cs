using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace sercor
{
    public class bdComun
    {
        //CONEXION
        public static MySqlConnection obtenerConexion()
        {
            //Variables de conexion
            string server = "127.0.0.1";
            string databaseName = "sercorDB";
            string user = "sercoruser";
            string password = "S3rc0r";

            MySqlConnection conectar = new MySqlConnection("server="+server+";" +
                "database="+databaseName+";" +
                "Uid="+user+";" +
                "pwd="+password+";" +
                "SslMode=none;");
            conectar.Open();
            return conectar;
        }
    }
}
