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
        public static MySqlConnection obtenerConexion(string server,string databaseName, string user, string password)
        {
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
