using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades {
    public class Partida {

        private int Id;
        private DateTime fecha;
        private decimal debe;
        private decimal haber;
        private string description;
        private int compra_relacionada;
        private int venta_relacionada;
        private int plantilla_predeterminada;
        private int partida_reversion;
        private int partida_revertida;


        public Partida()
        {
            compra_relacionada = 0;
            venta_relacionada = 0;
        }

        public Partida(DateTime fecha, decimal debe, decimal haber, string description, int compra_relacionada, int venta_relacionada, int plantilla_predeterminada, int partida_reversion, int partida_revertida) {
            this.fecha = fecha;
            this.debe = debe;
            this.haber = haber;
            this.description = description;
            this.compra_relacionada = compra_relacionada;
            this.venta_relacionada = venta_relacionada;
            this.plantilla_predeterminada = plantilla_predeterminada;
            this.partida_reversion = partida_reversion;
            this.partida_revertida = partida_revertida;
        }
        public Partida(int id, DateTime fecha, decimal debe, decimal haber, string description, int compra_relacionada, int venta_relacionada, int plantilla_predeterminada, int partida_reversion, int partida_revertida) {
            Id = id;
            this.fecha = fecha;
            this.debe = debe;
            this.haber = haber;
            this.description = description;
            this.compra_relacionada = compra_relacionada;
            this.venta_relacionada = venta_relacionada;
            this.plantilla_predeterminada = plantilla_predeterminada;
            this.partida_reversion = partida_reversion;
            this.partida_revertida = partida_revertida;
        }

        public int _Id { get => Id; set => Id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public decimal Debe { get => debe; set => debe = value; }
        public decimal Haber { get => haber; set => haber = value; }
        public string Description { get => description; set => description = value; }
        public int Compra_relacionada { get => compra_relacionada; set => compra_relacionada = value; }
        public int Venta_relacionada { get => venta_relacionada; set => venta_relacionada = value; }
        public int Plantilla_predeterminada { get => plantilla_predeterminada; set => plantilla_predeterminada = value; }
        public int Partida_reversion { get => partida_reversion; set => partida_reversion = value; }
        public int Partida_revertida { get => partida_revertida; set => partida_revertida = value; }
    }
}
