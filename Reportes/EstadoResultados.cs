using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportes
{
    public class EstadoResultados
    {
        decimal ventas;
        decimal costo_ventas;
        decimal utilidad_bruta;
        decimal gastos_operativos;
        decimal utilidad_operativa;
        decimal otros_ingresos;
        decimal utilidad_antes_ISR;
        decimal ISR;
        decimal utilidad_Neta;

        public EstadoResultados(decimal ventas, decimal costo_ventas, decimal gastos_operativos, decimal otros_ingresos)
        {
            this.ventas = ventas;
            this.costo_ventas = costo_ventas;
            this.utilidad_bruta = ventas - costo_ventas;
            this.gastos_operativos = gastos_operativos;
            this.utilidad_operativa = ventas - costo_ventas - gastos_operativos;
            this.otros_ingresos = otros_ingresos;
            this.utilidad_antes_ISR = ventas - costo_ventas - gastos_operativos + otros_ingresos;
        }

        public decimal Ventas { get => ventas; set => ventas = value; }
        public decimal Costo_ventas { get => costo_ventas; set => costo_ventas = value; }
        public decimal Utilidad_bruta { get => utilidad_bruta; set => utilidad_bruta = value; }
        public decimal Gastos_operativos { get => gastos_operativos; set => gastos_operativos = value; }
        public decimal Utilidad_operativa { get => utilidad_operativa; set => utilidad_operativa = value; }
        public decimal Otros_ingresos { get => otros_ingresos; set => otros_ingresos = value; }
        public decimal Utilidad_antes_ISR { get => utilidad_antes_ISR; set => utilidad_antes_ISR = value; }
        public decimal ISR1 { get => ISR; set { ISR = value; this.utilidad_Neta = utilidad_antes_ISR - value; } }
        public decimal Utilidad_Neta { get => utilidad_Neta;}
    }
}
