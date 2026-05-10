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

namespace Proyecto
{
    public partial class frmProductos : Form
    {
        
        public frmProductos()
        {
            InitializeComponent();
        }

        // AQUI VA EL METODO
        public static void archivoTxt()
        {
            StreamWriter sw = new StreamWriter("productos.txt");

            foreach (producto p in lstProductos.listaProductos)
            {
                sw.WriteLine(
                    p.IdProducto + "," +
                    p.NombreProducto + "," +
                    p.Precio + "," +
                    p.StockProducto + "," +
                    p.CategoriaProducto
                );
            }

            sw.Close();
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
            //cCategoria.Items.Add("Perecederos");
            //cCategoria.Items.Add("Electronicos");
            panelPerecederos.Visible = false;
            panelElectronico.Visible = false;

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

            //no permite que se hagan filas en blanco
            dataGridView1.AllowUserToAddRows = false;
        }
        //metodo para que se limpien los campos despues de guardar el producto
        private void LimpiarCampos()
        {
            tNombreProducto.Text = "";
            tPrecio.Text = "";
            tID.Text = "";
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
            producto nuevo = new producto(
            int.Parse(tID.Text),
            tNombreProducto.Text,
            decimal.Parse(tPrecio.Text),
            int.Parse(nStock.Text),
            cCategoria.Text
  );

            lstProductos.listaProductos.Add(nuevo);

            archivoTxt();

            MessageBox.Show("Producto guardado");



            string nombreProducto = tNombreProducto.Text;
            decimal precioBase = Convert.ToDecimal(tPrecio.Text);
            string categoriaProducto = cCategoria.Text;
            int stockProducto = (int)nStock.Value;
            //string idProducto = idProducto.Text;
            int idProducto;
            if (!int.TryParse(tID.Text, out idProducto))
            {
                MessageBox.Show("Ingrese un ID válido");
                return;
            }

            decimal utilidadProducto = nUtilidad.Value;
            DateTime fechaVencimiento = dVencimiento.Value;
            decimal temperatura = nTemperatura.Value;
            string garantia = tGarantia.Text;
            int voltaje = int.Parse(nVoltaje.Text);

            decimal total = precioBase + (precioBase * utilidadProducto / 100);

            string datos = "";
            //muestra los datos de los producto en el dataGribView
            if (categoriaProducto == "Perecederos")
            {
                productoPerecedero p = new productoPerecedero(
                    idProducto,
                    nombreProducto,
                    total,
                    stockProducto,
                    categoriaProducto,
                    dVencimiento.Value,
                    nTemperatura.Value
                );

                dataGridView1.Rows.Add(
                    p.IdProducto,
                    p.NombreProducto,
                    p.Precio,
                    p.StockProducto,
                    p.CategoriaProducto,
                    p.FechaVencimiento.ToShortDateString(),
                    p.Temperatura,
                    "",
                    ""
                );
            }
            else if (categoriaProducto == "Electronicos")
            {
                productoElectronico electronico = new productoElectronico(
                    idProducto,
                    nombreProducto,
                    total,
                    stockProducto,
                    categoriaProducto,
                    Convert.ToInt32(tGarantia.Text),
                    (int)nVoltaje.Value
                );

                dataGridView1.Rows.Add(
                    electronico.IdProducto,
                    electronico.NombreProducto,
                    electronico.Precio,
                    electronico.StockProducto,
                    electronico.CategoriaProducto,
                    "",
                    "",
                    electronico.Garantia + " meses",
                    electronico.Voltaje
                );
                //listaProductos.Add(electronico);
            }
             
            //evita que el usuario deje espacios en blanco

            if (string.IsNullOrWhiteSpace(tNombreProducto.Text) ||
                string.IsNullOrWhiteSpace(tPrecio.Text) ||
                string.IsNullOrWhiteSpace(tGarantia.Text) ||
                string.IsNullOrWhiteSpace(tID.Text) ) 
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }
              /* if (tNombreProducto.Text == "" || tPrecio.Text == "" || tID.Text == "")
               {
                   MessageBox.Show("Complete todos los campos");
                   return;
               }*/

            LimpiarCampos();

            dataGridView1.Rows.Add(datos);

            //muestra un mesaje de que se guardo 
             MessageBox.Show("Guardado");

        }
        //navegar en el menú

       //metodo para guardar los productos en un archivo de texto

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
        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
