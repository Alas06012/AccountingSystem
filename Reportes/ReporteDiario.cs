using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportes
{

    //SELECT c_cuentas.codigo, c_cuentas.nombre, c_partida.fecha, c_partida.descripcion, c_partida.Id as numero, c_detallepartida.debe, c_detallepartida.haber, c_detallepartida.cuentaId as id_cuenta FROM c_partida INNER JOIN c_detallepartida on c_detallepartida.partidaId = c_partida.Id INNER JOIN c_cuentas on c_detallepartida.cuentaId = c_cuentas.Id 

    public class ReporteDiario
    {
        string codigo;
        string nombre;
        string descripcion;
        string fecha;
        int numero;
        int idCuenta;
        Decimal debe;
        Decimal haber;

        public ReporteDiario()
        {
            
        }

        public ReporteDiario(string codigo, string nombre, string descripcion, string fecha, int numero, int idCuenta, decimal debe, decimal haber)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.numero = numero;
            this.idCuenta = idCuenta;
            this.debe = debe;
            this.haber = haber;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Numero { get => numero; set => numero = value; }
        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public decimal Debe { get => debe; set => debe = value; }
        public decimal Haber { get => haber; set => haber = value; }
    }
}
