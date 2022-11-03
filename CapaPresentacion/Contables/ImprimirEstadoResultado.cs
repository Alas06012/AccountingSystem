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
using CapaEntidades.Utilities;
using Reportes;

namespace CapaPresentacion.Contables
{
    public partial class ImprimirEstadoResultado : Form
    {
        EstadoResultados resultados;
        List<CuentaCatalogo> lista_gastos;


        public ImprimirEstadoResultado(EstadoResultados resultados, List<CuentaCatalogo> lista_gastos)
        {
            InitializeComponent();
            this.resultados = resultados;
            this.lista_gastos = lista_gastos;

        }

        private void ImprimirEstadoResultado_Load(object sender, EventArgs e)
        {
            EstadoResultadosBindingSource.DataSource = this.resultados;
            CuentaCatalogoBindingSource.DataSource = lista_gastos;
            this.reportViewer1.RefreshReport();
        }
    }
}
