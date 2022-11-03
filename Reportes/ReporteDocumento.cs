using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportes
{
    public class ReporteDocumento
    {
        private String tipo_documento;
        private String numero_serie;
        private String cliente;
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
        private string percepcion;
        private string ventatotal;
        private List<ReporteDocumentoDetalle> detalles;
        private string subtotal;



        public ReporteDocumento()
        {
            
        }


        public ReporteDocumento(string tipo_documento, string numero_serie, string cliente, int numero_documento, DateTime fecha, string direccion, string registro, string nit, string condiciones, string afectas, string exentas, string iva, string retencion, string percepcion, string ventatotal, List<ReporteDocumentoDetalle> detalles, string subtotal)
        {
            this.tipo_documento = tipo_documento;
            this.numero_serie = numero_serie;
            this.cliente = cliente;
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
            this.percepcion = percepcion;
            this.ventatotal = ventatotal;
            this.detalles = detalles;
            this.subtotal = subtotal;
        }

        public string Tipo_documento { get => tipo_documento; set => tipo_documento = value; }
        public string Numero_serie { get => numero_serie; set => numero_serie = value; }
        public string Cliente { get => cliente; set => cliente = value; }
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
        public string Percepcion { get => percepcion; set => percepcion = value; }
        public string Ventatotal { get => ventatotal; set => ventatotal = value; }
        public List<ReporteDocumentoDetalle> Detalles { get => detalles; set => detalles = value; }
        public string Subtotal { get => subtotal; set => subtotal = value; }
    }
}
