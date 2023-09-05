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
    public partial class ConsultaFactura : Form
    {
        public ConsultaFactura()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (dtp_FechaDesde.Value.Date > dtp_FechaHasta.Value.Date)
            {
                MessageBox.Show("La fecha desde no puede ser posterior a la fecha hasta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Servicios servicios = new Servicios();

            dgv_ConsultaFacturas.AutoGenerateColumns = false;
            List<Factura> NuevaLista = servicios.CargaFacturas(dtp_FechaDesde.Value, dtp_FechaHasta.Value, txt_cliente.Text);
            dgv_ConsultaFacturas.DataSource = NuevaLista;
            foreach (DataGridViewRow Fila in dgv_ConsultaFacturas.Rows)
            {
                Fila.Cells["Accion"].Value = "Ver Detalle";
            }
            if (NuevaLista.Count == 0)
                MessageBox.Show("No se encontraron registros.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dgv_ConsultaFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_ConsultaFacturas.Columns["Accion"].Index)
            { 
                
            
            }
        }
    }
}
