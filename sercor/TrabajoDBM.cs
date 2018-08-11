using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sercor
{
    class TrabajoDBM
    {
        public static List<Trabajo> ObtenerTrabajos()
        {
            List<Trabajo> _lista = new List<Trabajo>();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT * FROM sercordb.trabajos"), conexion);
            
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Trabajo trTrabajo = new Trabajo();

                trTrabajo.ID = _reader.GetInt32(0);
                trTrabajo.CUENTA = _reader.GetInt32(1);
                trTrabajo.FACTURA = _reader.GetInt32(2);
                trTrabajo.FECHA_INICIO = _reader.GetString(3);                
                trTrabajo.NOMBRE = _reader.GetString(4);
                trTrabajo.ARMAZON = _reader.GetString(5);
                trTrabajo.LUNA = _reader.GetString(6);
                trTrabajo.ESTADO = _reader.GetInt32(7);
                trTrabajo.FECHA_ENTREGA = _reader.GetString(8);
                _lista.Add(trTrabajo);
            }
            conexion.Close();
            return _lista;
        }
        public static Trabajo TrabajoID(int trID)
        {
            Trabajo trTrabajo = new Trabajo();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM trabajos where ID_TRABAJO='{0}'",trID), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                trTrabajo.ID = _reader.GetInt32(0);
                trTrabajo.CUENTA = _reader.GetInt32(1);
                trTrabajo.FACTURA = _reader.GetInt32(2);
                trTrabajo.FECHA_INICIO = _reader.GetString(3);                
                trTrabajo.NOMBRE = _reader.GetString(4);
                trTrabajo.ARMAZON = _reader.GetString(5);
                trTrabajo.LUNA = _reader.GetString(6);
                trTrabajo.ESTADO = _reader.GetInt32(7);
                trTrabajo.FECHA_ENTREGA = _reader.GetString(8);

            }

            conexion.Close();
            return trTrabajo;

        }
        
        public static List<Trabajo> ObtenerPorFiltro(int trID, int trCUENTA, int trFACTURA, string trFECHA_INICIO,
            string trFECHA_ENTREGA, string trNOMBRE, string trARMAZON, string trLUNA, int trESTADO)
        {
            List<Trabajo> _lista = new List<Trabajo>();
            MySqlConnection conexion = bdComun.obtenerConexion();

            //MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM sercordb.Trabajos where ID_TRABAJO = '{0}' or ID_CUENTA = '{1}' or ID_FACTURA = '{2}' or FECHA_INICIO = '{3}' or NOMBRE_CL = '{4}' or ARMAZON = '{5}' or LUNA = '{6}' or ESTADO = '{7}' or FECHA_ENTREGA = '{8}'",
            //    trID, trCUENTA, trFACTURA, trFECHA_INICIO, trFECHA_ENTREGA, trNOMBRE, trARMAZON, trLUNA, trESTADO), conexion);
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM sercordb.Trabajos where ID_FACTURA ='{0}' or ESTADO = '{1}'", trFACTURA, trESTADO), conexion);
            
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Trabajo trTrabajo = new Trabajo();

                trTrabajo.ID = _reader.GetInt32(0);
                trTrabajo.CUENTA = _reader.GetInt32(1);
                trTrabajo.FACTURA = _reader.GetInt32(2);
                trTrabajo.FECHA_INICIO = _reader.GetString(3);                
                trTrabajo.NOMBRE = _reader.GetString(4);
                trTrabajo.ARMAZON = _reader.GetString(5);
                trTrabajo.LUNA = _reader.GetString(6);
                trTrabajo.ESTADO = _reader.GetInt32(7);
                trTrabajo.FECHA_ENTREGA = _reader.GetString(8);
                

                _lista.Add(trTrabajo);
            }
            conexion.Close();
            return _lista;
        }
        public static int Modificar(Trabajo tTrabajo, int codigo)
        {
            int retorno = 0;

            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "update trabajos set ESTADO ='{0}'where ID_TRABAJO='{1}'", tTrabajo.ESTADO, codigo), conexion);
            
            retorno = comando.ExecuteNonQuery();

            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }
        public static int Nuevo(Trabajo tTrabajo)
        {
            int retorno = 0;

            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "insert into sercordb.trabajos (ID_TRABAJO, ID_FACTURA, ID_CUENTA, FECHA_INICIO, NOMBRE_CL, ARMAZON, LUNA, ESTADO, FECHA_ENTREGA) " +
                "values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}');",
                tTrabajo.ID,tTrabajo.FACTURA,tTrabajo.CUENTA, tTrabajo.FECHA_INICIO,tTrabajo.NOMBRE,tTrabajo.ARMAZON,tTrabajo.LUNA,tTrabajo.ESTADO,tTrabajo.FECHA_ENTREGA), conexion);
            retorno = comando.ExecuteNonQuery();

            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }
        public static int ultimoTrabajo()
        {
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT MAX(ID_TRABAJO) FROM TRABAJOS;"), conexion);
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
