using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportes
{
    public class ReporteKardex
    {
        string desde;
        string hasta;
        List<ReportekardexDetalle> detalles;
        string producto;

        public ReporteKardex(string desde, string hasta, List<ReportekardexDetalle> detalles, string producto)
        {
            this.desde = desde;
            this.hasta = hasta;
            this.detalles = detalles;
            this.producto = producto;
        }

        public string Desde { get => desde; set => desde = value; }
        public string Hasta { get => hasta; set => hasta = value; }
        public List<ReportekardexDetalle> Detalles { get => detalles; set => detalles = value; }
        public string Producto { get => producto; set => producto = value; }
    }
}
