using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;


namespace Proyecto
{
    public partial class frmProductos : Form
    {
        private const string ArchivoProductos = "productos.txt";
        public frmProductos()
        {
            InitializeComponent();
        }
        // Guarda los productos en un archivo de texto para mantenerlos al cerrar el programa.
        public static void archivoTxt()
        {
            List<string> lineas = new List<string>();

            foreach (producto p in lstProductos.listaProductos)
            {
                string fechaVencimiento = "";
                string temperatura = "";
                string garantia = "";
                string voltaje = "";

                productoPerecedero perecedero = p as productoPerecedero;
                if (perecedero != null)
                {
                    fechaVencimiento = perecedero.FechaVencimiento.ToString("yyyy-MM-dd");
                    temperatura = perecedero.Temperatura.ToString(CultureInfo.InvariantCulture);
                }

                productoElectronico electronico = p as productoElectronico;
                if (electronico != null)
                {
                    garantia = electronico.Garantia.ToString();
                    voltaje = electronico.Voltaje.ToString();
                }

                lineas.Add(string.Join("|", new string[]
                {
                    p.IdProducto.ToString(),
                    p.NombreProducto,
                    p.Precio.ToString(CultureInfo.InvariantCulture),
                    p.StockProducto.ToString(),
                    p.CategoriaProducto,
                    fechaVencimiento,
                    temperatura,
                    garantia,
                    voltaje
                }));
            }

            File.WriteAllLines(ArchivoProductos, lineas);
        }
        private void cCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cCategoria.SelectedItem == null)
                return;

