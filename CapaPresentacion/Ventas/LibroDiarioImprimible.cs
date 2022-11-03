using CapaNegocio;
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
    public partial class LibroDiarioImprimible : Form
    {
        CN_Conta negocio = new CN_Conta();


        public LibroDiarioImprimible()
        {
            InitializeComponent();
        }
 
        private void LibroDiarioImprimible_Load(object sender, EventArgs e)
        {
            ReporteDiarioBindingSource.DataSource = negocio.buscarPartida(null);
            this.reportViewer1.RefreshReport();
        }
    }
}
