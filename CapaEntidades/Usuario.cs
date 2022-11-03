using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades {
    public class Usuario {
        private int Id;
        private string nombre;
        private string usuario;
        private string contra;
        private int intentos;
        private string estado;

        public Usuario(int id, string nombre, string usuario, string contra, int intentos, string estado) {
            Id = id;
            this.nombre = nombre;
            this.usuario = usuario;
            this.contra = contra;
            this.intentos = intentos;
            this.estado = estado;
        }

        public Usuario(string nombre, string usuario, string contra, int intentos, string estado) {
            this.nombre = nombre;
            this.usuario = usuario;
            this.contra = contra;
            this.intentos = intentos;
            this.estado = estado;
        }

        public Usuario(int id) {
            Id = id;
        }

        public Usuario() {
        }


        public int _Id { get => Id; set => Id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string _Usuario { get => usuario; set => usuario = value; }
        public string Contra { get => contra; set => contra = value; }
        public int Intentos { get => intentos; set => intentos = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
