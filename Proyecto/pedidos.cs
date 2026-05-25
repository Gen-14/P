using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto
{
    //clase de pedidos
    public class pedido
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public string cliente { get; set; }
        public string productos { get; set; }
        public int cantidad { get; set; }
        public string estado { get; set; }

        //creamos un  metódo que guarde los pedidos en un archivo de txt
        //COPIAR ESTO
        public static void archivoTxt()
        {
            StreamWriter sw = new StreamWriter("pedidos.txt");

            foreach (pedido e in Datos.ListaPedidos)
            {
                sw.WriteLine(e.id + "," + e.fecha.ToString("yyyy-MM-dd") + "," + e.cliente + "," + e.productos + "," + e.estado + "," + e.cantidad);
            }

            sw.Close();
        }
    }
}
