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
    public partial class FormFactura : Form
    {
        public FormFactura()
        {
            InitializeComponent();
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {
            ComandosSQL comando = new();
            comando.CargaCombo(cbo_FormaPago, "sp_Formas_Pago_Seleccion", "ID_Forma_Pago", "Detalle");
            comando.CargaCombo(cbo_producto, "sp_Articulos_Seleccion", "ID_Articulo", "Nombre_Articulo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
