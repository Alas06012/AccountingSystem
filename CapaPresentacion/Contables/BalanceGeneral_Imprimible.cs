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
using Reportes;
using CapaEntidades;
using CapaNegocio;
using CapaPresentacion;

namespace CapaPresentacion.Contables
{
    public partial class BalanceGeneral_Imprimible : Form
    {
        List<BalanceFila> filas = new List<BalanceFila>();

        public BalanceGeneral_Imprimible(List<BalanceFila> filas)
        {
            InitializeComponent();
            this.filas = filas;
        }

        private void BalanceGeneral_Imprimible_Load(object sender, EventArgs e)
        {
            BalanceFilaBindingSource.DataSource = filas;
            this.reportViewer1.RefreshReport();
        }
    }
}
