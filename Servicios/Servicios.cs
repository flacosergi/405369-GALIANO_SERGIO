using System;
using System.Collections.Generic;
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


    }
}
