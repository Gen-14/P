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
        private const string ArchivoPedidos = "pedidos.txt";

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

        private class ProductoReporte
        {
            public double Precio { get; set; }

            public string Categoria { get; set; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GenerarReporteVentas();
        }

        private void GenerarReporteVentas()
        {
            try
            {
                InicializarMeses();
                ConfigurarGrid();
                LimpiarReporte();
                CargarVentasDesdePedidos();
                CargarReporte();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al generar el reporte de ventas: " + ex.Message);
            }
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
            dataGridReporte.Columns.Clear();
            dataGridReporte.ColumnCount = 3;
            dataGridReporte.Columns[0].Name = "Mes";
            dataGridReporte.Columns[1].Name = "Perecederos";
            dataGridReporte.Columns[2].Name = "Electronicos";

            dataGridReporte.AllowUserToAddRows = false;
            dataGridReporte.ReadOnly = true;
        }

        private void LimpiarReporte()
        {
            for (int i = 0; i < 12; i++)
            {
                reporteVentas[i, 0] = 0;
                reporteVentas[i, 1] = 0;
            }
        }

        private Dictionary<int, ProductoReporte> CargarProductosDesdeTxt()
        {
            Dictionary<int, ProductoReporte> productos = new Dictionary<int, ProductoReporte>();

            if (!File.Exists(ArchivoProductos))
            {
                MessageBox.Show("No existe productos.txt");
                return productos;
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

                int idProducto;
                double precio;

                if (!int.TryParse(datos[0], out idProducto) ||
                    !double.TryParse(datos[2], NumberStyles.Any, CultureInfo.InvariantCulture, out precio))
                {
                    continue;
                }

                productos[idProducto] = new ProductoReporte()
                {
                    Precio = precio,
                    Categoria = datos[4].Trim()
                };
            }

            return productos;
        }

        private void CargarVentasDesdePedidos()
        {
            Dictionary<int, ProductoReporte> productos = CargarProductosDesdeTxt();

            if (!File.Exists(ArchivoPedidos))
            {
                MessageBox.Show("No existe pedidos.txt");
                return;
            }

            foreach (string linea in File.ReadAllLines(ArchivoPedidos))
            {
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                string[] datos = linea.Split(',');

                if (datos.Length < 4)
                    continue;

                DateTime fechaPedido;

                if (!DateTime.TryParse(datos[1], out fechaPedido))
                    continue;

                int cantidadPedido = 1;

                if (datos.Length >= 6 && !int.TryParse(datos[5], out cantidadPedido))
                    cantidadPedido = 1;

                foreach (string productoPedido in datos[3].Split('|'))
                {
                    int idProducto;

                    if (!ObtenerIdProducto(productoPedido, out idProducto))
                        continue;

                    ProductoReporte producto;

                    if (!productos.TryGetValue(idProducto, out producto))
                        continue;

                    RegistrarVenta(producto.Categoria, producto.Precio, cantidadPedido, fechaPedido);
                }
            }
        }

        private bool ObtenerIdProducto(string productoPedido, out int idProducto)
        {
            idProducto = 0;

            if (string.IsNullOrWhiteSpace(productoPedido))
                return false;

            string texto = productoPedido.Trim();
            int posicionGuion = texto.IndexOf('-');

            if (posicionGuion > 0)
                texto = texto.Substring(0, posicionGuion).Trim();

            return int.TryParse(texto, out idProducto);
        }

        public void CargarReporte()
        {
            dataGridReporte.Rows.Clear();

            for (int i = 0; i < 12; i++)
            {
                dataGridReporte.Rows.Add(
                    meses[i],
                    reporteVentas[i, 0].ToString("N2"),
                    reporteVentas[i, 1].ToString("N2")
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

            if (string.Equals(categoria, "Electronicos", StringComparison.OrdinalIgnoreCase))
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
