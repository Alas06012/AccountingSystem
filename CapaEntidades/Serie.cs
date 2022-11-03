using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades {
    public class Serie
    {
        private int id;
        private int inicia_desde;
        private int termina_en;
        private string serie;
        private string tipo; //enum('fcf', 'ccf', 'fex', 'nr', 'nc', 'nd')

        public int Id { get => id; set => id = value; }
        public int Inicia_desde { get => inicia_desde; set => inicia_desde = value; }
        public int Termina_en { get => termina_en; set => termina_en = value; }
        public string _Serie { get => serie; set => serie = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public Serie() { }
        public Serie(int id, int inicia_desde, int termina_en, string serie, string tipo)
        {
            Id = id;
            this.inicia_desde = inicia_desde;
            this.termina_en = termina_en;
            this.serie = serie;
            this.tipo = tipo;
        }

        public Serie(int inicia_desde, int termina_en, string serie, string tipo)
        {
            this.inicia_desde = inicia_desde;
            this.termina_en = termina_en;
            this.serie = serie;
            this.tipo = tipo;
        }

    }
}
