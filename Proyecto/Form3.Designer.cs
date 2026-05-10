namespace Proyecto
{
    partial class verPedidos
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
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuPedidos = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pedidos";
            // 
            // listView1
            // 
            this.listView1.ForeColor = System.Drawing.Color.SeaShell;
            this.listView1.Location = new System.Drawing.Point(25, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(818, 400);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // menuPedidos
            // 
            this.menuPedidos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPedidos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.registrarProductosToolStripMenuItem,
            this.almacenarPedidosToolStripMenuItem,
            this.registroDeVentasToolStripMenuItem});
            this.menuPedidos.Location = new System.Drawing.Point(0, 0);
            this.menuPedidos.Name = "menuPedidos";
            this.menuPedidos.Size = new System.Drawing.Size(880, 28);
            this.menuPedidos.TabIndex = 7;
            this.menuPedidos.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // registrarProductosToolStripMenuItem
            // 
            this.registrarProductosToolStripMenuItem.Name = "registrarProductosToolStripMenuItem";
            this.registrarProductosToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.registrarProductosToolStripMenuItem.Text = "Registrar productos";
            // 
            // almacenarPedidosToolStripMenuItem
            // 
            this.almacenarPedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPedidosToolStripMenuItem});
            this.almacenarPedidosToolStripMenuItem.Name = "almacenarPedidosToolStripMenuItem";
            this.almacenarPedidosToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.almacenarPedidosToolStripMenuItem.Text = "Almacenar pedidos";
            this.almacenarPedidosToolStripMenuItem.Click += new System.EventHandler(this.almacenarPedidosToolStripMenuItem_Click_1);
            // 
            // verPedidosToolStripMenuItem
            // 
            this.verPedidosToolStripMenuItem.Name = "verPedidosToolStripMenuItem";
            this.verPedidosToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.verPedidosToolStripMenuItem.Text = "Ver pedidos";
            this.verPedidosToolStripMenuItem.Click += new System.EventHandler(this.verPedidosToolStripMenuItem_Click);
            // 
            // registroDeVentasToolStripMenuItem
            // 
            this.registroDeVentasToolStripMenuItem.Name = "registroDeVentasToolStripMenuItem";
            this.registroDeVentasToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.registroDeVentasToolStripMenuItem.Text = "Registro de ventas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(101, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(658, 267);
            this.dataGridView1.TabIndex = 10;
            // 
            // verPedidos
            // 
            this.AccessibleName = "verPedidos";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(880, 516);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuPedidos);
            this.Name = "verPedidos";
            this.Text = "Pedidos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.verPedidos_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuPedidos.ResumeLayout(false);
            this.menuPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuPedidos;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenarPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPedidosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}