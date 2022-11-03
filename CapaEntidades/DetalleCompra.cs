using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades {
    public class DetalleCompra {
        private int Id;
        private int compra;
        private int producto;
        private int cant;
        private decimal price;

        public DetalleCompra() { }
        public DetalleCompra(int id, int compra, int producto, int cant, decimal price) {
            this.Id = id;
            this.compra = compra;
            this.producto = producto;
            this.cant = cant;
            this.price = price;
        }

        public DetalleCompra(int compra, int producto, int cant, decimal price) {
            this.compra = compra;
            this.producto = producto;
            this.cant = cant;
            this.price = price;
        }

        public DetalleCompra(int producto, int cant, decimal price)
        {
            this.producto = producto;
            this.cant = cant;
            this.price = price;
        }

        public int _Id { get => Id; set => Id = value; }
        public int Compra { get => compra; set => compra = value; }
        public int Producto { get => producto; set => producto = value; }
        public int Cant { get => cant; set => cant = value; }
        public decimal Price { get => price; set => price = value; }
    }
}
