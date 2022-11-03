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

namespace CapaPresentacion.Ventas
{
    public partial class LibroVentaContribuyente_Imprime : Form
    {
        CN_Documento Negocio = new CN_Documento();
        public LibroVentaContribuyente_Imprime()
        {
            InitializeComponent();
        }

        private void LibroVentaContribuyente_Imprime_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteVentaConsumidor data = Negocio.libroVentasContribuyente(dateTimePicker1.Value);

            reporteVentaConsumidorBindingSource.DataSource = data;
            reporteVentasConsumidorDetalleBindingSource.DataSource = data.Detalles;

            this.reportViewer1.RefreshReport();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
