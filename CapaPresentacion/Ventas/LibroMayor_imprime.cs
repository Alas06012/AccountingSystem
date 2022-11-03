using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Ventas
{
    public partial class LibroMayor_imprime : Form
    {
        public List<Reportes.ReporteLibroMayor> datos = new List<Reportes.ReporteLibroMayor>();
        public LibroMayor_imprime()
        {
            InitializeComponent();
        }

        private void LibroMayor_imprime_Load(object sender, EventArgs e)
        {
            ReporteLibroMayorBindingSource.DataSource = datos;
            this.reportViewer1.RefreshReport();
        }
    }
}
