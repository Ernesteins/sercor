using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace sercor
{
    public class FacturaDBM
    {
        public static int Agregar(Factura pFactura)
        {
            int retorno = 0;
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "Insert into factura values ('{0}','{1}','{2}', '{3}', '{4}', '{5}','{6}','{7}','{8}','{9}','{10}','{11}')",
                pFactura.ID_FACTURA, pFactura.ID_CLIENTE, pFactura.ID_USUARIO, pFactura.ID_DETALLE, pFactura.ID_CUENTA, pFactura.IVA,
                pFactura.TOTAL, pFactura.FECHA, pFactura.FACTOR_DESCUENTO, pFactura.VALOR_DESCONTADO, pFactura.TIPO, pFactura.INDICE), conexion);
            retorno = comando.ExecuteNonQuery();

            //1 insertado | 0 error
            conexion.Close();
            return retorno;
        }

        public static String  obtenerFechaSistema()
        {
            MySqlConnection conexion = bdComun.obtenerConexion();
            MySqlCommand comando = new MySqlCommand("select date_format(now(),\"%Y-%m-%d %H:%m:%s\")",conexion);
            MySqlDataReader _reader = comando.ExecuteReader();
            _reader.Read();
            String fechaHora = _reader.GetString(0);
            //fechaHora = fechaHora.Replace("/", "-");
            conexion.Close();
            return fechaHora;
        }


        //Inutilizada por nuevo metodo
        public static Factura UltimoID()
        {
            Factura pFactura = new Factura();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM factura order by ID_FACTURA DESC LIMIT 1;"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pFactura.ID_FACTURA = _reader.GetInt32(0);
                pFactura.ID_CLIENTE = _reader.GetString(1);
                pFactura.ID_USUARIO = _reader.GetInt32(2);
                pFactura.IVA = _reader.GetDecimal(3);
                pFactura.TOTAL= _reader.GetDecimal(4);
                pFactura.FECHA = _reader.GetString(5);
            }
            conexion.Close();
            return pFactura;
        }

        public static List<Factura> Historial(string idCliente)
        {
            List<Factura> _lista = new List<Factura>();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM factura where ID_CLIENTE='{0}'",idCliente), conexion);

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Factura pFactura = new Factura();

                pFactura.ID_FACTURA = _reader.GetInt32(0);
                pFactura.ID_CLIENTE = _reader.GetString(1);
                pFactura.ID_USUARIO = _reader.GetInt32(2);
                pFactura.ID_DETALLE = _reader.GetInt32(3);
                pFactura.ID_CUENTA = _reader.GetInt32(4);
                pFactura.IVA =_reader.GetDecimal(5);
                pFactura.TOTAL = _reader.GetDecimal(6);
                pFactura.FECHA = _reader.GetString(7);
                pFactura.FACTOR_DESCUENTO = _reader.GetDecimal(8);
                pFactura.VALOR_DESCONTADO = _reader.GetDecimal(9);
                pFactura.TIPO = _reader.GetInt32(10);
                pFactura.INDICE = _reader.GetInt32(11);

                _lista.Add(pFactura);
            }
            conexion.Close();
            return _lista;
        }



        public static List<FacturaImpresion> Historiala(string idCliente)
        {
            List<FacturaImpresion> _lista = new List<FacturaImpresion>();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM factura where ID_CLIENTE='{0}'", idCliente), conexion);

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                FacturaImpresion pFactura = new FacturaImpresion();

                pFactura.Codigo = _reader.GetString(1);
                pFactura.Descripcion = _reader.GetString(2);
                pFactura.Cantidad = _reader.GetInt32(3);

                pFactura.ValorUnitario= _reader.GetDecimal(5);
                pFactura.ValorTotal = _reader.GetDecimal(6);

                _lista.Add(pFactura);
            }
            conexion.Close();
            return _lista;
        }

        public static Factura UltimoIndice(int tipo)
        {
            Factura pFactura = new Factura();
            MySqlConnection conexion = bdComun.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM factura WHERE tipo='{0}' order by indice DESC LIMIT 1;",tipo), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pFactura.ID_FACTURA = _reader.GetInt32(0);
                pFactura.ID_CLIENTE = _reader.GetString(1);
                pFactura.ID_USUARIO = _reader.GetInt32(2);
                pFactura.ID_DETALLE = _reader.GetInt32(3);
                pFactura.ID_CUENTA = _reader.GetInt32(4);
                pFactura.IVA = _reader.GetDecimal(5);
                pFactura.TOTAL = _reader.GetDecimal(6);
                pFactura.FECHA = _reader.GetString(7);
                pFactura.FACTOR_DESCUENTO = _reader.GetDecimal(8);
                pFactura.VALOR_DESCONTADO = _reader.GetDecimal(9);
                pFactura.TIPO = _reader.GetInt32(10);
                pFactura.INDICE = _reader.GetInt32(11);
            }
            conexion.Close();
            return pFactura;
        }
    }
}
