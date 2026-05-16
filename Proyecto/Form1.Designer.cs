namespace Proyecto
{
    partial class menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productos = new System.Windows.Forms.Button();
            this.pedidos = new System.Windows.Forms.Button();
            this.ventas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(411, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a TechLogistix S.A";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Bisque;
            this.label3.Location = new System.Drawing.Point(570, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Menú Principal";
            // 
            // productos
            // 
            this.productos.AccessibleName = "productos";
            this.productos.BackColor = System.Drawing.Color.Transparent;
            this.productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.productos.Font = new System.Drawing.Font("Mongolian Baiti", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productos.ForeColor = System.Drawing.Color.Wheat;
            this.productos.Location = new System.Drawing.Point(50, 642);
            this.productos.Name = "productos";
            this.productos.Size = new System.Drawing.Size(422, 65);
            this.productos.TabIndex = 8;
            this.productos.Text = "Registrar productos";
            this.productos.UseVisualStyleBackColor = false;
            this.productos.Click += new System.EventHandler(this.productos_Click);
            // 
            // pedidos
            // 
            this.pedidos.BackColor = System.Drawing.Color.Transparent;
            this.pedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pedidos.Font = new System.Drawing.Font("Mongolian Baiti", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedidos.ForeColor = System.Drawing.Color.Wheat;
            this.pedidos.Location = new System.Drawing.Point(446, 423);
            this.pedidos.Name = "pedidos";
            this.pedidos.Size = new System.Drawing.Size(422, 65);
            this.pedidos.TabIndex = 9;
            this.pedidos.Text = "Almacenar pedidos ";
            this.pedidos.UseVisualStyleBackColor = false;
            this.pedidos.Click += new System.EventHandler(this.pedidos_Click);
            // 
            // ventas
            // 
            this.ventas.BackColor = System.Drawing.Color.Transparent;
            this.ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ventas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ventas.Font = new System.Drawing.Font("Mongolian Baiti", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventas.ForeColor = System.Drawing.Color.Wheat;
            this.ventas.Location = new System.Drawing.Point(907, 642);
            this.ventas.Name = "ventas";
            this.ventas.Size = new System.Drawing.Size(422, 65);
            this.ventas.TabIndex = 10;
            this.ventas.Text = "Registro de ventas";
            this.ventas.UseVisualStyleBackColor = false;
            this.ventas.Click += new System.EventHandler(this.ventas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pedidos);
            this.panel1.Location = new System.Drawing.Point(33, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 507);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(676, 756);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Salir";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Proyecto.Properties.Resources.Picsart_26_05_16_15_48_27_758;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1390, 791);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productos);
            this.Controls.Add(this.ventas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu";
            this.Text = "Menú principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button productos;
        private System.Windows.Forms.Button pedidos;
        private System.Windows.Forms.Button ventas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;

    }
}

