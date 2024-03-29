﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _405369_Facturacion
{
    public class Articulo
    {
        public int ID_Articulo { get; set; }
        public string Nombre_Articulo { get; set; }
        public decimal Precio_Unitario { get; set; }

        public Articulo()
        {
            Nombre_Articulo = string.Empty; 
        }

        public Articulo(string Nombre, decimal precio)
        {
            Nombre_Articulo = Nombre;
            Precio_Unitario = precio;
        }

        public override string ToString()
        {
            return Nombre_Articulo;
        }
    }
}
