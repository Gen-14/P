using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proyecto
{
    public class producto
    {
        //List<producto> listaProductos = new List<producto>();
        /*private int p1;
        private string p2;
        private decimal p3;
        private int p4;
        private string p5;*/
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public producto()
        { }
        public producto(string Id, string Nombre, string Categoria, decimal Precio, int Cantidad)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Categoria = Categoria;
            this.Precio = Precio;
            this.Cantidad = Cantidad;
        }

        // CLASE HIJA PERECEDEROS
        public class productoPerecedero : producto
        {
            public DateTime FechaVencimiento { get; set; }
            public decimal Temperatura { get; set; }

            //CONSTRUCTOR
            public productoPerecedero()
            {

            }
            public productoPerecedero(string Id, string Nombre, string Categoria, decimal Precio, int Cantidad,
                DateTime FechaVencimiento, decimal Temperatura)
                : base(Id, Nombre, Categoria, Precio, Cantidad)
            {
                this.FechaVencimiento = FechaVencimiento;
                this.Temperatura = Temperatura;
            }

        }

        // clase hija que hereda de prodcutos
        public class productoElectronico : producto
        {
            public string Garantia { get; set; }
            public string Voltaje { get; set; }

            public productoElectronico()
            {

            }
            public productoElectronico(string Id, string Nombre, string Categoria, decimal Precio, int Cantidad,
                string Garantia, string Voltaje)
                : base(Id, Nombre, Categoria, Precio, Cantidad)
            {
                this.Garantia = Garantia;
                this.Voltaje = Voltaje;
            }

        }
    }
}