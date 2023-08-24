using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _405369_Facturacion
{
    public class Detalle_Factura
    {
        public int ID_Detalle_Factura { get; set; }
        public int NroFactura { get; set; }
        public Articulo articulo { get; set; }
        public int Cantidad { get; set; }

        public Detalle_Factura()
        {
            articulo = new Articulo();
        }

        public Detalle_Factura(Articulo art, int cant)
        {
            articulo = art;
            Cantidad = cant;
        }

        public decimal CalculaSubTotal()
        {
            return (decimal)Cantidad * articulo.Precio_Unitario;
        }


        public override string ToString()
        {
            return Cantidad + " " + articulo.Nombre_Articulo + " ";
        }

    }
}
