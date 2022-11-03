using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades {
    public class Cliente {
        private int Id;
        private string nombre;
        private string clasificacion;
        private string direccion;
        private string nit;
        private string nrc;
        private string razon_social;
        private string giro;
        private string telefono;

        public Cliente() { }

        public Cliente(string nombre, string clasificacion, string direccion, string nit, string nrc, string razon_social, string giro, string telefono) {
            this.nombre = nombre;
            this.clasificacion = clasificacion;
            this.direccion = direccion;
            this.nit = nit;
            this.nrc = nrc;
            this.razon_social = razon_social;
            this.giro = giro;
            this.telefono = telefono;
        }

        public Cliente(int id, string nombre, string clasificacion, string direccion, string nit, string nrc, string razon_social, string giro, string telefono) {
            Id = id;
            this.nombre = nombre;
            this.clasificacion = clasificacion;
            this.direccion = direccion;
            this.nit = nit;
            this.nrc = nrc;
            this.razon_social = razon_social;
            this.giro = giro;
            this.telefono = telefono;
        }

        public int _Id { get => Id; set => Id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Clasificacion { get => clasificacion; set => clasificacion = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Nit { get => nit; set => nit = value; }
        public string Nrc { get => nrc; set => nrc = value; }
        public string Razon_social { get => razon_social; set => razon_social = value; }
        public string Giro { get => giro; set => giro = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
