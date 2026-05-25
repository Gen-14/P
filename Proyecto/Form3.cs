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
    public partial class verPedidos : Form
    {
        public verPedidos()
        {
            InitializeComponent();
        }
        public void cargarDatos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Datos.ListaPedidos;
            dataGridView1.Refresh();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            //cargar los datos del archivo txt

            if (File.Exists("pedidos.txt"))
            {
                Datos.ListaPedidos.Clear();
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

        private void verPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verPedidos nuevoForm = new verPedidos();
            nuevoForm.Show();
            this.Close();
        }

        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu nuevoForm = new menu();
            nuevoForm.Show();
            this.Close();
        }

        private void almacenarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pedidos nuevoForm = new pedidos();
            nuevoForm.Show();
            this.Close();
        }

        private void verPedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void almacenarPedidosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

    }
}
