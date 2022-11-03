using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;
using CapaEntidades;
using CapaEntidades.Utilities;
using CapaNegocio;
using CapaPresentacion.Ventas;

namespace CapaPresentacion.Tablas
{
    public partial class VerCatalogo : Form
    {
        CN_Conta negocio = new CN_Conta();
        CuentaCatalogo cuenta_elegida = new CuentaCatalogo();


        public VerCatalogo()
        {
            InitializeComponent();
        }

        private void VerCatalogo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negocio.Cuentas();
        }


        private void btnLibroMayor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index > -1)
            {
                var form = new LibroMayor(Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                form.ShowDialog();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (Int32.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()) == 1 || Int32.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()) == 2)
                {
                    btnLibroMayor.Enabled = false;
                }
                else
                {
                    btnLibroMayor.Enabled = true;
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
