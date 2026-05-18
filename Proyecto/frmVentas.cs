using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Globalization;

namespace Proyecto
{ public partial class frmVentas : Form
    {
        private const string ArchivoProductos = "productos.txt";

        // MATRIZ
        double[,] reporteVentas = new double[12, 2];

        string[] meses = new string[12];

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

            public double Precio { get; set; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GenerarReporteVentas();
        }

        private void GenerarReporteVentas()
        {
            InicializarMeses();
            ConfigurarGrid();
            LimpiarReporte();
            CargarProductosDesdeTxt();
            CargarReporte();
        }

        private void InicializarMeses()
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
        }

        private void ConfigurarGrid()
        {
            if (dataGridReporte.Columns.Count == 0)
            {
                dataGridReporte.ColumnCount = 3;
                dataGridReporte.Columns[0].Name = "Mes";
                dataGridReporte.Columns[1].Name = "Perecederos";
                dataGridReporte.Columns[2].Name = "Electronicos";
            }

            dataGridReporte.AllowUserToAddRows = false;
        }

        private void LimpiarReporte()
        {
            for (int i = 0; i < 12; i++)
            {
                reporteVentas[i, 0] = 0;
                reporteVentas[i, 1] = 0;
            }
        }

        private void CargarProductosDesdeTxt()
        {
            if (!File.Exists(ArchivoProductos))
            {
                MessageBox.Show("No existe productos.txt");
                return;
            }

            foreach (string linea in File.ReadAllLines(ArchivoProductos))
            {
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                string[] datos = linea.Split('|');

                // Compatibilidad con archivos viejos separados por coma.
                if (datos.Length == 1)
                    datos = linea.Split(',');

                if (datos.Length < 5)
                    continue;

                double precio;
                int cantidad;

                if (!double.TryParse(datos[2], NumberStyles.Any, CultureInfo.InvariantCulture, out precio) ||
                    !int.TryParse(datos[3], out cantidad))
                {
                    continue;
                }

                string categoria = datos[4];
                RegistrarVenta(categoria, precio, cantidad, DateTime.Now);
            }
        }

        public void CargarReporte()
        {
            dataGridReporte.Rows.Clear();

            for (int i = 0; i < 12; i++)
            {
                dataGridReporte.Rows.Add(
                    meses[i],
                    reporteVentas[i, 0],
                    reporteVentas[i, 1]
                );
            }
        }
    
        // METODO PARA REGISTRAR VENTAS
        public void RegistrarVenta(string categoria,
              double precio,
              int cantidad,
              DateTime fecha)
        {
            double subtotal = precio * cantidad;

            double totalConIVA = subtotal + (subtotal * 0.13);

            int filaMes = fecha.Month - 1;

            int columnaCategoria = 0;

            if (categoria == "Electronicos")
            {
                columnaCategoria = 1;
            }

            reporteVentas[filaMes, columnaCategoria] += totalConIVA;
        }
        private void bReporte_Click(object sender, EventArgs e)
        {
            GenerarReporteVentas();
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
            GenerarReporteVentas();
        }

        private void frmVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
