using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Reportes;


namespace CapaPresentacion
{
    public partial class LibroVentasConsumidor : Form
    {
        CN_Documento Negocio = new CN_Documento();


        public LibroVentasConsumidor()
        {
            InitializeComponent();
        }

        private void LibroVentasConsumidor_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteVentaConsumidor data = Negocio.libroVentasConsumidor(dateTimePicker1.Value);

            ReporteVentaConsumidorBindingSource.DataSource = data;
            ReporteVentasConsumidorDetalleBindingSource.DataSource = data.Detalles;

            this.reportViewer1.RefreshReport();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
