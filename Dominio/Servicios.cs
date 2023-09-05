using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _405369_Facturacion
{
    public class Servicios
    {


        public void CargaCombo(ComboBox combo, List<object> lista, string nombre_valuemember, string nombre_displaymember)
        {
            combo.DataSource = lista;
            combo.DisplayMember = nombre_displaymember;
            combo.ValueMember = nombre_valuemember;
            combo.SelectedIndex = -1;
        }

        public List<Forma_Pago> LeeFormasPago()
        {
            List<Forma_Pago> NuevaLista = new();
            ComandosSQL comando = new ComandosSQL();
            comando.AbreConexionConTransaccion();
            SqlDataReader? Lector = comando.EjecutaLectorSP("sp_Formas_Pago_Seleccion", new List<SqlParameter>());
            if (Lector != null)
            {
                while (Lector.Read())
                {
                    Forma_Pago NuevaFormaPago = new();
                    NuevaFormaPago.ID_Forma_Pago = Lector.GetInt32(Lector.GetOrdinal("ID_Forma_Pago"));
                    NuevaFormaPago.Detalle = Lector.GetString(Lector.GetOrdinal("Detalle"));
                    NuevaLista.Add(NuevaFormaPago);
                }
                Lector.Close();
            }
            comando.CierraConcexionConTransaccion();
            return NuevaLista;
        }

        public List<Articulo> LeeArticulos()
        {
            List<Articulo> NuevaLista = new();
            ComandosSQL comando = new ComandosSQL();
            comando.AbreConexionConTransaccion();
            SqlDataReader? Lector = comando.EjecutaLectorSP("sp_Articulos_Seleccion", new List<SqlParameter>());
            if (Lector != null)
            {
                while (Lector.Read())
                {
                    Articulo NuevoArticulo = new();
                    NuevoArticulo.ID_Articulo = Lector.GetInt32(Lector.GetOrdinal("ID_Articulo"));
                    NuevoArticulo.Nombre_Articulo = Lector.GetString(Lector.GetOrdinal("Nombre_Articulo"));
                    NuevoArticulo.Precio_Unitario = Lector.GetDecimal(Lector.GetOrdinal("Precio_Unitario"));
                    NuevaLista.Add(NuevoArticulo);
                }
                Lector.Close();
            }
            comando.CierraConcexionConTransaccion();
            return NuevaLista;
        }

        public Tuple<int, DateTime> ProximaFactura()
        {
            ComandosSQL comando = new ComandosSQL();
            comando.AbreConexionConTransaccion();
            List<SqlParameter> param = new List<SqlParameter>();
            SqlParameter p = new();
            p.ParameterName = "@Ultima_Factura";
            p.Direction = System.Data.ParameterDirection.Output;
            p.DbType = System.Data.DbType.Int32;
            param.Add(p);
            SqlParameter q = new();
            q.ParameterName = "@Ultima_Fecha";
            q.Direction = System.Data.ParameterDirection.Output;
            q.DbType = System.Data.DbType.Date;
            param.Add(q);
            comando.EjecutaSP("sp_Obtiene_Ultima_Factura", param);
            comando.CierraConcexionConTransaccion();
            if (p.Value == DBNull.Value)
                return new Tuple<int, DateTime>(0, new DateTime(DateTime.Now.Year, 1, 1));
            return new Tuple<int, DateTime>((int)p.Value, (DateTime)q.Value);
        }

        public List<Factura> CargaFacturas(DateTime desde, DateTime hasta, string cliente)
        {
            List<Factura> Nuevalista = new();
            ComandosSQL comando = new ComandosSQL();
            comando.AbreConexionConTransaccion();
            List<SqlParameter> param = new();
            param.Add(new SqlParameter("@Fecha_Desde", desde));
            param.Add(new SqlParameter("@Fecha_Hasta", hasta));
            param.Add(new SqlParameter("@Cliente", cliente));
            SqlDataReader? Lector = comando.EjecutaLectorSP("sp_Facturas_Listado", param);
            if (Lector != null)
            {
                while (Lector.Read())
                {
                    Factura NuevaFactura = new();
                    NuevaFactura.NroFactura = Lector.GetInt32(Lector.GetOrdinal("NroFactura"));
                    NuevaFactura.Fecha = Lector.GetDateTime(Lector.GetOrdinal("Fecha"));
                    NuevaFactura.ID_Forma_Pago = Lector.GetInt32(Lector.GetOrdinal("ID_Forma_Pago"));
                    NuevaFactura.Cliente = Lector.GetString(Lector.GetOrdinal("Cliente"));
                    NuevaFactura.Total = Lector.GetDecimal(Lector.GetOrdinal("Total"));
                    Nuevalista.Add(NuevaFactura);
                }
                Lector.Close();
            }
            comando.CierraConcexionConTransaccion();
            return Nuevalista;
        }

        public List<Detalle_Factura> CargaDetalle(int nro_factura)
        {
            List<Detalle_Factura> NuevaLista = new List<Detalle_Factura>();
            ComandosSQL comando = new ComandosSQL();
            comando.AbreConexionConTransaccion();
            List<SqlParameter> param = new();
            param.Add(new SqlParameter("@NumFactura", nro_factura));
            SqlDataReader? Lector = comando.EjecutaLectorSP("sp_Detalle_Factura_Listado", param);
            if (Lector != null)
            {
                while (Lector.Read())
                {
                    Detalle_Factura NuevoDetalle = new();
                    NuevoDetalle.NroFactura = Lector.GetInt32(Lector.GetOrdinal("NroFactura"));
                    NuevoDetalle.articulo.ID_Articulo = Lector.GetInt32(Lector.GetOrdinal("ID_Articulo"));
                    NuevoDetalle.Cantidad = Lector.GetInt32(Lector.GetOrdinal("Cantidad"));
                    NuevoDetalle.Precio = Lector.GetDecimal(Lector.GetOrdinal("Precio"));
                    NuevaLista.Add(NuevoDetalle);
                }
                Lector.Close();
            }

            comando.CierraConcexionConTransaccion();
            return NuevaLista;
        }

    }
}
