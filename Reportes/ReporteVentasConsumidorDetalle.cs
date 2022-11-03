using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportes
{
    public class ReporteVentasConsumidorDetalle
    {
        private string fecha;
        private int desde;
        private int hasta;
        private decimal local_gravadas;
        private decimal Exportacion_gravadas;
        private decimal exentas;
        private decimal totales;
        private string fex;

        public ReporteVentasConsumidorDetalle(string fecha, int desde, int hasta, decimal local_gravadas, decimal exportacion_gravadas, decimal exentas, decimal totales, string fex)
        {
            this.fecha = fecha;
            this.desde = desde;
            this.hasta = hasta;
            this.local_gravadas = local_gravadas;
            Exportacion_gravadas = exportacion_gravadas;
            this.exentas = exentas;
            this.totales = totales;
            this.fex = fex;
        }

        public string Fecha { get => fecha; set => fecha = value; }
        public int Desde { get => desde; set => desde = value; }
        public int Hasta { get => hasta; set => hasta = value; }
        public decimal Local_gravadas { get => local_gravadas; set => local_gravadas = value; }
        public decimal Exportacion_gravadas1 { get => Exportacion_gravadas; set => Exportacion_gravadas = value; }
        public decimal Exentas { get => exentas; set => exentas = value; }
        public decimal Totales { get => totales; set => totales = value; }
        public string Fex { get => fex; set => fex = value; }
    }
}
