using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace sercor
{
    class PagoDBM
    {
        public static int Pagar(Pago pPago)
        {
            int retorno = 0;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "INSERT INTO PAGO VALUES ('{0}','{1}','{2}', '{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                pPago.ID_PAGO,pPago.ID_CUENTA, pPago.FECHA_ABONO, pPago.TIPO_PAGO, pPago.MONTO, pPago.DESCRIPCION, pPago.TARJETA, pPago.TIPO, pPago.REF, pPago.BANCO, pPago.CHEQUE),
                conexion);
            retorno = comando.ExecuteNonQuery();
            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }

        public static int Anular(int idPago)
        {
            int retorno = 0;

            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "update pago set MONTO=0 where ID_PAGO='{0}'", idPago), conexion);


            retorno = comando.ExecuteNonQuery();

            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }

        //TCODIGO INUTIL
        public static int Modificar(Pago pPago, int idPago)
        {
            int retorno = 0;

            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "update pago set MONTO='{0}'",pPago.MONTO, idPago), conexion);


            retorno = comando.ExecuteNonQuery();

            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }

        public static List<Pago> ObtenerPagos(int id_cuenta)
        {
            List<Pago> _lista = new List<Pago>();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT ID_PAGO, ID_CUENTA, FECHA_ABONO, TIPO_PAGO, MONTO, DESCRIPCION, TARJETA, TIPO, REF, BANCO, CHEQUE FROM PAGO WHERE ID_CUENTA = '{0}'",id_cuenta), conexion);

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Pago pPago = new Pago();

                pPago.ID_PAGO= _reader.GetInt32(0);
                pPago.ID_CUENTA = _reader.GetInt32(1);
                pPago.FECHA_ABONO= _reader.GetString(2);
                pPago.TIPO_PAGO = _reader.GetInt32(3);
                pPago.MONTO = _reader.GetDecimal(4);
                pPago.DESCRIPCION = _reader.GetString(5);
                pPago.TARJETA = _reader.GetString(6);
                pPago.TIPO = _reader.GetString(7);
                pPago.REF = _reader.GetString(8);
                pPago.BANCO = _reader.GetString(9);
                pPago.CHEQUE = _reader.GetString(10);

                _lista.Add(pPago);
            }
            conexion.Close();
            return _lista;
        }

        public static List<Pago> ObtenerPagosDetalle(int id_cuenta)
        {
            List<Pago> _lista = new List<Pago>();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT * FROM PAGO WHERE ID_CUENTA = '{0}' and MONTO <> 0", id_cuenta), conexion);

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Pago pPago = new Pago();
                pPago.ID_PAGO = _reader.GetInt32(0);
                pPago.FECHA_ABONO = _reader.GetString(2);
                pPago.TIPO_PAGO = _reader.GetInt32(3);
                pPago.MONTO = _reader.GetDecimal(4);
                pPago.DESCRIPCION = _reader.GetString(5);
                pPago.TARJETA = _reader.GetString(6);
                pPago.TIPO = _reader.GetString(7);
                pPago.REF = _reader.GetString(8);
                pPago.BANCO = _reader.GetString(9);
                pPago.CHEQUE = _reader.GetString(10);

                _lista.Add(pPago);
            }
            conexion.Close();
            return _lista;
        }


        public static Pago ObtenerPagoIdPago(int idPago)
        {
            Pago pPago = new Pago();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT * FROM PAGO WHERE ID_PAGO = '{0}'", idPago), conexion);

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pPago.ID_PAGO = _reader.GetInt32(0);
                pPago.ID_CUENTA = _reader.GetInt32(1);
                pPago.FECHA_ABONO = _reader.GetString(2);
                pPago.TIPO_PAGO = _reader.GetInt32(3);
                pPago.MONTO = _reader.GetDecimal(4);
                pPago.DESCRIPCION = _reader.GetString(5);
                pPago.TARJETA = _reader.GetString(6);
                pPago.TIPO = _reader.GetString(7);
                pPago.REF = _reader.GetString(8);
                pPago.BANCO = _reader.GetString(9);
                pPago.CHEQUE = _reader.GetString(10);
            }
            conexion.Close();
            return pPago;
        }


        public static decimal sumaEgreso(string fecha1, string fecha2)
        {
            decimal total = 0;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(
           "select sum(monto) from egreso WHERE fecha_egreso between '{0}' and '{1}'", fecha1, fecha2), conexion);       
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                try
                {
                    total = _reader.GetDecimal(0);
                }
                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    total = 0;
                }
            }
            conexion.Close();
            return total;
        }


        public static decimal suma(int tipoPago, string fecha1, string fecha2) {
            //0 efectivo
            //1 tarjeta
            //2 cheque
            decimal total=0;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(
           "select sum(monto) from pago WHERE tipo_pago='{0}' and fecha_abono between '{1}' and '{2}'",tipoPago, fecha1,fecha2), conexion);


            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                try
                {
                    total = _reader.GetDecimal(0);
                }
                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    total = 0;
                }
            }
            conexion.Close();
            return total;
        }



        public static List<PagoReporte> ObtenerPagosReporte(string fecha1, string fecha2)
        {
            List<PagoReporte> _lista = new List<PagoReporte>();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT fecha_abono, monto, descripcion FROM PAGO WHERE fecha_abono between '{0}' and '{1}' union " +
           "select fecha_egreso, monto, descripcion from egreso where fecha_egreso between '{0}' and '{1}'", fecha1,fecha2), conexion);

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                PagoReporte pPago = new PagoReporte();

                pPago.FECHA_ABONO = _reader.GetString(0);
                pPago.MONTO = _reader.GetDecimal(1);
                pPago.DESCRIPCION = _reader.GetString(2);

                _lista.Add(pPago);
            }
            conexion.Close();
            return _lista;
        }

        public static List<PagoReporte> ObtenerPagosReporteFactura(string fecha1, string fecha2)
        {
            List<PagoReporte> _lista = new List<PagoReporte>();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT fecha_abono, monto, descripcion FROM PAGO WHERE fecha_abono between '{0}' and '{1}'", fecha1, fecha2), conexion);

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                PagoReporte pPago = new PagoReporte();

                pPago.FECHA_ABONO = _reader.GetString(0);
                pPago.MONTO = _reader.GetDecimal(1);
                pPago.DESCRIPCION = _reader.GetString(2);

                _lista.Add(pPago);
            }
            conexion.Close();
            return _lista;
        }


        public static List<Pago> ObtenerPagosFecha(string FechaInicio, String FechaFin)
        {
            List<Pago> _lista = new List<Pago>();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           " SELECT ID_PAGO, ID_CUENTA, FECHA_ABONO, TIPO_PAGO, MONTO, DESCRIPCION FROM PAGO WHERE FECHA_ABONO >'{0}' AND FECHA_ABONO < '{1}';",FechaInicio, FechaFin), conexion);

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Pago pPago = new Pago();

                pPago.ID_PAGO = _reader.GetInt32(0);
                pPago.ID_CUENTA = _reader.GetInt32(1);
                pPago.FECHA_ABONO = _reader.GetString(2);
                pPago.TIPO_PAGO = _reader.GetInt32(3);
                pPago.MONTO = _reader.GetDecimal(4);
                pPago.DESCRIPCION = _reader.GetString(5);

                _lista.Add(pPago);
            }
            conexion.Close();
            return _lista;
        }

        public static Pago ConsultarPagos(int ID_CUENTA)
        {
            Pago pPago = new Pago();
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT ID_PAGO, ID_CUENTA, FECHA_ABONO, TIPO_PAGO, MONTO, DESCRIPCION FROM PAGO where ID_CUENTA ='{0}' ", ID_CUENTA),
                conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pPago.ID_PAGO = _reader.GetInt32(0);
                pPago.ID_CUENTA= _reader.GetInt32(1);
                pPago.FECHA_ABONO= _reader.GetString(2);
                pPago.TIPO_PAGO = _reader.GetInt32(3);
                pPago.MONTO = _reader.GetDecimal(4);
                pPago.DESCRIPCION = _reader.GetString(5);
            }
            conexion.Close();
            return pPago;
        }



        public static Pago ConsultarUnicoPago(int ID_CUENTA)
        {
            Pago pPago = new Pago();
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT * FROM PAGO where ID_CUENTA ='{0}' ", ID_CUENTA),
                conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pPago.ID_PAGO = _reader.GetInt32(0);
                pPago.ID_CUENTA = _reader.GetInt32(1);
                pPago.FECHA_ABONO = _reader.GetString(2);
                pPago.TIPO_PAGO = _reader.GetInt32(3);
                pPago.MONTO = _reader.GetDecimal(4);
                pPago.DESCRIPCION = _reader.GetString(5);
                pPago.TARJETA = _reader.GetString(6);
                pPago.TIPO = _reader.GetString(7);
                pPago.REF = _reader.GetString(8);
                pPago.BANCO = _reader.GetString(9);
                pPago.CHEQUE = _reader.GetString(10);
            }
            conexion.Close();
            return pPago;
        }

        public static List<Pago> ReportePagos()
        {
            List<Pago> _lista = new List<Pago>();
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT ID_PAGO, ID_CUENTA, FECHA_ABONO, TIPO_PAGO, MONTO, DESCRIPCION FROM PAGO ;"),
                conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Pago pPago = new Pago();
                pPago.ID_PAGO = _reader.GetInt32(0);
                pPago.ID_CUENTA = _reader.GetInt32(1);
                pPago.FECHA_ABONO = _reader.GetString(2);
                pPago.TIPO_PAGO = _reader.GetInt32(3);
                pPago.MONTO = _reader.GetDecimal(4);
                pPago.DESCRIPCION = _reader.GetString(5);
                _lista.Add(pPago);
            }
            conexion.Close();
            return _lista;
        }

        public static int UltimoPagoID()
        {
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand("select MAX(ID_PAGO) from PAGO;", conexion);
            MySqlDataReader _reader = comando.ExecuteReader();
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

        /*public static int PagarCheque(Pago pPago)
        {
            int retorno = 0;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "INSERT INTO PAGO VALUES ('{0}','{1}','{2}', '2','{4}','{5}','{6}','{7}')",
                pPago.ID_PAGO, pPago.ID_CUENTA, pPago.FECHA_ABONO, pPago.TIPO_PAGO, pPago.MONTO, pPago.DESCRIPCION, pPago.BANCO, pPago.CHEQUE),
                conexion);
            retorno = comando.ExecuteNonQuery();
            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }

        public static int PagarTarjeta(Pago pPago)
        {
            int retorno = 0;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "INSERT INTO PAGO VALUES ('{0}','{1}','{2}', '1','{4}','{5}','{6}','{7}','{8}')",
                pPago.ID_PAGO, pPago.ID_CUENTA, pPago.FECHA_ABONO, pPago.TIPO_PAGO, pPago.MONTO, pPago.DESCRIPCION, pPago.TARJETA, pPago.TIPO,pPago.REF),
                conexion);
            retorno = comando.ExecuteNonQuery();
            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }

        public static int PagarEfectivo(Pago pPago)
        {
            int retorno = 0;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "INSERT INTO PAGO VALUES ('{0}','{1}','{2}', '0','{4}','{5}')",
                pPago.ID_PAGO, pPago.ID_CUENTA, pPago.FECHA_ABONO, pPago.TIPO_PAGO, pPago.MONTO, pPago.DESCRIPCION),
                conexion);
            retorno = comando.ExecuteNonQuery();
            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }*/
    }
}
