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
            string password = "f9f524bf";

            try{
                MySqlConnection conectar = new MySqlConnection("server=" + server + ";" +
                "database=" + databaseName + ";" +
                "Uid=" + user + ";" +
                "pwd=" + password + ";" +
                "SslMode=none;");
                conectar.Open();
                return conectar;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                //MySqlConnection conectar = new MySqlConnection(null);
                //conectar.Open();
                return null;
            } 
        }
    }
}
