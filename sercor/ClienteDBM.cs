using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sercor
{
    public class ClienteDBM
    {
        public static int Agregar(Cliente pCliente)
        {
            int retorno = 0;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "INSERT INTO CLIENTE VALUES ('{0}','{1}','{2}', '{3}')",
                pCliente.ID_CLIENTE,pCliente.NOMBRE,pCliente.DIRECCION,pCliente.TELEFONO),
                conexion);
            retorno = comando.ExecuteNonQuery();
            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }

        //PARA OBTENER TODOS LOS CLIENTES
        public static List<Cliente> ObtenerNombres()
        {
            List<Cliente> _lista = new List<Cliente>();
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT ID_CLIENTE, NOMBRE, DIRECCION, TELEFONO FROM cliente"),conexion);

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Cliente pCliente = new Cliente();

                pCliente.ID_CLIENTE = _reader.GetString(0);
                pCliente.NOMBRE = _reader.GetString(1);
                pCliente.DIRECCION = _reader.GetString(2);
                pCliente.TELEFONO = _reader.GetString(3);

                _lista.Add(pCliente);
            }
            conexion.Close();
            return _lista;
        }


        public static Cliente ObtenerCliente(string pId, string pNombre)
        {
            Cliente pCliente = new Cliente();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT ID_CLIENTE, NOMBRE, DIRECCION, TELEFONO FROM cliente where ID_CLIENTE='{0}' or NOMBRE='{1}'", pId, pNombre), 
                conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pCliente.ID_CLIENTE = _reader.GetString(0);
                pCliente.NOMBRE = _reader.GetString(1);
                pCliente.DIRECCION = _reader.GetString(2);
                pCliente.TELEFONO = _reader.GetString(3);

            }

            conexion.Close();
            return pCliente;

        }

        public static Boolean ExisteCliente (string pId)
        {
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT ID_CLIENTE FROM cliente where ID_CLIENTE='';", pId),
                conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            _reader.Read();

            if (_reader.HasRows)
            {
                MessageBox.Show(_reader.GetString(0));
                return true;
            }
            return false;
        }
    }
}
