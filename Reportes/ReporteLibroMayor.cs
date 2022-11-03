using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportes
{
   public class ReporteLibroMayor
    {

        public string nombre { get; set; }
        public string tipoSaldo { get; set; }
        public DateTime fecha { get; set; }
        public string  partida { get; set; }
        public string codigo { get; set; }
        public string enunciado { get; set; }
        public Decimal cargos { get; set; }
        public Decimal abonos { get; set; }
        public Decimal saldos { get; set; }

    }
}
