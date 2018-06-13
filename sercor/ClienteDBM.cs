using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace sercor
{
    public class ClienteDBM
    {
        //PARA OBTENER TODOS LOS CLIENTES
        public static List<Cliente> ObtenerNombres()
        {
            List<Cliente> _lista = new List<Cliente>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT ID_CLIENTE, NOMBRE, DIRECCION, TELEFONO FROM cliente"), bdComun.obtenerConexion());

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Cliente pCliente = new Cliente();

                pCliente.ID_CLIENTE = _reader.GetUInt32(0);
                pCliente.NOMBRE = _reader.GetString(1);
                pCliente.DIRECCION = _reader.GetString(2);
                pCliente.TELEFONO = _reader.GetString(3);

                _lista.Add(pCliente);
            }
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
                pCliente.ID_CLIENTE = _reader.GetUInt32(0);
                pCliente.NOMBRE = _reader.GetString(1);
                pCliente.DIRECCION = _reader.GetString(2);
                pCliente.TELEFONO = _reader.GetString(3);

            }

            conexion.Close();
            return pCliente;

        }

    }
}
