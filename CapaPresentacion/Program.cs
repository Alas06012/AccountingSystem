using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Compras;
using CapaEntidades.Utilities;
using System.Configuration;
using CapaPresentacion.Ventas;
using CapaPresentacion.Tablas;
using CapaPresentacion.Contables;

namespace CapaPresentacion {
    static class Program {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Config.clasificacion = ConfigurationManager.AppSettings["clasificacion"];
            Config.iva = Convert.ToDecimal(ConfigurationManager.AppSettings["IVA"]);
            Config.retencion = Decimal.Parse(ConfigurationManager.AppSettings["Retencion"]);
            Config.percepcion = Convert.ToDecimal(ConfigurationManager.AppSettings["Percepcion"]);

            Application.Run(new Login());



        }
    }
}
