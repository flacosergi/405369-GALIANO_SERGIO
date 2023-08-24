using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace _405369_Facturacion
{
    public partial class FormFactura : Form
    {

        Factura NuevaFactura = new();
        public FormFactura()
        {
            InitializeComponent();
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {
            ComandosSQL comando = new();
            Servicios servicio = new Servicios();
            servicio.CargaCombo(cbo_FormaPago, servicio.LeeFormasPago().OfType<object>().ToList(), "ID_Forma_Pago", "Detalle");
            servicio.CargaCombo(cbo_producto, servicio.LeeArticulos().OfType<object>().ToList(), "ID_Articulo", "Nombre_Articulo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (cbo_producto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_producto.Focus();
                return;
            }

            int resultado;
            Int32.TryParse(txt_Cantidad.Text, out resultado);
            if (resultado <= 0)
            {
                MessageBox.Show("Indique una cantidad válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Cantidad.Focus();
                return;
            }
            Articulo seleccionado = (Articulo)cbo_producto.SelectedItem;
            Detalle_Factura NuevoDetalle = new();
            NuevoDetalle.articulo = seleccionado;
            NuevoDetalle.Cantidad = Int32.Parse(txt_Cantidad.Text);
            NuevaFactura.ListaDetalle.Add(NuevoDetalle);

            dgv_detalle.Rows.Add(seleccionado.ID_Articulo,
                                 seleccionado.Nombre_Articulo,
                                 NuevoDetalle.Cantidad,
                                 seleccionado.Precio_Unitario,
                                 NuevoDetalle.CalculaSubTotal(),
                                 "Eliminar");
            txt_Cantidad.Text = String.Empty;
            cbo_producto.SelectedIndex = -1;
            cbo_producto.Focus();
        }
    }
}
