using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportes
{
    public class BalanceFila
    {
        string cadena;
        string saldos;
        string sumas;
        string total;
        string caso;

        public BalanceFila(string cadena, string saldos,string caso)
        {
            this.cadena = cadena;
            this.saldos = saldos;
            this.caso = caso;
        }

        public BalanceFila(string cadena, string saldos)
        {
            this.cadena = cadena;
            this.saldos = saldos;
            this.caso = "Agrupacion";
        }

        public BalanceFila(string cadena)
        {
            this.cadena = cadena;
            this.saldos = "";
            this.sumas = "";
            this.sumas = "";
            this.caso = "Rubro";
        }




        public string Cadena { get => cadena; set => cadena = value; }
        public string Saldos { get => saldos; set => saldos = value; }
        public string Sumas { get => sumas; set => sumas = value; }
        public string Total { get => total; set => total = value; }
        public string Caso { get => caso; set => caso = value; }
    }
}
