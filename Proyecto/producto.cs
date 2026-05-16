using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class producto
    {
            public int IdProducto { get; set; }
            public string NombreProducto { get; set; }
            public decimal Precio { get; set; }
            public int StockProducto { get; set; }
            public string CategoriaProducto { get; set; }

            // Constructor
            public producto(int id, string nombre, decimal precio, int stock, string categoria)
            {
                IdProducto = id;
                NombreProducto = nombre;
                Precio = precio;
                StockProducto = stock;
                CategoriaProducto = categoria;
            }
        }

        // CLASE HIJA PERECEDEROS
        public class productoPerecedero : producto
        {
            public DateTime FechaVencimiento { get; set; }
            public decimal Temperatura { get; set; }

            public productoPerecedero(
                int id,
                string nombre,
                decimal precio,
                int stock,
                string categoria,
                DateTime fechaVencimiento,
                decimal temperatura)
                : base(id, nombre, precio, stock, categoria)
            {
                FechaVencimiento = fechaVencimiento;
                Temperatura = temperatura;
            }

        }

        // clase hija que hereda de prodcutos
        public class productoElectronico : producto
        {
            public int Garantia { get; set; }
            public int Voltaje { get; set; }

            public productoElectronico(
                int id,
                string nombre,
                decimal precio,
                int stock,
                string categoria,
                int garantia,
                int voltaje)
                : base(id, nombre, precio, stock, categoria)
            {
                Garantia = garantia;
                Voltaje = voltaje;
            }
        }
    }
