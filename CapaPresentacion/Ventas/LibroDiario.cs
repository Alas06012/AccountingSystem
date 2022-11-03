using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reportes;
using CapaNegocio;
using CapaEntidades.Utilities;
using CapaPresentacion.FormsInicio;

namespace CapaPresentacion.Ventas
{
    public partial class LibroDiario : Form
    {
        CN_Conta Negocio = new CN_Conta();

        public LibroDiario()
        {
            InitializeComponent();
        }

        private void LibroDiario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Negocio.buscarPartida(null);
           

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new LibroDiarioImprimible();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
