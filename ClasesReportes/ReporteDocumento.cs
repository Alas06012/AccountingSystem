using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClasesReportes
{
    public class ReporteDocumento
    {
        private String tipo_documento;
        private String numero_Serie;
        private String clientes;
        private int numero_documento;
        private DateTime fecha;
        private string direccion;
        private string registro;
        private string nit;
        private string condiciones;
        private string afectas;
        private string exentas;
        private string iva;
        private string retencion;
        private string percerpcion;
        private string ventatotal;
        private List<ReporteDocumentoDetalle> detalles;
        private string subtotal;

        public ReporteDocumento()
        {
            
        }

        public ReporteDocumento(String tipo_documento, String numero_Serie, int numero_documento, DateTime fecha, string direccion, string registro, string nit, string condiciones, string afectas, string exentas, string iva, string retencion, string percerpcion, string ventatotal, List<ReporteDocumentoDetalle> detalles, string subtotal, String CLIE)
        {
            this.tipo_documento = tipo_documento;
            this.numero_Serie = numero_Serie;
            this.numero_documento = numero_documento;
            this.fecha = fecha;
            this.direccion = direccion;
            this.registro = registro;
            this.nit = nit;
            this.condiciones = condiciones;
            this.afectas = afectas;
            this.exentas = exentas;
            this.iva = iva;
            this.retencion = retencion;
            this.percerpcion = percerpcion;
            this.ventatotal = ventatotal;
            this.detalles = detalles;
            this.subtotal = subtotal;
            this.clientes = CLIE;
        }

        public string Tipo_documento { get => tipo_documento; set => tipo_documento = value; }
        public string Numero_Serie { get => numero_Serie; set => numero_Serie = value; }
        public string Clientes { get => clientes; set => clientes = value; }
        public int Numero_documento { get => numero_documento; set => numero_documento = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Registro { get => registro; set => registro = value; }
        public string Nit { get => nit; set => nit = value; }
        public string Condiciones { get => condiciones; set => condiciones = value; }
        public string Afectas { get => afectas; set => afectas = value; }
        public string Exentas { get => exentas; set => exentas = value; }
        public string Iva { get => iva; set => iva = value; }
        public string Retencion { get => retencion; set => retencion = value; }
        public string Percerpcion { get => percerpcion; set => percerpcion = value; }
        public string Ventatotal { get => ventatotal; set => ventatotal = value; }
        public string Subtotal { get => subtotal; set => subtotal = value; }
        public List<ReporteDocumentoDetalle> Detalles { get => detalles; set => detalles = value; }
    }
}
