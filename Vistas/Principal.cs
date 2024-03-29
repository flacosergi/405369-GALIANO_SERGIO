﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _405369_Facturacion.Vistas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void altaDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactura f_factura = new();
            f_factura.ShowDialog(this);
        }

        private void consultaEdicionYBajaDeFacrturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFactura c_factura = new();
            c_factura.ShowDialog(this);
        }
    }
}
