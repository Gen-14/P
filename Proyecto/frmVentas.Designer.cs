namespace Proyecto
{
    partial class frmVentas
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
            this.dataGridReporte = new System.Windows.Forms.DataGridView();
            this.bReporte = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenarPedidiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReporte)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridReporte
            // 
            this.dataGridReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReporte.Location = new System.Drawing.Point(81, 83);
            this.dataGridReporte.Name = "dataGridReporte";
            this.dataGridReporte.RowTemplate.Height = 24;
            this.dataGridReporte.Size = new System.Drawing.Size(649, 446);
            this.dataGridReporte.TabIndex = 0;
            // 
            // bReporte
            // 
            this.bReporte.Location = new System.Drawing.Point(798, 265);
            this.bReporte.Name = "bReporte";
            this.bReporte.Size = new System.Drawing.Size(133, 46);
            this.bReporte.TabIndex = 1;
            this.bReporte.Text = "Generar Reporte";
            this.bReporte.UseVisualStyleBackColor = true;
            this.bReporte.Click += new System.EventHandler(this.bReporte_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.registrarProductosToolStripMenuItem,
            this.almacenarPedidiosToolStripMenuItem,
            this.registroDeVentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1125, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menúToolStripMenuItem.Text = "Menú";
            this.menúToolStripMenuItem.Click += new System.EventHandler(this.menúToolStripMenuItem_Click);
            // 
            // registrarProductosToolStripMenuItem
            // 
            this.registrarProductosToolStripMenuItem.Name = "registrarProductosToolStripMenuItem";
            this.registrarProductosToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.registrarProductosToolStripMenuItem.Text = "Registrar Productos";
            this.registrarProductosToolStripMenuItem.Click += new System.EventHandler(this.registrarProductosToolStripMenuItem_Click);
            // 
            // almacenarPedidiosToolStripMenuItem
            // 
            this.almacenarPedidiosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPedidosToolStripMenuItem});
            this.almacenarPedidiosToolStripMenuItem.Name = "almacenarPedidiosToolStripMenuItem";
            this.almacenarPedidiosToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.almacenarPedidiosToolStripMenuItem.Text = "Almacenar Pedidios";
            this.almacenarPedidiosToolStripMenuItem.Click += new System.EventHandler(this.almacenarPedidiosToolStripMenuItem_Click);
            // 
            // verPedidosToolStripMenuItem
            // 
            this.verPedidosToolStripMenuItem.Name = "verPedidosToolStripMenuItem";
            this.verPedidosToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.verPedidosToolStripMenuItem.Text = "Ver Pedidos";
            // 
            // registroDeVentasToolStripMenuItem
            // 
            this.registroDeVentasToolStripMenuItem.Name = "registroDeVentasToolStripMenuItem";
            this.registroDeVentasToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.registroDeVentasToolStripMenuItem.Text = "Registro de Ventas";
            this.registroDeVentasToolStripMenuItem.Click += new System.EventHandler(this.registroDeVentasToolStripMenuItem_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::Proyecto.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1125, 666);
            this.Controls.Add(this.bReporte);
            this.Controls.Add(this.dataGridReporte);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmVentas";
            this.Text = "Reporte de Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVentas_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReporte)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridReporte;
        private System.Windows.Forms.Button bReporte;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenarPedidiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeVentasToolStripMenuItem;
    }
}
