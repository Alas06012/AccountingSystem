using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportes
{
   public class ReporteVentaConsumidor
    {
        string mes;
        decimal internas_gravadas;
        decimal internas_debito;
        decimal internas_exentas;
        decimal exportacion;
        List<ReporteVentasConsumidorDetalle> detalles;
        List<LibroComprasDetalles> detall;

        public ReporteVentaConsumidor()
        {
           
        }
        public ReporteVentaConsumidor(string mes, decimal internas_gravadas, decimal internas_debito, decimal internas_exentas, decimal exportacion)
        {
            this.mes = mes;
            this.internas_gravadas = internas_gravadas;
            this.internas_debito = internas_debito;
            this.internas_exentas = internas_exentas;
            this.exportacion = exportacion;
        }


        public ReporteVentaConsumidor(string mes, decimal internas_gravadas, decimal internas_debito, decimal internas_exentas, decimal exportacion, List<ReporteVentasConsumidorDetalle> detalles)
        {
            this.mes = mes;
            this.internas_gravadas = internas_gravadas;
            this.internas_debito = internas_debito;
            this.internas_exentas = internas_exentas;
            this.exportacion = exportacion;
            this.detalles = detalles;
        }

        public ReporteVentaConsumidor(string mes, decimal internas_gravadas, decimal internas_debito, decimal internas_exentas, decimal exportacion, List<LibroComprasDetalles> detall)
        {
            this.mes = mes;
            this.internas_gravadas = internas_gravadas;
            this.internas_debito = internas_debito;
            this.internas_exentas = internas_exentas;
            this.exportacion = exportacion;
            this.detall = detall;
        }

        public string Mes { get => mes; set => mes = value; }
        public decimal Internas_gravadas { get => internas_gravadas; set => internas_gravadas = value; }
        public decimal Internas_debito { get => internas_debito; set => internas_debito = value; }
        public decimal Internas_exentas { get => internas_exentas; set => internas_exentas = value; }
        public decimal Exportacion { get => exportacion; set => exportacion = value; }
        public List<ReporteVentasConsumidorDetalle> Detalles { get => detalles; set => detalles = value; }
        public List<LibroComprasDetalles> Detall { get => detall; set => detall = value; }
    }
}
