using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades {
    public class Proveedor {
        private int Id;
        private string tipo;
        private string clasificacion; // enum('ninguno', 'pequeño', 'mediano', 'grande')
        private string nit;
        private string nrc;
        private string nombre;
        private string razon_social;
        private string direccion;
        private string telefono;
        public Proveedor() { }

        public Proveedor(int id) {
            this.Id = id;
        }
        public Proveedor(int id, string tipo, string clasificacion, string nit, string nrc, string nombre, string razon_social, string direccion, string telefono) {
            this.Id = id;
            this.tipo = tipo;
            this.clasificacion = clasificacion;
            this.nit = nit;
            this.nrc = nrc;
            this.nombre = nombre;
            this.razon_social = razon_social;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public Proveedor(string tipo, string clasificacion, string nit, string nrc, string nombre, string razon_social, string direccion, string telefono) {
            this.tipo = tipo;
            this.clasificacion = clasificacion;
            this.nit = nit;
            this.nrc = nrc;
            this.nombre = nombre;
            this.razon_social = razon_social;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public int _Id { get => Id; set => Id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Clasificacion { get => clasificacion; set => clasificacion = value; }
        public string Nit { get => nit; set => nit = value; }
        public string Nrc { get => nrc; set => nrc = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Razon_social { get => razon_social; set => razon_social = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
