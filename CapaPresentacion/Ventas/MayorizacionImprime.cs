using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion.Ventas
{
    public partial class MayorizacionImprime : Form
    {
        CN_Conta negocio = new CN_Conta();

        public MayorizacionImprime()
        {
            InitializeComponent();
        }

        private void MayorizacionImprime_Load(object sender, EventArgs e)
        {
            ReporteDiarioBindingSource.DataSource = negocio.buscarPartida(null);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
