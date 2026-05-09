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
    public partial class pedidos : Form
    {
       
        public pedidos()
        {
            InitializeComponent();
            cargarDatos();
        }
        //carga los pedidos
        public void cargarDatos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Datos.ListaPedidos;
        }
        //agregar los pedidos
        public void bAgregar_Click(object sender, EventArgs e)
        {
            pedido nuevo = new pedido()
            {
                id = Datos.ListaPedidos.Count + 1,
                fecha = dtFecha.Value,
                cliente = tbCliente.Text,
                productos = tbProductos.Text,
                estado = estado.Text
            };
            Datos.ListaPedidos.Add(nuevo);

            //carga los datos ingresados en la tabla y muestra un mensaje
            limpiarCampos();
            cargarDatos();
            MessageBox.Show("Pedido agregado correctamente");
        }
        //metodo que limpia los campos de texto 
        private void limpiarCampos()
        {
            tbCliente.Text = "";
            tbProductos.Text = "";
            estado.Text = "";
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
            Form3 nuevoForm = new Form3();
            nuevoForm.Show();
            this.Hide();
        }

        private void pedidos_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