            if (cCategoria.Text == "Perecederos")
            {
                panelPerecederos.Visible = true;
                panelElectronico.Visible = false;
            }
            else if (cCategoria.Text == "Electronicos")
            {
                panelPerecederos.Visible = false;
                panelElectronico.Visible = true;
            }
            else
            {
                panelPerecederos.Visible = false;
                panelElectronico.Visible = false;
            }
            if (cCategoria.SelectedIndex == -1)
                return;
        }
        private void frmProductos_Load(object sender, EventArgs e)
        {
            panelPerecederos.Visible = false;
            panelElectronico.Visible = false;

            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("ID", "ID");
                dataGridView1.Columns.Add("Nombre", "Nombre");
                dataGridView1.Columns.Add("Precio", "Precio");
                dataGridView1.Columns.Add("Stock", "Stock");
                dataGridView1.Columns.Add("Categoria", "Categoria");
                // Columnas extra
                dataGridView1.Columns.Add("Vencimiento", "Vencimiento");
                dataGridView1.Columns.Add("Temperatura", "Temperatura");
                dataGridView1.Columns.Add("Garantia", "Garantía");
                dataGridView1.Columns.Add("Voltaje", "Voltaje");
            }
            //no permite que se hagan filas en blanco
            dataGridView1.AllowUserToAddRows = false;
            cargarDatosTxt();
        }
        //metodo para que se limpien los campos despues de guardar el producto
        private void LimpiarCampos()
        {
            tNombreProducto.Text = "";
            tPrecio.Text = "";
            panelElectronico.Visible = false;
            panelPerecederos.Visible = false;

            nUtilidad.Value = 0;
            nStock.Value = 0;

            cCategoria.SelectedIndex = -1; // deja sin selección
            //tNombreProducto.Focus();
        }

        //
        private void bGuardar_Click(object sender, EventArgs e)
        {
            int nuevoID = 1;

            if (lstProductos.listaProductos.Count > 0)
            {
                nuevoID = lstProductos.listaProductos.Max(p => p.IdProducto) + 1;
            }
            if (string.IsNullOrWhiteSpace(tNombreProducto.Text) ||
                string.IsNullOrWhiteSpace(tPrecio.Text) ||
                //string.IsNullOrWhiteSpace(tID.Text) ||
                string.IsNullOrWhiteSpace(cCategoria.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }
            string categoriaProducto = cCategoria.Text;

            if (categoriaProducto == "Electronicos" && string.IsNullOrWhiteSpace(tGarantia.Text))
            {
                MessageBox.Show("Debe completar la garantía del producto electrónico");
                return;
            }
            decimal precioBase;
            if (!decimal.TryParse(tPrecio.Text, out precioBase))
            {
                MessageBox.Show("Ingrese un precio válido");
                return;
            }

            string nombreProducto = tNombreProducto.Text;
            int stockProducto = (int)nStock.Value;
            decimal utilidadProducto = nUtilidad.Value;
            decimal total = precioBase + (precioBase * utilidadProducto / 100);
            producto nuevo = null;

            //muestra los datos de los producto en el dataGridView
            if (categoriaProducto == "Perecederos")
            {
                nuevo = new productoPerecedero(
                    nuevoID,
                    nombreProducto,
                    total,
                    stockProducto,
                    categoriaProducto,
                    dVencimiento.Value,
                    nTemperatura.Value
                );
            }
            else if (categoriaProducto == "Electronicos")
            {
                int garantia;
                if (!int.TryParse(tGarantia.Text, out garantia))
                {
                    MessageBox.Show("Ingrese una garantía válida");
                    return;
                }

                nuevo = new productoElectronico(
                    nuevoID,
                    nombreProducto,
                    total,
                    stockProducto,
                    categoriaProducto,
                    garantia,
                    (int)nVoltaje.Value
                );
            }
            else
            {
                MessageBox.Show("Seleccione una categoría válida");
                return;
            }

            lstProductos.listaProductos.Add(nuevo);
            AgregarProductoAGrid(nuevo);
            archivoTxt();

            LimpiarCampos();

            //muestra un mesaje de que se guardo 
            MessageBox.Show("Producto guardado");

        }

        private void cargarDatosTxt()
        {
            lstProductos.listaProductos.Clear();
            dataGridView1.Rows.Clear();

            if (!File.Exists(ArchivoProductos))
                return;

            foreach (string linea in File.ReadAllLines(ArchivoProductos))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                string[] datos = linea.Split('|');

                // Compatibilidad con el formato anterior: ID,Nombre,Precio,Stock,Categoria
                if (datos.Length == 1)
                    datos = linea.Split(',');

                if (datos.Length < 5)
                    continue;

                int id;
                decimal precio;
                int stock;

                if (!int.TryParse(datos[0], out id) ||
                    !decimal.TryParse(datos[2], NumberStyles.Any, CultureInfo.InvariantCulture, out precio) ||
                    !int.TryParse(datos[3], out stock))
                {
                    continue;
                }

                string nombre = datos[1];
                string categoria = datos[4];
                producto nuevo = null;

                if (categoria == "Perecederos")
                {
                    DateTime fechaVencimiento = DateTime.Now;
                    decimal temperatura = 0;

                    if (datos.Length > 5 && !string.IsNullOrWhiteSpace(datos[5]))
                        DateTime.TryParse(datos[5], out fechaVencimiento);

                    if (datos.Length > 6 && !string.IsNullOrWhiteSpace(datos[6]))
                        decimal.TryParse(datos[6], NumberStyles.Any, CultureInfo.InvariantCulture, out temperatura);

                    nuevo = new productoPerecedero(id, nombre, precio, stock, categoria, fechaVencimiento, temperatura);
                }
                else if (categoria == "Electronicos")
                {
                    int garantia = 0;
                    int voltaje = 0;

                    if (datos.Length > 7 && !string.IsNullOrWhiteSpace(datos[7]))
                        int.TryParse(datos[7], out garantia);

                    if (datos.Length > 8 && !string.IsNullOrWhiteSpace(datos[8]))
                        int.TryParse(datos[8], out voltaje);

                    nuevo = new productoElectronico(id, nombre, precio, stock, categoria, garantia, voltaje);
                }
                else
                {
                    nuevo = new producto(id, nombre, precio, stock, categoria);
                }

                lstProductos.listaProductos.Add(nuevo);
                AgregarProductoAGrid(nuevo);
            }
        }

        private void AgregarProductoAGrid(producto p)
        {
            productoPerecedero perecedero = p as productoPerecedero;
            if (perecedero != null)
            {
                dataGridView1.Rows.Add(
                    perecedero.IdProducto,
                    perecedero.NombreProducto,
                    perecedero.Precio,
                    perecedero.StockProducto,
                    perecedero.CategoriaProducto,
                    perecedero.FechaVencimiento.ToShortDateString(),
                    perecedero.Temperatura,
                    "",
                    ""
                );
                return;
            }

            productoElectronico electronico = p as productoElectronico;
            if (electronico != null)
            {
                dataGridView1.Rows.Add(
                    electronico.IdProducto,
                    electronico.NombreProducto,
                    electronico.Precio,
                    electronico.StockProducto,
                    electronico.CategoriaProducto,
                    "",
                    "",
                    electronico.Garantia + " meses",
                    electronico.Voltaje + "V"
                );
                return;
            }
            dataGridView1.Rows.Add(
                p.IdProducto,
                p.NombreProducto,
                p.Precio,
                p.StockProducto,
                p.CategoriaProducto,
                "",
                "",
                "",
                ""
            );
        }
        //MENU DE NAVEGACION <
        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu nuevoForm = new menu();
             nuevoForm.Show();
             this.Hide();

        }
        private void almacenarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pedidos nuevoForm = new pedidos();
            nuevoForm.Show();
            this.Hide();
        }
        private void registroDeVantasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas nuevoForm = new frmVentas();
            nuevoForm.Show();
            this.Hide();
        }
        private void verPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verPedidos nuevoForm = new verPedidos();
            nuevoForm.Show();
            this.Hide();
        }
        private void frmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
