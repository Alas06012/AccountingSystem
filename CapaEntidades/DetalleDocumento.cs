using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades {
    public class DetalleDocumento {
        private int Id;
        private int documento;
        private int producto;
        private int cant;
        private decimal precio;
        public DetalleDocumento() { }

        public DetalleDocumento(int id, int documento, int producto, int cant, decimal precio) {
            Id = id;
            this.documento = documento;
            this.producto = producto;
            this.cant = cant;
            this.precio = precio;
        }

        public DetalleDocumento( int documento, int producto, int cant, decimal precio) {
            this.documento = documento;
            this.producto = producto;
            this.cant = cant;
            this.precio = precio;
        }
        public DetalleDocumento(int id, int cant, decimal precio)
        {
            Id = id;
            this.cant = cant;
            this.precio = precio;
        }

        public int _Id { get => Id; set => Id = value; }
        public int Documento { get => documento; set => documento = value; }
        public int Producto { get => producto; set => producto = value; }
        public int Cant { get => cant; set => cant = value; }
        public decimal Precio { get => precio; set => precio = value; }
    }
}
