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
           "SELECT ID_CLIENTE, NOMBRE, APELLIDO, DIRECCION, TELEFONO FROM cliente"), bdComun.obtenerConexion());

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Cliente pCliente = new Cliente();

                pCliente.ID_CLIENTE = _reader.GetUInt32(0);
                pCliente.NOMBRE = _reader.GetString(1);
                pCliente.APELLIDO = _reader.GetString(2);
                pCliente.DIRECCION = _reader.GetString(3);
                pCliente.TELEFONO = _reader.GetString(4);

                _lista.Add(pCliente);
            }
            return _lista;
        }
    }
}
