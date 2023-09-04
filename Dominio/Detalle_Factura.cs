using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public decimal Precio { get; set; }

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

        public void GuardaDetalle(ComandosSQL comando)
        {
            List<SqlParameter> param = new();
            param.Add(new SqlParameter("@Nro_Factura", NroFactura));
            param.Add(new SqlParameter("@ID_Articulo", articulo.ID_Articulo));
            param.Add(new SqlParameter("@Cantidad", Cantidad));
            param.Add(new SqlParameter("Precio", Precio));
            comando.EjecutaSP("sp_Ingresa_Detalle", param);
        }


        public override string ToString()
        {
            return Cantidad + " " + articulo.Nombre_Articulo + " ";
        }

    }
}
