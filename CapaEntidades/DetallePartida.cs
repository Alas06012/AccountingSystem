using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades {
    public class DetallePartida {
        private int Id;
        private int partidaId;
        private int cuentaId;
        private decimal debe;
        private decimal haber;
        private decimal parcial;
        private int padre;
        private decimal saldo_anterior;

        public DetallePartida() { }

        public DetallePartida(int cuentaId, decimal debe, decimal haber)
        {
            
            this.cuentaId = cuentaId;
            this.debe = debe;
            this.haber = haber;
            
        }

        public DetallePartida(int partidaId, int cuentaId, decimal debe, decimal haber, decimal parcial, int padre, decimal saldo_anterior) {
            this.partidaId = partidaId;
            this.cuentaId = cuentaId;
            this.debe = debe;
            this.haber = haber;
            this.parcial = parcial;
            this.padre = padre;
            this.saldo_anterior = saldo_anterior;
        }

        public DetallePartida(int id, int partidaId, int cuentaId, decimal debe, decimal haber, decimal parcial, int padre, decimal saldo_anterior) {
            Id = id;
            this.partidaId = partidaId;
            this.cuentaId = cuentaId;
            this.debe = debe;
            this.haber = haber;
            this.parcial = parcial;
            this.padre = padre;
            this.saldo_anterior = saldo_anterior;
        }

        public int _Id { get => Id; set => Id = value; }
        public int PartidaId { get => partidaId; set => partidaId = value; }
        public int CuentaId { get => cuentaId; set => cuentaId = value; }
        public decimal Debe { get => debe; set => debe = value; }
        public decimal Haber { get => haber; set => haber = value; }
        public decimal Parcial { get => parcial; set => parcial = value; }
        public int Padre { get => padre; set => padre = value; }
        public decimal Saldo_anterior { get => saldo_anterior; set => saldo_anterior = value; }
    }
}
