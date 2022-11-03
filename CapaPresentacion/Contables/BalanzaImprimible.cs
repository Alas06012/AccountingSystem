using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Contables
{
    public partial class BalanzaImprimible : Form
    {
        List<CuentaCatalogo> cuentas;


        public BalanzaImprimible(List<CuentaCatalogo> cuentas)
        {
            InitializeComponent();
            this.cuentas = cuentas;
        }

        private void BalanzaImprimible_Load(object sender, EventArgs e)
        {
            CuentaCatalogoBindingSource.DataSource = cuentas;
            this.reportViewer1.RefreshReport();
        }
    }
}
