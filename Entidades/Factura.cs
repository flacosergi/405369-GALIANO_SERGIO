using System;
using System.Collections.Generic;
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

        public double CalculaTotal()
        { 
            double total = 0;
            foreach(Detalle_Factura detalle in ListaDetalle) 
            {
                total += detalle.CalculaSubTotal();
            }
            return total;
         }


    }
}
