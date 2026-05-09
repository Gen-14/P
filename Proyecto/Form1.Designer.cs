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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ventas = new System.Windows.Forms.Button();
            this.pedidos = new System.Windows.Forms.Button();
            this.productos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ventas);
            this.panel1.Controls.Add(this.pedidos);
            this.panel1.Controls.Add(this.productos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(238, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 394);
            this.panel1.TabIndex = 5;
            // 
            // ventas
            // 
            this.ventas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ventas.Location = new System.Drawing.Point(65, 260);
            this.ventas.Name = "ventas";
            this.ventas.Size = new System.Drawing.Size(422, 65);
            this.ventas.TabIndex = 10;
            this.ventas.Text = "Registro de ventas";
            this.ventas.UseVisualStyleBackColor = false;
            this.ventas.Click += new System.EventHandler(this.ventas_Click);
            // 
            // pedidos
            // 
            this.pedidos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pedidos.Location = new System.Drawing.Point(65, 167);
            this.pedidos.Name = "pedidos";
            this.pedidos.Size = new System.Drawing.Size(422, 65);
            this.pedidos.TabIndex = 9;
            this.pedidos.Text = "Almacenar pedidos ";
            this.pedidos.UseVisualStyleBackColor = false;
            this.pedidos.Click += new System.EventHandler(this.pedidos_Click);
            // 
            // productos
            // 
            this.productos.AccessibleName = "productos";
            this.productos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.productos.Location = new System.Drawing.Point(65, 79);
            this.productos.Name = "productos";
            this.productos.Size = new System.Drawing.Size(422, 65);
            this.productos.TabIndex = 8;
            this.productos.Text = "Registrar productos";
            this.productos.UseVisualStyleBackColor = false;
            this.productos.Click += new System.EventHandler(this.productos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Menú Principal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a TechLogistix S.A";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1044, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "menu";
            this.Text = "Menú principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.menu_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ventas;
        private System.Windows.Forms.Button pedidos;
        private System.Windows.Forms.Button productos;

    }
}

