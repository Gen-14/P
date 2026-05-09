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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridReporte
            // 
            this.dataGridReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReporte.Location = new System.Drawing.Point(81, 83);
            this.dataGridReporte.Name = "dataGridReporte";
            this.dataGridReporte.RowTemplate.Height = 24;
            this.dataGridReporte.Size = new System.Drawing.Size(949, 344);
            this.dataGridReporte.TabIndex = 0;
            this.dataGridReporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bReporte
            // 
            this.bReporte.Location = new System.Drawing.Point(505, 469);
            this.bReporte.Name = "bReporte";
            this.bReporte.Size = new System.Drawing.Size(98, 36);
            this.bReporte.TabIndex = 1;
            this.bReporte.Text = "Reporte";
            this.bReporte.UseVisualStyleBackColor = true;
            this.bReporte.Click += new System.EventHandler(this.bReporte_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1125, 624);
            this.Controls.Add(this.bReporte);
            this.Controls.Add(this.dataGridReporte);
            this.Name = "frmVentas";
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridReporte;
        private System.Windows.Forms.Button bReporte;
    }
}