using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportes
{
    public class ReportekardexDetalle
    {
        string fecha;
        string documento;
        string entidad;
        string tipo;
        int entradas_unidades;
        decimal entradas_costo;
        decimal entradas_valor;
        int salidas_unidades;
        decimal salidas_costo;
        decimal salidas_valor;
        int saldos_unidades;
        decimal saldos_unitario;
        decimal saldos_valor;

        public ReportekardexDetalle(string fecha, string documento, string entidad, string tipo, int entradas_unidades, decimal entradas_costo, decimal entradas_valor, int salidas_unidades, decimal salidas_costo, decimal salidas_valor, int saldos_unidades, decimal saldos_unitario, decimal saldos_valor)
        {
            this.fecha = fecha;
            this.documento = documento;
            this.entidad = entidad;
            this.tipo = tipo;
            this.entradas_unidades = entradas_unidades;
            this.entradas_costo = entradas_costo;
            this.entradas_valor = entradas_valor;
            this.salidas_unidades = salidas_unidades;
            this.salidas_costo = salidas_costo;
            this.salidas_valor = salidas_valor;
            this.saldos_unidades = saldos_unidades;
            this.saldos_unitario = saldos_unitario;
            this.saldos_valor = saldos_valor;
        }

        public string Fecha { get => fecha; set => fecha = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Entidad { get => entidad; set => entidad = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Entradas_unidades { get => entradas_unidades; set => entradas_unidades = value; }
        public decimal Entradas_costo { get => entradas_costo; set => entradas_costo = value; }
        public decimal Entradas_valor { get => entradas_valor; set => entradas_valor = value; }
        public int Salidas_unidades { get => salidas_unidades; set => salidas_unidades = value; }
        public decimal Salidas_costo { get => salidas_costo; set => salidas_costo = value; }
        public decimal Salidas_valor { get => salidas_valor; set => salidas_valor = value; }
        public int Saldos_unidades { get => saldos_unidades; set => saldos_unidades = value; }
        public decimal Saldos_unitario { get => saldos_unitario; set => saldos_unitario = value; }
        public decimal Saldos_valor { get => saldos_valor; set => saldos_valor = value; }
    }
}
