using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportes
{
    public class ReporteVentaContribuyente
    {
        string mes;
        decimal internas_gravadas;
        decimal internas_debito;
        decimal internas_exentas;
        decimal exportacion;
        List<ReporteVentasConsumidorDetalle> detalles;

        public ReporteVentaContribuyente(string mes, decimal internas_gravadas, decimal internas_debito, decimal internas_exentas, decimal exportacion)
        {
            this.mes = mes;
            this.internas_gravadas = internas_gravadas;
            this.internas_debito = internas_debito;
            this.internas_exentas = internas_exentas;
            this.exportacion = exportacion;
        }

        public string Mes { get => mes; set => mes = value; }
        public decimal Internas_gravadas { get => internas_gravadas; set => internas_gravadas = value; }
        public decimal Internas_debito { get => internas_debito; set => internas_debito = value; }
        public decimal Internas_exentas { get => internas_exentas; set => internas_exentas = value; }
        public decimal Exportacion { get => exportacion; set => exportacion = value; }
        public List<ReporteVentasConsumidorDetalle> Detalles { get => detalles; set => detalles = value; }
    }
}
