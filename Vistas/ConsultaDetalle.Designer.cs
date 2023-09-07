namespace _405369_Facturacion
{
    partial class ConsultaDetalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgv_detalle_factura = new DataGridView();
            Cantidad = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewComboBoxColumn();
            Unitario = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btn_cerrar = new Button();
            lbl_factura = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_detalle_factura).BeginInit();
            SuspendLayout();
            // 
            // dgv_detalle_factura
            // 
            dgv_detalle_factura.AllowUserToAddRows = false;
            dgv_detalle_factura.AllowUserToDeleteRows = false;
            dgv_detalle_factura.AllowUserToResizeColumns = false;
            dgv_detalle_factura.AllowUserToResizeRows = false;
            dgv_detalle_factura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_detalle_factura.Columns.AddRange(new DataGridViewColumn[] { Cantidad, Producto, Unitario, SubTotal });
            dgv_detalle_factura.Location = new Point(21, 76);
            dgv_detalle_factura.Name = "dgv_detalle_factura";
            dgv_detalle_factura.RowTemplate.Height = 25;
            dgv_detalle_factura.Size = new Size(564, 216);
            dgv_detalle_factura.TabIndex = 0;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 60;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Resizable = DataGridViewTriState.True;
            Producto.SortMode = DataGridViewColumnSortMode.Automatic;
            Producto.Width = 200;
            // 
            // Unitario
            // 
            Unitario.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            Unitario.DefaultCellStyle = dataGridViewCellStyle1;
            Unitario.HeaderText = "Precio Unitario";
            Unitario.Name = "Unitario";
            Unitario.Width = 120;
            // 
            // SubTotal
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            SubTotal.DefaultCellStyle = dataGridViewCellStyle2;
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.Width = 120;
            // 
            // btn_cerrar
            // 
            btn_cerrar.ForeColor = Color.Blue;
            btn_cerrar.Location = new Point(510, 298);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(75, 23);
            btn_cerrar.TabIndex = 13;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // lbl_factura
            // 
            lbl_factura.AutoSize = true;
            lbl_factura.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_factura.Location = new Point(21, 23);
            lbl_factura.Name = "lbl_factura";
            lbl_factura.Size = new Size(89, 21);
            lbl_factura.TabIndex = 14;
            lbl_factura.Text = "Factura N°";
            // 
            // ConsultaDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 330);
            Controls.Add(lbl_factura);
            Controls.Add(btn_cerrar);
            Controls.Add(dgv_detalle_factura);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ConsultaDetalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle de Factura";
            Load += ConsultaDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_detalle_factura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_detalle_factura;
        private Button btn_cerrar;
        private Label lbl_factura;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewComboBoxColumn Producto;
        private DataGridViewTextBoxColumn Unitario;
        private DataGridViewTextBoxColumn SubTotal;
    }
}