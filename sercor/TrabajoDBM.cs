using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            MessageBox.Show("ejecucion del comando");
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
        /*public static Trabajo TrabajoID(string trID)
        {
            Trabajo trTrabajo = new Trabajo();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM trabajos where ID_Trabajo='{0}'",trID), conexion);
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

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM sercordb.Trabajos where ID_TRABAJO = '{0}' or ID_CUENTA = '{1}' or ID_FACTURA = '{2}' or FECHA_INICIO = '{3}' or NOMBRE_CL = '{4}' or ARMAZON = '{5}' or LUNA = '{6}' or ESTADO = '{7}' or FECHA_ENTREGA = '{8}'",
                trID, trCUENTA, trFACTURA, trFECHA_INICIO, trFECHA_ENTREGA, trNOMBRE, trARMAZON, trLUNA, trESTADO), conexion);
            

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
        }*/
    }
}
