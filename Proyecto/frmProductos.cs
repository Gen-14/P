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
                // PERECEDEROS
                if (p.Categoria == "Perecedero")
                {
                    producto.productoPerecedero pe =
                    (producto.productoPerecedero)p;
                    sw.WriteLine(
                        p.Id + "," +
                        p.Nombre + "," +
                        p.Categoria + "," +
                        p.Precio + "," +
                        p.Cantidad + "," +
                        p.FechaVencimiento + "," +
                        p.Temperatura
                    );
                }

                // ELECTRONICOS
                else if (p.Categoria == "Electronico")
                {
                    producto.productoElectronico pe = (producto.productoElectronico)p;
                    sw.WriteLine(
                        p.Id + "," +
                        p.Nombre + "," +
                        p.Categoria + "," +
                        p.Precio + "," +
                        p.Cantidad + "," +
                        p.Garantia + "," +
                        p.Voltaje
                    );
                }
            }
            sw.Close();
        }

        //ESCONDE LOS DATOS DE LAS CATEGORIAS 
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
            //LLAMA A UN METODO
            CargarProductos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lstProductos.listaProductos;

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
           // DateTime fechaVencimiento = dVencimiento.Text;
            decimal temperatura = nTemperatura.Value;
            string garantia = tGarantia.Text;
            int voltaje = int.Parse(nVoltaje.Text);

            decimal total = precioBase + (precioBase * utilidadProducto / 100);

            //string datos = "";
            //muestra los datos de los producto en el dataGribView

            /*productoElectronico q = new productoElectronico();

            q.Id = tID.Text;
            q.Nombre = tNombreProducto.Text;
            q.Precio = Convert.ToDouble(tPrecio.Text);
            q.Cantidad = Convert.ToInt32(nStock.Text);
            q.Categoria = cCategoria.Text;

            q.Garantia = tGarantia.Text;
            q.Voltaje = nVoltaje.Text;*/
                //listaProductos.Add(electronico);
           
            try
            {
                if (string.IsNullOrWhiteSpace(tNombreProducto.Text))
                {
                    MessageBox.Show("Debe ingresar un valor");
                }
                else if (cCategoria.Text == "Perecedero")
                {
                    producto.productoPerecedero p = new producto.productoPerecedero();

                        p.Id = tID.Text;
                        p.Nombre = tNombreProducto.Text;
                        p.Precio = total;
                        p.Cantidad = Convert.ToInt32(nStock.Text);
                        p.Categoria = cCategoria.Text;
                        p.FechaVencimiento = dVencimiento.Value;
                        p.Temperatura = nTemperatura.Value;

                    //LO AGREGA Y HACE EL ARCHIVO DE TXT
                    lstProductos.listaProductos.Add(p);
                    archivoTxt();

                }
                else if(cCategoria.Text == "Electronico")
                {
                    producto.productoElectronico q = new producto.productoElectronico();

                    q.Id = tID.Text;
                    q.Nombre = tNombreProducto.Text;
                    q.Precio = total;
                    q.Cantidad = Convert.ToInt32(nStock.Text);
                    q.Categoria = cCategoria.Text;

                    q.Garantia = tGarantia.Text;
                    q.Voltaje = nVoltaje.Text;

                    //LO AGREGA Y HACE EL ARCHIVO DE TXT
                    lstProductos.listaProductos.Add(q);
                    archivoTxt();
                    dataGridView1.Rows.Add(q);
                }  
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado " + ex.Message);
            }
            LimpiarCampos();
            //archivoTxt();
            //muestra un mesaje de que se guardo 
             MessageBox.Show("Guardado");

        }
        //metodo para que carguen los productos cunado abre el programa
        public void CargarProductos()
        {
            lstProductos.listaProductos.Clear();

            if (File.Exists("productos.txt"))
            {
                StreamReader leer = new StreamReader("productos.txt");

                while (!leer.EndOfStream)
                {
                    string linea = leer.ReadLine();

                    if (linea.Trim() == "")
                    {
                        continue;
                    }

                    string[] datos = linea.Split(',');
                    // PERECEDEROS
                    if (datos[2] == "Perecedero")
                    {
                        producto.productoPerecedero p =
                        new producto.productoPerecedero(

                            datos[0],
                            datos[1], 
                            datos[2],
                            Convert.ToDecimal(datos[3]),
                            Convert.ToInt16(datos[4]),
                            Convert.ToDateTime(datos[5]),
                            Convert.ToDecimal(datos[6])
                        );

                        lstProductos.listaProductos.Add(p);
                    }

                    // ELECTRONICOS
                    else if (datos[2] == "Electronico")
                    {
                        producto.productoElectronico e =
                        new producto.productoElectronico(

                            datos[0],
                            datos[1],
                            datos[2],
                            Convert.ToDecimal(datos[3]),
                            Convert.ToInt16(datos[4]),
                            datos[4],
                            datos[5]
                        );

                        lstProductos.listaProductos.Add(e);
                    }
                }

                leer.Close();
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lstProductos.listaProductos;
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
        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
