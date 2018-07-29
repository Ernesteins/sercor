using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace sercor
{
    public class UsuarioDBM
    {


        public static int Agregar(Usuario pUsuario)
        {
            int retorno = 0;

            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "Insert into usuario (ID_USUARIO, TIPO, USUARIO, CONTRASENA, " +
                "NOMBRE, APELLIDO, CEDULA, DIRECCION, TELEFONO, PRIVILEGIO1, PRIVILEGIO2) " +
                "values ('{0}','{1}','{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')",
                pUsuario.ID_USUARIO, pUsuario.TIPO, pUsuario.USUARIO, pUsuario.CONTRASENA, pUsuario.NOMBRE,
                pUsuario.APELLIDO, pUsuario.CEDULA, pUsuario.DIRECCION, pUsuario.TELEFONO,
                pUsuario.PRIVILEGIO1, pUsuario.PRIVILEGIO2
                ),conexion);
            retorno = comando.ExecuteNonQuery();

            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }

        public static Usuario UltimoUsuario()
        {
            Usuario pUsuario = new Usuario();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM usuario order by ID_USUARIO DESC LIMIT 1"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pUsuario.ID_USUARIO = _reader.GetInt32(0);
                pUsuario.TIPO = _reader.GetInt32(1);
                pUsuario.USUARIO = _reader.GetString(2);
                pUsuario.CONTRASENA = _reader.GetString(3);
                pUsuario.NOMBRE = _reader.GetString(4);
                pUsuario.APELLIDO = _reader.GetString(5);
                pUsuario.CEDULA = _reader.GetString(6);
                pUsuario.DIRECCION = _reader.GetString(7);
                pUsuario.TELEFONO = _reader.GetString(8);
                pUsuario.PRIVILEGIO1 = _reader.GetInt32(9);
                pUsuario.PRIVILEGIO2 = _reader.GetInt32(10);

            }

            conexion.Close();
            return pUsuario;
        }

        //PARA OBTENER VARIOS USUARIOS
        public static List<Usuario> Buscar(string pUser)
        {
            List<Usuario> _lista = new List<Usuario>();

            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT * FROM usuario  where USUARIO ='{0}'", pUser), conexion);
            // or contrasena='{1}' 
            //, pContrasena

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Usuario pUsuario = new Usuario();

                pUsuario.ID_USUARIO = _reader.GetInt32(0);
                pUsuario.TIPO = _reader.GetInt32(1);
                pUsuario.USUARIO = _reader.GetString(2);
                pUsuario.CONTRASENA = _reader.GetString(3);
                pUsuario.NOMBRE = _reader.GetString(4);
                pUsuario.APELLIDO = _reader.GetString(5);
                pUsuario.CEDULA = _reader.GetString(6);
                pUsuario.DIRECCION = _reader.GetString(7);
                pUsuario.TELEFONO = _reader.GetString(8);
                pUsuario.PRIVILEGIO1 = _reader.GetInt32(9);
                pUsuario.PRIVILEGIO2 = _reader.GetInt32(10);

                _lista.Add(pUsuario);
            }
            conexion.Close();
            return _lista;
        }

        public static List<Usuario> Usuarios()
        {
            List<Usuario> _lista = new List<Usuario>();

            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT * FROM usuario"), conexion);
            // or contrasena='{1}' 
            //, pContrasena

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Usuario pUsuario = new Usuario();

                pUsuario.ID_USUARIO = _reader.GetInt32(0);
                pUsuario.TIPO = _reader.GetInt32(1);
                pUsuario.USUARIO = _reader.GetString(2);
                pUsuario.CONTRASENA = _reader.GetString(3);
                pUsuario.NOMBRE = _reader.GetString(4);
                pUsuario.APELLIDO = _reader.GetString(5);
                pUsuario.CEDULA = _reader.GetString(6);
                pUsuario.DIRECCION = _reader.GetString(7);
                pUsuario.TELEFONO = _reader.GetString(8);
                pUsuario.PRIVILEGIO1 = _reader.GetInt32(9);
                pUsuario.PRIVILEGIO2 = _reader.GetInt32(10);

                _lista.Add(pUsuario);
            }
            conexion.Close();
            return _lista;
        }

        //OBTENER UN SOLO USUARIO
        public static Usuario ObtenerUsuario(string pId)
        {
            Usuario pUsuario = new Usuario();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM usuario where USUARIO='{0}'", pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pUsuario.ID_USUARIO = _reader.GetInt32(0);
                pUsuario.TIPO = _reader.GetInt32(1);
                pUsuario.USUARIO = _reader.GetString(2);
                pUsuario.CONTRASENA = _reader.GetString(3);
                pUsuario.NOMBRE = _reader.GetString(4);
                pUsuario.APELLIDO = _reader.GetString(5);
                pUsuario.CEDULA = _reader.GetString(6);
                pUsuario.DIRECCION = _reader.GetString(7);
                pUsuario.TELEFONO = _reader.GetString(8);
                pUsuario.PRIVILEGIO1 = _reader.GetInt32(9);
                pUsuario.PRIVILEGIO2 = _reader.GetInt32(10);

            }

            conexion.Close();
            return pUsuario;
        }


        public static int Modificar(Usuario pUsuario, int id)
        {
            int retorno = 0;

            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "update usuario set ID_USUARIO='{0}', TIPO='{1}', USUARIO='{2}', CONTRASENA='{3}', NOMBRE='{4}'," +
                "APELLIDO='{5}', CEDULA='{6}', DIRECCION='{7}', TELEFONO='{8}', PRIVILEGIO1='{9}', PRIVILEGIO2='{10}' where ID_USUARIO='{11}'", 
                pUsuario.ID_USUARIO, pUsuario.TIPO, pUsuario.USUARIO, pUsuario.CONTRASENA, pUsuario.NOMBRE,
                pUsuario.APELLIDO, pUsuario.CEDULA, pUsuario.DIRECCION, pUsuario.TELEFONO, pUsuario.PRIVILEGIO1, pUsuario.PRIVILEGIO2, id), conexion);


            retorno = comando.ExecuteNonQuery();

            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }
    }
}