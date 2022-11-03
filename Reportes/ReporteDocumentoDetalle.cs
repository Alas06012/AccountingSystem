using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportes
{
   public class ReporteDocumentoDetalle
    {
        private int cantidad;
        private string descripccion;
        private decimal precio;
        private decimal exentas;
        private decimal afectas;



        public ReporteDocumentoDetalle()
        {

        }

        public ReporteDocumentoDetalle(int cantidad, string descripccion, decimal precio, decimal exentas, decimal afectas)
        {
            this.cantidad = cantidad;
            this.descripccion = descripccion;
            this.precio = precio;
            this.exentas = exentas;
            this.afectas = afectas;
        }

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Descripccion { get => descripccion; set => descripccion = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public decimal Exentas { get => exentas; set => exentas = value; }
        public decimal Afectas { get => afectas; set => afectas = value; }
    }
}
