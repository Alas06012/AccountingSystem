using CapaNegocio;
using Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Compras
{
    public partial class LibroComprasImprimible : Form
    {
        CN_Documento Negocio = new CN_Documento();
        public LibroComprasImprimible()
        {
            InitializeComponent();
        }

        private void LibroComprasImprimible_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteVentaConsumidor data = Negocio.libroCompras(dateTimePicker1.Value);

            ReporteVentaConsumidorBindingSource.DataSource = data;
            LibroComprasDetallesBindingSource.DataSource = data.Detall;
            this.reportViewer1.RefreshReport();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
