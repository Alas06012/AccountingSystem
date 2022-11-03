using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Tablas
{
    public partial class PartidaIndividualImprimible : Form
    {
        public List<Reportes.ReportePartidaIndividual> Datos = new List<Reportes.ReportePartidaIndividual>();
      

        public PartidaIndividualImprimible()
        {
            InitializeComponent();
        }

        private void PartidaIndividualImprimible_Load(object sender, EventArgs e)
        {

            ReportePartidaIndividualBindingSource.DataSource = Datos;
            this.reportViewer1.RefreshReport();
        }
    }
}
