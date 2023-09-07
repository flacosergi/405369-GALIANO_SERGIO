namespace _405369_Facturacion.Vistas
{
    partial class Principal
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
            menuStrip1 = new MenuStrip();
            factruracionToolStripMenuItem = new ToolStripMenuItem();
            altaDeFacturasToolStripMenuItem = new ToolStripMenuItem();
            consultaEdicionYBajaDeFacrturasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { factruracionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // factruracionToolStripMenuItem
            // 
            factruracionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaDeFacturasToolStripMenuItem, consultaEdicionYBajaDeFacrturasToolStripMenuItem });
            factruracionToolStripMenuItem.Name = "factruracionToolStripMenuItem";
            factruracionToolStripMenuItem.Size = new Size(85, 20);
            factruracionToolStripMenuItem.Text = "&Factruracion";
            // 
            // altaDeFacturasToolStripMenuItem
            // 
            altaDeFacturasToolStripMenuItem.Name = "altaDeFacturasToolStripMenuItem";
            altaDeFacturasToolStripMenuItem.Size = new Size(264, 22);
            altaDeFacturasToolStripMenuItem.Text = "&Alta de Facturas";
            altaDeFacturasToolStripMenuItem.Click += altaDeFacturasToolStripMenuItem_Click;
            // 
            // consultaEdicionYBajaDeFacrturasToolStripMenuItem
            // 
            consultaEdicionYBajaDeFacrturasToolStripMenuItem.Name = "consultaEdicionYBajaDeFacrturasToolStripMenuItem";
            consultaEdicionYBajaDeFacrturasToolStripMenuItem.Size = new Size(264, 22);
            consultaEdicionYBajaDeFacrturasToolStripMenuItem.Text = "&Consulta Edicion y Baja de Facrturas";
            consultaEdicionYBajaDeFacrturasToolStripMenuItem.Click += consultaEdicionYBajaDeFacrturasToolStripMenuItem_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Principal";
            Text = "405369-Facturación";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem factruracionToolStripMenuItem;
        private ToolStripMenuItem altaDeFacturasToolStripMenuItem;
        private ToolStripMenuItem consultaEdicionYBajaDeFacrturasToolStripMenuItem;
    }
}