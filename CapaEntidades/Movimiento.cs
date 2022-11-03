using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{

    public class Movimiento
    {
        private int Id;
        private int producto;
        private int cant;
        private int existencia_anterior;
        private decimal costo;
        private decimal costo_anterior;
        private int tipo;
        private DateTime fecha;
        private string cliente;
        private string doc;

        public Movimiento() { }

        public Movimiento(int id, int producto, int cant, int existencia_anterior, decimal costo, decimal costo_anterior, int tipo, DateTime fecha, string cliente, string doc)
        {
            Id = id;
            this.producto = producto;
            this.cant = cant;
            this.existencia_anterior = existencia_anterior;
            this.costo = costo;
            this.costo_anterior = costo_anterior;
            this.tipo = tipo;
            this.fecha = fecha;
            this.cliente = cliente;
            this.doc = doc;
        }

        public int Id1 { get => Id; set => Id = value; }
        public int Producto { get => producto; set => producto = value; }
        public int Cant { get => cant; set => cant = value; }
        public int Existencia_anterior { get => existencia_anterior; set => existencia_anterior = value; }
        public decimal Costo { get => costo; set => costo = value; }
        public decimal Costo_anterior { get => costo_anterior; set => costo_anterior = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Doc { get => doc; set => doc = value; }
    }
}
