using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades {

   public class Producto {
        private int id;
        private string nombre;
        private int existencias;
        private decimal precio;
        private decimal costo;
        private string descripcion;
        private string img;
        private string codigo;
        public Producto() { }

        public Producto(int id) {
            this.id = id;
        }
        public Producto(string nombre, int existencias, decimal precio, decimal costo, string descripcion, string img, string codigo) {
            this.nombre = nombre;
            this.existencias = existencias;
            this.precio = precio;
            this.costo = costo;
            this.descripcion = descripcion;
            this.img = img;
            this.codigo = codigo;
        }

        public Producto(int id, string nombre, int existencias, decimal precio, decimal costo, string descripcion, string img, string codigo) {
            this.id = id;
            this.nombre = nombre;
            this.existencias = existencias;
            this.precio = precio;
            this.costo = costo;
            this.descripcion = descripcion;
            this.img = img;
            this.codigo = codigo;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Existencias { get => existencias; set => existencias = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public decimal Costo { get => costo; set => costo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Img { get => img; set => img = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }
}
