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
            if (dtp_FechaDesde.Value > dtp_FechaHasta.Value)
            {
                MessageBox.Show("La fecha desde no puede ser posterior a la fecha hasta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgv_ConsultaFacturas.AutoGenerateColumns = false;



        }
    }
}
