namespace _405369_Facturacion
{
    partial class ConsultaFactura
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
            label2 = new Label();
            dtp_FechaDesde = new DateTimePicker();
            label1 = new Label();
            dtp_FechaHasta = new DateTimePicker();
            txt_cliente = new TextBox();
            label4 = new Label();
            dgv_ConsultaFacturas = new DataGridView();
            NroFactura = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Accion = new DataGridViewButtonColumn();
            btn_cerrar = new Button();
            btn_consultar = new Button();
            btn_eliminar = new Button();
            btn_editar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultaFacturas).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(23, 35);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 5;
            label2.Text = "Fecha Desde";
            // 
            // dtp_FechaDesde
            // 
            dtp_FechaDesde.Format = DateTimePickerFormat.Short;
            dtp_FechaDesde.Location = new Point(116, 29);
            dtp_FechaDesde.Name = "dtp_FechaDesde";
            dtp_FechaDesde.Size = new Size(105, 23);
            dtp_FechaDesde.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(253, 35);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 7;
            label1.Text = "Fecha Hasta";
            // 
            // dtp_FechaHasta
            // 
            dtp_FechaHasta.Format = DateTimePickerFormat.Short;
            dtp_FechaHasta.Location = new Point(346, 29);
            dtp_FechaHasta.Name = "dtp_FechaHasta";
            dtp_FechaHasta.Size = new Size(86, 23);
            dtp_FechaHasta.TabIndex = 6;
            // 
            // txt_cliente
            // 
            txt_cliente.Location = new Point(116, 73);
            txt_cliente.MaxLength = 100;
            txt_cliente.Name = "txt_cliente";
            txt_cliente.Size = new Size(614, 23);
            txt_cliente.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(22, 76);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 9;
            label4.Text = "Cliente";
            // 
            // dgv_ConsultaFacturas
            // 
            dgv_ConsultaFacturas.AllowUserToAddRows = false;
            dgv_ConsultaFacturas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_ConsultaFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_ConsultaFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ConsultaFacturas.Columns.AddRange(new DataGridViewColumn[] { NroFactura, Fecha, Cliente, Total, Accion });
            dgv_ConsultaFacturas.Location = new Point(22, 119);
            dgv_ConsultaFacturas.MultiSelect = false;
            dgv_ConsultaFacturas.Name = "dgv_ConsultaFacturas";
            dgv_ConsultaFacturas.ReadOnly = true;
            dgv_ConsultaFacturas.RowTemplate.Height = 25;
            dgv_ConsultaFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ConsultaFacturas.Size = new Size(714, 290);
            dgv_ConsultaFacturas.TabIndex = 11;
            dgv_ConsultaFacturas.CellContentClick += dgv_ConsultaFacturas_CellContentClick;
            // 
            // NroFactura
            // 
            NroFactura.DataPropertyName = "NroFactura";
            NroFactura.HeaderText = "Factura";
            NroFactura.Name = "NroFactura";
            NroFactura.ReadOnly = true;
            NroFactura.Width = 50;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            Fecha.DefaultCellStyle = dataGridViewCellStyle2;
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 80;
            // 
            // Cliente
            // 
            Cliente.DataPropertyName = "Cliente";
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            Cliente.Width = 300;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 120;
            // 
            // Accion
            // 
            Accion.HeaderText = "Acción";
            Accion.Name = "Accion";
            Accion.ReadOnly = true;
            // 
            // btn_cerrar
            // 
            btn_cerrar.ForeColor = Color.Blue;
            btn_cerrar.Location = new Point(660, 415);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(75, 23);
            btn_cerrar.TabIndex = 12;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_consultar
            // 
            btn_consultar.ForeColor = Color.Blue;
            btn_consultar.Location = new Point(567, 415);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(75, 23);
            btn_consultar.TabIndex = 13;
            btn_consultar.Text = "Consultar";
            btn_consultar.UseVisualStyleBackColor = true;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.ForeColor = Color.Blue;
            btn_eliminar.Location = new Point(116, 415);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(75, 23);
            btn_eliminar.TabIndex = 14;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_editar
            // 
            btn_editar.ForeColor = Color.Blue;
            btn_editar.Location = new Point(21, 415);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(75, 23);
            btn_editar.TabIndex = 15;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // ConsultaFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 450);
            Controls.Add(btn_editar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_consultar);
            Controls.Add(btn_cerrar);
            Controls.Add(dgv_ConsultaFacturas);
            Controls.Add(txt_cliente);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dtp_FechaHasta);
            Controls.Add(label2);
            Controls.Add(dtp_FechaDesde);
            Name = "ConsultaFactura";
            Text = "Consultar Facturas";
            ((System.ComponentModel.ISupportInitialize)dgv_ConsultaFacturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DateTimePicker dtp_FechaDesde;
        private Label label1;
        private DateTimePicker dtp_FechaHasta;
        private TextBox txt_cliente;
        private Label label4;
        private DataGridView dgv_ConsultaFacturas;
        private Button btn_cerrar;
        private Button btn_consultar;
        private DataGridViewTextBoxColumn NroFactura;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewButtonColumn Accion;
        private Button btn_eliminar;
        private Button btn_editar;
    }
}