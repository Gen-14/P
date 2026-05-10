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

            if (Datos.ListaPedidos.Count > 0)
            {
                nuevoID = Datos.ListaPedidos.Max(p => p.id) + 1;
            }
            pedido nuevo = new pedido()
            {
                id = nuevoID,
                fecha = dtFecha.Value,
                cliente = tbCliente.Text,
                productos = tbProductos.Text,
                estado = estado.Text
            };
            Datos.ListaPedidos.Add(nuevo);
            //carga los datos ingresados en la tabla y muestra un mensaje
            //Hacer el archivo de txt
            pedido.archivoTxt();
            cargarDatos();
            limpiarCampos();

            MessageBox.Show("Pedido agregado correctamente");
        }
        //metodo que limpia los campos de texto 
        private void limpiarCampos()
        {
            tbCliente.Text = "";
            tbProductos.Text = "";
            dtFecha.Value = DateTime.Now;
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

                    if (datos.Length == 5)
                    {
                        pedido nuevo = new pedido()
                        {
                            id = int.Parse(datos[0]),
                            fecha = DateTime.Parse(datos[1]),
                            cliente = datos[2],
                            productos = datos[3],
                            estado = datos[4]
                        };

                        Datos.ListaPedidos.Add(nuevo);
                    }
                }
            }
            cargarDatos();
        }

        //botones que abren otros formularios (menu)
        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu nuevoForm = new menu();
            nuevoForm.Show();
            this.Close();
        }
        private void verPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verPedidos nuevoForm = new verPedidos();
            nuevoForm.Show();
            this.Close();
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
    }
}