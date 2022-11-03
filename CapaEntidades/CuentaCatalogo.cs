using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades {
    public class CuentaCatalogo {
        private int Id;
        private string rubro;
        private string agrupacion;
        private string nombre;
        private string codigo;
        private decimal debe;
        private decimal haber;
        private string tipo_saldo;
        private int cuenta_padre;
        private int nivel;


        public CuentaCatalogo()
        {

     

        }
        public CuentaCatalogo(decimal debe, decimal haber)
        {
           
            this.debe = 0.00m;
            this.haber = 0.00m;
    
        }

        public CuentaCatalogo(int id, string rubro, string agrupacion, string nombre, string codigo, decimal debe, decimal haber, string tipo_saldo, int cuenta_padre, int nivel)
        {
            Id = id;
            this.rubro = rubro;
            this.agrupacion = agrupacion;
            this.nombre = nombre;
            this.codigo = codigo;
            this.debe = debe;
            this.haber = haber;
            this.tipo_saldo = tipo_saldo;
            this.cuenta_padre = cuenta_padre;
            this.nivel = nivel;
        }
        public CuentaCatalogo(string rubro, string agrupacion, string nombre, string codigo, decimal debe, decimal haber, string tipo_saldo, int cuenta_padre, int nivel)
        {

            this.rubro = rubro;
            this.agrupacion = agrupacion;
            this.nombre = nombre;
            this.codigo = codigo;
            this.debe = debe;
            this.haber = haber;
            this.tipo_saldo = tipo_saldo;
            this.cuenta_padre = cuenta_padre;
            this.nivel = nivel;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string Rubro { get => rubro; set => rubro = value; }
        public string Agrupacion { get => agrupacion; set => agrupacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public decimal Debe { get => debe; set => debe = value; }
        public decimal Haber { get => haber; set => haber = value; }
        public string Tipo_saldo { get => tipo_saldo; set => tipo_saldo = value; }
        public int Cuenta_padre { get => cuenta_padre; set => cuenta_padre = value; }
        public int Nivel { get => nivel; set => nivel = value; }
    }
}
