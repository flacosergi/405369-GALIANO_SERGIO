using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _405369_Facturacion
{
    public class Factura
    {
        public int NroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public int ID_Forma_Pago { get; set; }
        public string Cliente { get; set; }
        public decimal Total { get; set; }
        public int Estado { get; set; } //0 para nueva 1 para borrado lógico
        public List<Detalle_Factura> ListaDetalle { get; set; }

        public Factura()
        {
            Cliente = string.Empty;
            ListaDetalle = new List<Detalle_Factura>();
        }

        public Factura(int numero, DateTime fecha, int f_pago, string cliente, List<Detalle_Factura> lista_detalle)
        {
            NroFactura = numero;
            Fecha = fecha;
            ID_Forma_Pago = f_pago;
            Cliente = cliente;
            ListaDetalle = lista_detalle;
        }

        public decimal CalculaTotal()
        {
            decimal total = 0;
            foreach (Detalle_Factura detalle in ListaDetalle)
            {
                total += detalle.CalculaSubTotal();
            }
            return total;
        }

        public void GuardaFactura(ComandosSQL comando)
        {
            List<SqlParameter> param = new();
            param.Add(new SqlParameter("@Nro_Factura", NroFactura));
            param.Add(new SqlParameter("@Fecha", Fecha));
            param.Add(new SqlParameter("@ID_Forma_Pago", ID_Forma_Pago));
            param.Add(new SqlParameter("@Cliente", Cliente));
            param.Add(new SqlParameter("@Total", Total));
            param.Add(new SqlParameter("Estado", 0));
            comando.EjecutaSP("sp_Ingresa_Factura", param);
        }

    }
}
