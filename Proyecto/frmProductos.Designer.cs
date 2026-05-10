namespace Proyecto
{
    partial class frmProductos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVantasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tNombreProducto = new System.Windows.Forms.TextBox();
            this.tPrecio = new System.Windows.Forms.TextBox();
            this.nUtilidad = new System.Windows.Forms.NumericUpDown();
            this.nStock = new System.Windows.Forms.NumericUpDown();
            this.tID = new System.Windows.Forms.TextBox();
            this.dVencimiento = new System.Windows.Forms.DateTimePicker();
            this.nTemperatura = new System.Windows.Forms.NumericUpDown();
            this.tGarantia = new System.Windows.Forms.TextBox();
            this.nVoltaje = new System.Windows.Forms.NumericUpDown();
            this.panelPerecederos = new System.Windows.Forms.Panel();
            this.panelElectronico = new System.Windows.Forms.Panel();
            this.cCategoria = new System.Windows.Forms.ComboBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.lID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUtilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTemperatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVoltaje)).BeginInit();
            this.panelPerecederos.SuspendLayout();
            this.panelElectronico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.registrarProductosToolStripMenuItem,
            this.almacenarPedidosToolStripMenuItem,
            this.registroDeVantasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1213, 30);
            this.menuStrip1.TabIndex = 0;
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
            this.registrarProductosToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.registrarProductosToolStripMenuItem.Text = "Registrar productos";
            this.registrarProductosToolStripMenuItem.Click += new System.EventHandler(this.registrarProductosToolStripMenuItem_Click);
            // 
            // almacenarPedidosToolStripMenuItem
            // 
            this.almacenarPedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPedidosToolStripMenuItem});
            this.almacenarPedidosToolStripMenuItem.Name = "almacenarPedidosToolStripMenuItem";
            this.almacenarPedidosToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.almacenarPedidosToolStripMenuItem.Text = "Almacenar pedidos";
            this.almacenarPedidosToolStripMenuItem.Click += new System.EventHandler(this.almacenarPedidosToolStripMenuItem_Click);
            // 
            // verPedidosToolStripMenuItem
            // 
            this.verPedidosToolStripMenuItem.Name = "verPedidosToolStripMenuItem";
            this.verPedidosToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.verPedidosToolStripMenuItem.Text = "Ver pedidos";
            this.verPedidosToolStripMenuItem.Click += new System.EventHandler(this.verPedidosToolStripMenuItem_Click);
            // 
            // registroDeVantasToolStripMenuItem
            // 
            this.registroDeVantasToolStripMenuItem.Name = "registroDeVantasToolStripMenuItem";
            this.registroDeVantasToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.registroDeVantasToolStripMenuItem.Text = "Registro de vantas";
            this.registroDeVantasToolStripMenuItem.Click += new System.EventHandler(this.registroDeVantasToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio Base:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Utilidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Categoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de Vencimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Temperatura:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Meses de Garantia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Voltaje:";
            // 
            // tNombreProducto
            // 
            this.tNombreProducto.Location = new System.Drawing.Point(275, 42);
            this.tNombreProducto.Name = "tNombreProducto";
            this.tNombreProducto.Size = new System.Drawing.Size(156, 28);
            this.tNombreProducto.TabIndex = 16;
            // 
            // tPrecio
            // 
            this.tPrecio.Location = new System.Drawing.Point(275, 97);
            this.tPrecio.Name = "tPrecio";
            this.tPrecio.Size = new System.Drawing.Size(156, 28);
            this.tPrecio.TabIndex = 17;
            // 
            // nUtilidad
            // 
            this.nUtilidad.Location = new System.Drawing.Point(275, 151);
            this.nUtilidad.Name = "nUtilidad";
            this.nUtilidad.Size = new System.Drawing.Size(156, 28);
            this.nUtilidad.TabIndex = 23;
            // 
            // nStock
            // 
            this.nStock.Location = new System.Drawing.Point(275, 220);
            this.nStock.Name = "nStock";
            this.nStock.Size = new System.Drawing.Size(156, 28);
            this.nStock.TabIndex = 24;
            // 
            // tID
            // 
            this.tID.Location = new System.Drawing.Point(275, 291);
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(156, 28);
            this.tID.TabIndex = 25;
            // 
            // dVencimiento
            // 
            this.dVencimiento.Location = new System.Drawing.Point(28, 61);
            this.dVencimiento.Name = "dVencimiento";
            this.dVencimiento.Size = new System.Drawing.Size(200, 28);
            this.dVencimiento.TabIndex = 26;
            // 
            // nTemperatura
            // 
            this.nTemperatura.Location = new System.Drawing.Point(28, 162);
            this.nTemperatura.Name = "nTemperatura";
            this.nTemperatura.Size = new System.Drawing.Size(120, 28);
            this.nTemperatura.TabIndex = 27;
            // 
            // tGarantia
            // 
            this.tGarantia.Location = new System.Drawing.Point(29, 62);
            this.tGarantia.Name = "tGarantia";
            this.tGarantia.Size = new System.Drawing.Size(168, 28);
            this.tGarantia.TabIndex = 28;
            // 
            // nVoltaje
            // 
            this.nVoltaje.Location = new System.Drawing.Point(29, 149);
            this.nVoltaje.Name = "nVoltaje";
            this.nVoltaje.Size = new System.Drawing.Size(120, 28);
            this.nVoltaje.TabIndex = 29;
            // 
            // panelPerecederos
            // 
            this.panelPerecederos.Controls.Add(this.label6);
            this.panelPerecederos.Controls.Add(this.dVencimiento);
            this.panelPerecederos.Controls.Add(this.label7);
            this.panelPerecederos.Controls.Add(this.nTemperatura);
            this.panelPerecederos.Location = new System.Drawing.Point(228, 391);
            this.panelPerecederos.Name = "panelPerecederos";
            this.panelPerecederos.Size = new System.Drawing.Size(269, 207);
            this.panelPerecederos.TabIndex = 31;
            // 
            // panelElectronico
            // 
            this.panelElectronico.Controls.Add(this.label8);
            this.panelElectronico.Controls.Add(this.tGarantia);
            this.panelElectronico.Controls.Add(this.nVoltaje);
            this.panelElectronico.Controls.Add(this.label9);
            this.panelElectronico.Location = new System.Drawing.Point(249, 391);
            this.panelElectronico.Name = "panelElectronico";
            this.panelElectronico.Size = new System.Drawing.Size(245, 214);
            this.panelElectronico.TabIndex = 32;
            // 
            // cCategoria
            // 
            this.cCategoria.FormattingEnabled = true;
            this.cCategoria.Items.AddRange(new object[] {
            "Perecederos",
            "Electronicos"});
            this.cCategoria.Location = new System.Drawing.Point(275, 345);
            this.cCategoria.Name = "cCategoria";
            this.cCategoria.Size = new System.Drawing.Size(156, 30);
            this.cCategoria.TabIndex = 33;
            this.cCategoria.SelectedIndexChanged += new System.EventHandler(this.cCategoria_SelectedIndexChanged);
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(810, 445);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(115, 39);
            this.bGuardar.TabIndex = 34;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(58, 291);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(27, 24);
            this.lID.TabIndex = 35;
            this.lID.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(520, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(670, 243);
            this.dataGridView1.TabIndex = 37;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1213, 695);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lID);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.cCategoria);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.nStock);
            this.Controls.Add(this.nUtilidad);
            this.Controls.Add(this.tPrecio);
            this.Controls.Add(this.tNombreProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelPerecederos);
            this.Controls.Add(this.panelElectronico);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductos";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProductos_FormClosing);
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUtilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTemperatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVoltaje)).EndInit();
            this.panelPerecederos.ResumeLayout(false);
            this.panelPerecederos.PerformLayout();
            this.panelElectronico.ResumeLayout(false);
            this.panelElectronico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tNombreProducto;
        private System.Windows.Forms.TextBox tPrecio;
        private System.Windows.Forms.NumericUpDown nUtilidad;
        private System.Windows.Forms.NumericUpDown nStock;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.DateTimePicker dVencimiento;
        private System.Windows.Forms.NumericUpDown nTemperatura;
        private System.Windows.Forms.TextBox tGarantia;
        private System.Windows.Forms.NumericUpDown nVoltaje;
        private System.Windows.Forms.Panel panelPerecederos;
        private System.Windows.Forms.Panel panelElectronico;
        private System.Windows.Forms.ComboBox cCategoria;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem registrarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenarPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeVantasToolStripMenuItem;
    }
}

