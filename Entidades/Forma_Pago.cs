using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _405369_Facturacion
{
    public class Forma_Pago
    {
        public int ID_Forma_Pago { get; set; }
        public string Detalle { get; set; }

        public Forma_Pago()
        {
            Detalle = string.Empty;
        }

        public Forma_Pago(string detalle)
        {
            Detalle = detalle;
        }

        public override string ToString() 
        {
            return Detalle;
        }

    }
}
