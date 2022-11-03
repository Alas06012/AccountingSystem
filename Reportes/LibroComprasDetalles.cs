using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportes
{
    public class LibroComprasDetalles
    {
        string fecha;
        string numeroDocumento;
        string proveedor;
        decimal local_gravadas;
        decimal iva;
        decimal exportacion_gravadas;
        decimal retencion;
        decimal totales;

        public LibroComprasDetalles(string fecha, string numeroDocumento, string proveedor, decimal local_gravadas, decimal iva, decimal exportacion_gravadas, decimal retencion, decimal totales)
        {
            this.fecha = fecha;
            this.numeroDocumento = numeroDocumento;
            this.proveedor = proveedor;
            this.local_gravadas = local_gravadas;
            this.iva = iva;
            this.exportacion_gravadas = exportacion_gravadas;
            this.retencion = retencion;
            this.totales = totales;
        }

        public string Fecha { get => fecha; set => fecha = value; }
        public string NumeroDocumento { get => numeroDocumento; set => numeroDocumento = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public decimal Local_gravadas { get => local_gravadas; set => local_gravadas = value; }
        public decimal Iva { get => iva; set => iva = value; }
        public decimal Exportacion_gravadas { get => exportacion_gravadas; set => exportacion_gravadas = value; }
        public decimal Retencion { get => retencion; set => retencion = value; }
        public decimal Totales { get => totales; set => totales = value; }
    }
}
