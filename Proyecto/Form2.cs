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

namespace Proyecto
{
    public partial class pedidos : Form
    {

        public pedidos()
        {
            InitializeComponent();
        }
        //carga los pedidos
        private void pedidos_Load(object sender, EventArgs e)
        {
            cargaDatosTxt();
            CargarProductos();
        }
        public void cargarDatos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Datos.ListaPedidos;
            dataGridView1.Refresh();
        }
        //agregar los pedidos
        public void bAgregar_Click(object sender, EventArgs e)
        {
            int nuevoID = 1;
            try
            {
                string productosSeleccionados = obtenerProductosSeleccionados();

                if (string.IsNullOrWhiteSpace(tbCliente.Text))
                {
                    MessageBox.Show("Debe completar todos los campos");
                    return;
                }
                if (Datos.ListaPedidos.Count > 0)
                {
                    nuevoID = Datos.ListaPedidos.Max(p => p.id) + 1;
                }

                //almacena el pedido
                pedido nuevo = new pedido()
                {
                    id = nuevoID,
                    fecha = dtFecha.Value,
                    cliente = tbCliente.Text,
                    productos = productosSeleccionados,
                    cantidad = (int)numericUpDown1.Value,
                    estado = estado.Text
                };
                if (string.IsNullOrWhiteSpace(productosSeleccionados))
                {
                    MessageBox.Show("Debe seleccionar al menos un producto");
                    return;
                }
                Datos.ListaPedidos.Add(nuevo);
                //Hacer el archivo de txt
                pedido.archivoTxt();
                cargarDatos();
                limpiarCampos();

                MessageBox.Show("Pedido agregado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
        private string obtenerProductosSeleccionados()
        {
            string productos = "";

            foreach (var item in listBox1.SelectedItems)
            {
                if (productos == "")
                {
                    productos = item.ToString();
                }
                else
                {
                    productos = productos + " | " + item.ToString();
                }
            }

            return productos;
        }
        //METODOS DE CARGAR LOS DATOS DE TXT Y DE LOS PRODUCTOS
        private void CargarProductos()
        {
            listBox1.Items.Clear();

            if (!File.Exists("productos.txt"))
            {
                return;
            }

            StreamReader sr = new StreamReader("productos.txt");

            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine();

                string[] datos = linea.Split('|');

                // Mostrar ID y nombre
                if (datos.Length >= 2)
                {
                    listBox1.Items.Add(datos[0] + " - " + datos[1]);
                }
            }

            sr.Close();
        }
        public void cargaDatosTxt()
        {
            Datos.ListaPedidos.Clear();
            //cargar los datos del archivo txt

            if (File.Exists("pedidos.txt"))
            {
                foreach (string linea in File.ReadAllLines("pedidos.txt"))
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;

                    string[] datos = linea.Split(',');

                    if (datos.Length >= 5)
                    {
                        pedido nuevo = new pedido()
                        {
                            id = int.Parse(datos[0]),
                            fecha = DateTime.Parse(datos[1]),
                            cliente = datos[2],
                            productos = datos[3],
                            estado = datos[4],
                            cantidad = datos.Length >= 6 ? int.Parse(datos[5]) : 1
                        };

                        Datos.ListaPedidos.Add(nuevo);
                    }
                }
            }
            cargarDatos();
        }

        //metodo que limpia los campos de texto 
        private void limpiarCampos()
        {
            tbCliente.Text = "";
            listBox1.Text = "";
            listBox1.ClearSelected();
            numericUpDown1.Value = 1;
            dtFecha.Value = DateTime.Now;
        }
        //botones que abren otros formularios (menu)
        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu nuevoForm = new menu();
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
            frmProductos nuevoForm = new frmProductos();
            nuevoForm.Show();
            this.Hide();
        }
        private void almacenarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pedidos nuevoForm = new pedidos();
            nuevoForm.Show();
            this.Hide();
        }

        private void registroDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas nuevoForm = new frmVentas();
            nuevoForm.Show();
            this.Hide();
        }

        private void pedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
