using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades {
    class Saldo {
        private int Id;
        private int cuentaId;
        private double debe;
        private double haber;
        private string hasta;
        public Saldo() { }
        public Saldo(int cuentaId, double debe, double haber, string hasta) {
            this.CuentaId = cuentaId;
            this.Debe = debe;
            this.Haber = haber;
            this.Hasta = hasta;
        }

        public Saldo(int id, int cuentaId, double debe, double haber, string hasta) {
            this.Id = id;
            this.CuentaId = cuentaId;
            this.Debe = debe;
            this.Haber = haber;
            this.Hasta = hasta;
        }

        public int _Id { get => Id; set => Id = value; }
        public int CuentaId { get => cuentaId; set => cuentaId = value; }
        public double Debe { get => debe; set => debe = value; }
        public double Haber { get => haber; set => haber = value; }
        public string Hasta { get => hasta; set => hasta = value; }
    }
}
