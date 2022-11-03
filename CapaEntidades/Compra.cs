using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades {
    public class Compra {
        private int Id;
        private decimal afectas;
        private decimal iva;
        private decimal retencion;
        private int proveedor;
        private string registrado_por;
        private int condiciones;
        private String document_type;
        private string document_number;
        private DateTime fecha;

        public Compra() { }

        public Compra(int id, decimal afectas, decimal iva, decimal retencion, int proveedor, string registrado_por, int condiciones, string document_type, string document_number, DateTime fecha)
        {
            Id = id;
            this.afectas = afectas;
            this.iva = iva;
            this.retencion = retencion;
            this.proveedor = proveedor;
            this.registrado_por = registrado_por;
            this.condiciones = condiciones;
            this.document_type = document_type;
            this.document_number = document_number;
            this.fecha = fecha;
        }

        public Compra(decimal afectas, decimal iva, decimal retencion, int proveedor, string registrado_por, int condiciones, string document_type, string document_number, DateTime fecha)
        {
            this.afectas = afectas;
            this.iva = iva;
            this.retencion = retencion;
            this.proveedor = proveedor;
            this.registrado_por = registrado_por;
            this.condiciones = condiciones;
            this.document_type = document_type;
            this.document_number = document_number;
            this.fecha = fecha;
        }



        public int Id1 { get => Id; set => Id = value; }
        public decimal Afectas { get => afectas; set => afectas = value; }
        public decimal Iva { get => iva; set => iva = value; }
        public decimal Retencion { get => retencion; set => retencion = value; }
        public int Proveedor { get => proveedor; set => proveedor = value; }
        public string Registrado_por { get => registrado_por; set => registrado_por = value; }
        public int Condiciones { get => condiciones; set => condiciones = value; }
        public string Document_type { get => document_type; set => document_type = value; }
        public string Document_number { get => document_number; set => document_number = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
