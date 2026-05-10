using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmVentas : Form
    {
       
         string[] meses = new string[12];

         string[] productos = new string[100];

         string[] categorias = new string[100];

         int[] cantidades = new int[100];

         int contador = 0;
         string[] ventasMes = new string[100];
        public frmVentas()
        {
            InitializeComponent();
        }
        public class Venta
        {
            public string Producto { get; set; }
            public string Categoria { get; set; }
            public int Cantidad { get; set; }
            public DateTime Fecha { get; set; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            meses[0] = "Enero";
            meses[1] = "Febrero";
            meses[2] = "Marzo";
            meses[3] = "Abril";
            meses[4] = "Mayo";
            meses[5] = "Junio";
            meses[6] = "Julio";
            meses[7] = "Agosto";
            meses[8] = "Septiembre";
            meses[9] = "Octubre";
            meses[10] = "Noviembre";
            meses[11] = "Diciembre";

            //ventasMes.Items.AddRange(meses);

            //cbCategoria.Items.Add("Perecedero");
            //cbCategoria.Items.Add("Electrónico");

            dataGridReporte.ColumnCount = 4;

            dataGridReporte.Columns[0].Name = "Mes";
            dataGridReporte.Columns[1].Name = "Producto";
            dataGridReporte.Columns[2].Name = "Categoría";
            dataGridReporte.Columns[3].Name = "Cantidad";


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bReporte_Click(object sender, EventArgs e)
        {
            dataGridReporte.Rows.Clear();

            for (int i = 0; i < contador; i++)
            {
                dataGridReporte.Rows.Add(
                    ventasMes[i],
                    productos[i],
                    categorias[i],
                    cantidades[i]
                );
            }
        }

        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu nuevoForm = new menu();
            nuevoForm.Show();
            this.Hide();
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos nuevoForm = new frmProductos();
            nuevoForm.Show();
            this.Hide();
        }

        private void almacenarPedidiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pedidos nuevoForm = new pedidos();
            nuevoForm.Show();
            this.Hide();
        }

        private void registroDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
