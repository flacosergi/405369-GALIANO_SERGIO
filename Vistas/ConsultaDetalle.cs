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
            Servicios servicio = new();
            servicio.CargaComboDGV(Producto, servicio.LeeArticulos().OfType<object>().ToList(), "ID_Articulo", "Nombre_Articulo");
            lbl_factura.Text += " " + num_factura.ToString() + " -  Detalle de Factura";
            dgv_detalle_factura.AutoGenerateColumns = false;
            dgv_detalle_factura.DataSource = lista_detalle;
            foreach (Detalle_Factura DF in lista_detalle)
            {
                dgv_detalle_factura.Rows[lista_detalle.IndexOf(DF)].Cells["SubTotal"].Value = DF.CalculaSubTotal();
                dgv_detalle_factura.Rows[lista_detalle.IndexOf(DF)].Cells["Producto"].Value = DF.articulo.ID_Articulo;
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
