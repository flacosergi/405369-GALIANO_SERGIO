using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _405369_Facturacion
{
    public partial class ConsultaDetalle : Form
    {
        int num_factura;
        List<Detalle_Factura> lista_detalle;
        public ConsultaDetalle(int nro_factura, List<Detalle_Factura> lista)
        {
            InitializeComponent();
            num_factura = nro_factura;
            lista_detalle = lista;
        }

        private void ConsultaDetalle_Load(object sender, EventArgs e)
        {
            dgv_detalle_factura.DataSource = lista_detalle;
        }
    }
}
