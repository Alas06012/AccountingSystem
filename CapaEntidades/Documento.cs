using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades {
   public class Documento {


        private int Id;
        private int numero;
        private int serie;
        private int cliente;
        private DateTime fecha;
        private int documento_anterior;
        private string anulada_por;
        private string anulada_en;
        private string motivo_anulacion;
        private decimal afectas;
        private decimal exentas;
        private decimal iva;
        private decimal retencion;
        private decimal percepcion;
        private int condiciones;
        private string datos_cliente;
        private int nota_remision;
        private string creacion;
        private string creado_por;
        private string caso;
        private string tipo_documento;

        

        public Documento() { }

        public Documento(int id, int numero, int serie, int cliente, DateTime fecha, int documento_anterior, string anulada_por, string anulada_en, string motivo_anulacion, decimal afectas, decimal exentas, decimal iva, decimal retencion, decimal percepcion, int condiciones, string datos_cliente, int nota_remision, string creacion, string creado_por, string caso, string tipo_documento)
        {
            Id = id;
            this.numero = numero;
            this.serie = serie;
            this.cliente = cliente;
            this.fecha = fecha;
            this.documento_anterior = documento_anterior;
            this.anulada_por = anulada_por;
            this.anulada_en = anulada_en;
            this.motivo_anulacion = motivo_anulacion;
            this.afectas = afectas;
            this.exentas = exentas;
            this.iva = iva;
            this.retencion = retencion;
            this.percepcion = percepcion;
            this.condiciones = condiciones;
            this.datos_cliente = datos_cliente;
            this.nota_remision = nota_remision;
            this.creacion = creacion;
            this.creado_por = creado_por;
            this.caso = caso;
            this.tipo_documento = tipo_documento;
        }


        public Documento(int numero, int serie, int cliente, DateTime fecha, int documento_anterior, string anulada_por, string anulada_en, string motivo_anulacion, decimal afectas, decimal exentas, decimal iva, decimal retencion, decimal percepcion, int condiciones, string datos_cliente, int nota_remision, string creacion, string creado_por, string caso, string tipo_documento)
        {
            this.numero = numero;
            this.serie = serie;
            this.cliente = cliente;
            this.fecha = fecha;
            this.documento_anterior = documento_anterior;
            this.anulada_por = anulada_por;
            this.anulada_en = anulada_en;
            this.motivo_anulacion = motivo_anulacion;
            this.afectas = afectas;
            this.exentas = exentas;
            this.iva = iva;
            this.retencion = retencion;
            this.percepcion = percepcion;
            this.condiciones = condiciones;
            this.datos_cliente = datos_cliente;
            this.nota_remision = nota_remision;
            this.creacion = creacion;
            this.creado_por = creado_por;
            this.caso = caso;
            this.tipo_documento = tipo_documento;
        }


        public int _Id { get => Id; set => Id = value; }
        public int Numero { get => numero; set => numero = value; }
        public int Serie { get => serie; set => serie = value; }
        public int Cliente { get => cliente; set => cliente = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Documento_anterior { get => documento_anterior; set => documento_anterior = value; }
        public string Anulada_por { get => anulada_por; set => anulada_por = value; }
        public string Anulada_en { get => anulada_en; set => anulada_en = value; }
        public string Motivo_anulacion { get => motivo_anulacion; set => motivo_anulacion = value; }
        public decimal Afectas { get => afectas; set => afectas = value; }
        public decimal Exentas { get => exentas; set => exentas = value; }
        public decimal Iva { get => iva; set => iva = value; }
        public decimal Retencion { get => retencion; set => retencion = value; }
        public decimal Percepcion { get => percepcion; set => percepcion = value; }
        public int Condiciones { get => condiciones; set => condiciones = value; }
        public string Datos_cliente { get => datos_cliente; set => datos_cliente = value; }
        public int Nota_remision { get => nota_remision; set => nota_remision = value; }
        public string Creacion { get => creacion; set => creacion = value; }
        public string Creado_por { get => creado_por; set => creado_por = value; }
        public string Caso { get => caso; set => caso = value; }
        public string Tipo_documento { get => tipo_documento; set => tipo_documento = value; }




    }
}
