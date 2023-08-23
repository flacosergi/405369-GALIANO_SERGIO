namespace _405369_Facturacion
{
    partial class FormFactura
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
            label1 = new Label();
            lbl_NumeroFactura = new Label();
            dtp_FechaFactura = new DateTimePicker();
            label2 = new Label();
            cbo_FormaPago = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            cbo_producto = new ComboBox();
            GrupoDetalle = new GroupBox();
            btn_agregar = new Button();
            label6 = new Label();
            txt_Cantidad = new TextBox();
            label5 = new Label();
            dgv_detalle = new DataGridView();
            IDProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            Accion = new DataGridViewButtonColumn();
            GrupoDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_detalle).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 36);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 0;
            label1.Text = "Factura N°";
            // 
            // lbl_NumeroFactura
            // 
            lbl_NumeroFactura.AutoSize = true;
            lbl_NumeroFactura.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NumeroFactura.Location = new Point(148, 36);
            lbl_NumeroFactura.Name = "lbl_NumeroFactura";
            lbl_NumeroFactura.Size = new Size(26, 21);
            lbl_NumeroFactura.TabIndex = 1;
            lbl_NumeroFactura.Text = "    ";
            // 
            // dtp_FechaFactura
            // 
            dtp_FechaFactura.Format = DateTimePickerFormat.Short;
            dtp_FechaFactura.Location = new Point(146, 74);
            dtp_FechaFactura.Name = "dtp_FechaFactura";
            dtp_FechaFactura.Size = new Size(170, 23);
            dtp_FechaFactura.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(53, 80);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha";
            // 
            // cbo_FormaPago
            // 
            cbo_FormaPago.FormattingEnabled = true;
            cbo_FormaPago.Location = new Point(146, 106);
            cbo_FormaPago.Name = "cbo_FormaPago";
            cbo_FormaPago.Size = new Size(170, 23);
            cbo_FormaPago.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(53, 109);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 5;
            label3.Text = "Forma de Pago";
            // 
            // button1
            // 
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(713, 431);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(53, 142);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 7;
            label4.Text = "Cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 139);
            textBox1.MaxLength = 100;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(374, 23);
            textBox1.TabIndex = 8;
            // 
            // cbo_producto
            // 
            cbo_producto.FormattingEnabled = true;
            cbo_producto.Location = new Point(101, 31);
            cbo_producto.Name = "cbo_producto";
            cbo_producto.Size = new Size(243, 23);
            cbo_producto.TabIndex = 9;
            // 
            // GrupoDetalle
            // 
            GrupoDetalle.BackColor = Color.Transparent;
            GrupoDetalle.Controls.Add(btn_agregar);
            GrupoDetalle.Controls.Add(label6);
            GrupoDetalle.Controls.Add(txt_Cantidad);
            GrupoDetalle.Controls.Add(label5);
            GrupoDetalle.Controls.Add(cbo_producto);
            GrupoDetalle.ForeColor = Color.Blue;
            GrupoDetalle.Location = new Point(45, 173);
            GrupoDetalle.Name = "GrupoDetalle";
            GrupoDetalle.Size = new Size(743, 67);
            GrupoDetalle.TabIndex = 10;
            GrupoDetalle.TabStop = false;
            GrupoDetalle.Text = "Detalle";
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(631, 31);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 13;
            btn_agregar.Text = "Agregar Detalle";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(362, 37);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 12;
            label6.Text = "Cantidad";
            // 
            // txt_Cantidad
            // 
            txt_Cantidad.Location = new Point(434, 31);
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.Size = new Size(100, 23);
            txt_Cantidad.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(8, 34);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 10;
            label5.Text = "Producto";
            // 
            // dgv_detalle
            // 
            dgv_detalle.AllowUserToAddRows = false;
            dgv_detalle.AllowUserToDeleteRows = false;
            dgv_detalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_detalle.Columns.AddRange(new DataGridViewColumn[] { IDProducto, NombreProducto, Cantidad, Precio, Subtotal, Accion });
            dgv_detalle.Location = new Point(45, 257);
            dgv_detalle.Name = "dgv_detalle";
            dgv_detalle.ReadOnly = true;
            dgv_detalle.RowTemplate.Height = 25;
            dgv_detalle.Size = new Size(743, 150);
            dgv_detalle.TabIndex = 11;
            // 
            // IDProducto
            // 
            IDProducto.HeaderText = "IDProducto";
            IDProducto.Name = "IDProducto";
            IDProducto.ReadOnly = true;
            IDProducto.Visible = false;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre Producto";
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            NombreProducto.Width = 300;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "SubTotal";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // Accion
            // 
            Accion.HeaderText = "Accion";
            Accion.Name = "Accion";
            Accion.ReadOnly = true;
            Accion.Width = 80;
            // 
            // FormFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 466);
            Controls.Add(dgv_detalle);
            Controls.Add(GrupoDetalle);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(cbo_FormaPago);
            Controls.Add(label2);
            Controls.Add(dtp_FechaFactura);
            Controls.Add(lbl_NumeroFactura);
            Controls.Add(label1);
            Name = "FormFactura";
            Text = "Factura";
            Load += FormFactura_Load;
            GrupoDetalle.ResumeLayout(false);
            GrupoDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_detalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_NumeroFactura;
        private DateTimePicker dtp_FechaFactura;
        private Label label2;
        private ComboBox cbo_FormaPago;
        private Label label3;
        private Button button1;
        private Label label4;
        private TextBox textBox1;
        private ComboBox cbo_producto;
        private GroupBox GrupoDetalle;
        private Label label6;
        private TextBox txt_Cantidad;
        private Label label5;
        private Button btn_agregar;
        private DataGridView dgv_detalle;
        private DataGridViewTextBoxColumn IDProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewButtonColumn Accion;
    }
}