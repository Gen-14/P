using System;

namespace Proyecto
{
    public class producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal Precio { get; set; }
        public int StockProducto { get; set; }
        public string CategoriaProducto { get; set; }

        public producto()
        {
        }

        public producto(int idProducto, string nombreProducto, decimal precio, int stockProducto, string categoriaProducto)
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            Precio = precio;
            StockProducto = stockProducto;
            CategoriaProducto = categoriaProducto;
        }

        public string Id
        {
            get { return IdProducto.ToString(); }
            set
            {
                int id;
                IdProducto = int.TryParse(value, out id) ? id : 0;
            }
        }

        public string Nombre
        {
            get { return NombreProducto; }
            set { NombreProducto = value; }
        }

        public string Categoria
        {
            get { return CategoriaProducto; }
            set { CategoriaProducto = value; }
        }

        public int Cantidad
        {
            get { return StockProducto; }
            set { StockProducto = value; }
        }
    }

    public class productoPerecedero : producto
    {
        public DateTime FechaVencimiento { get; set; }
        public decimal Temperatura { get; set; }

        public productoPerecedero()
        {
        }

        public productoPerecedero(int idProducto, string nombreProducto, decimal precio, int stockProducto,
            string categoriaProducto, DateTime fechaVencimiento, decimal temperatura)
            : base(idProducto, nombreProducto, precio, stockProducto, categoriaProducto)
        {
            FechaVencimiento = fechaVencimiento;
            Temperatura = temperatura;
        }
    }

    public class productoElectronico : producto
    {
        public int Garantia { get; set; }
        public int Voltaje { get; set; }

        public productoElectronico()
        {
        }

        public productoElectronico(int idProducto, string nombreProducto, decimal precio, int stockProducto,
            string categoriaProducto, int garantia, int voltaje)
            : base(idProducto, nombreProducto, precio, stockProducto, categoriaProducto)
        {
            Garantia = garantia;
            Voltaje = voltaje;
        }
    }
}
