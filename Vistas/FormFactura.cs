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
        DateTime ultima_fecha;
        int ultima_factura;
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
            LimpiaControles();
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
            txt_Total_Factura.Text = string.Format("{0:C2}", NuevaFactura.CalculaTotal());
            cbo_producto.Focus();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidaControles().Equals(false))
                return;

            NuevaFactura.Fecha = dtp_FechaFactura.Value;
            NuevaFactura.ID_Forma_Pago = (int)cbo_FormaPago.SelectedValue;
            NuevaFactura.Cliente = txt_cliente.Text;
            NuevaFactura.NroFactura = ultima_factura;
            ComandosSQL comando = new();
            comando.AbreConexionConTransaccion();
            NuevaFactura.GuardaFactura(comando);
            foreach (Detalle_Factura detalle in NuevaFactura.ListaDetalle)
            {
                detalle.NroFactura = NuevaFactura.NroFactura;
                detalle.GuardaDetalle(comando);
            }
            comando.CierraConcexionConTransaccion();
            MessageBox.Show("La factura fue cargada", "Información:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiaControles();
        }


        private void LimpiaControles()
        {
            Servicios servicio = new();
            Tuple<int, DateTime> nuevos_datos = servicio.ProximaFactura();
            ultima_factura = nuevos_datos.Item1 + 1;
            ultima_fecha = nuevos_datos.Item2;
            lbl_NumeroFactura.Text = ultima_factura.ToString();
            dtp_FechaFactura.Value = DateTime.Now;
            cbo_FormaPago.SelectedIndex = -1;
            txt_cliente.Text = string.Empty;
            cbo_producto.SelectedIndex = -1;
            txt_Cantidad.Text = string.Empty;
            dgv_detalle.Rows.Clear();
        }

        private bool ValidaControles()
        {
            if (dtp_FechaFactura.Value < ultima_fecha)
            {
                MessageBox.Show("La fecha no puede ser anterior a la última fecha registrada (" + ultima_fecha.ToShortDateString() + ")", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp_FechaFactura.Focus();
                return false;
            }

            if (cbo_FormaPago.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una forma de pago", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_FormaPago.Focus();
                return false;
            }

            if (txt_cliente.Text.Equals(string.Empty) || txt_cliente.Text.Length < 5)
            {
                MessageBox.Show("Ingrese el nombre del cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cliente.Focus();
                return false;
            }

            if (dgv_detalle.Rows.Count.Equals(0))
            {
                MessageBox.Show("Ingrese al menos un renglón de detalle en la factura.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_producto.Focus();
                return false;
            }
            return true;
        }

        private void dgv_detalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_detalle.Columns[e.ColumnIndex].Name == "Accion")
            {
                string contenido = (string)dgv_detalle.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (contenido == "Eliminar")
                {
                    NuevaFactura.ListaDetalle.RemoveAt(e.RowIndex);
                    dgv_detalle.Rows.RemoveAt(e.RowIndex);
                }
            
            }
        }
    }
}
