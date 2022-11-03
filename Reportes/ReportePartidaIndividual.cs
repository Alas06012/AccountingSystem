using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportes
{
    public class ReportePartidaIndividual
    {
        public DateTime fecha { get; set; }
        public string descripcion { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public Decimal debe { get; set; }
        public Decimal haber { get; set; }

    }
}
