using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ISRrangos
    {
        decimal de;
        decimal hasta;
        decimal exceso;
        decimal cuota_fija;
        int id;
        int porcentaje;

        public ISRrangos()
        {
            this.de = 0.00m;
            this.hasta = 0.00m;
            this.exceso = 0.00m;
            this.cuota_fija = 0.00m;
            this.id = 0;
            this.porcentaje = 0;
        }

        public ISRrangos(decimal de, decimal hasta, decimal exceso, decimal cuota_fija, int id, int porcentaje)
        {
            this.de = de;
            this.hasta = hasta;
            this.exceso = exceso;
            this.cuota_fija = cuota_fija;
            this.id = id;
            this.porcentaje = porcentaje;
        }

        public decimal De { get => de; set => de = value; }
        public decimal Hasta { get => hasta; set => hasta = value; }
        public decimal Exceso { get => exceso; set => exceso = value; }
        public decimal Cuota_fija { get => cuota_fija; set => cuota_fija = value; }
        public int Id { get => id; set => id = value; }
        public int Porcentaje { get => porcentaje; set => porcentaje = value; }
    }
}
