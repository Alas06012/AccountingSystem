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
using CapaPresentacion.Contables;
using CapaEntidades;

namespace CapaPresentacion.Contables
{
    public partial class BalanzaComprobacion : Form
    {
        CN_Conta negocio = new CN_Conta();
        List<CuentaCatalogo> cuentas;

        public BalanzaComprobacion()
        {
            InitializeComponent();
            cuentas = negocio.Cuentas();
        }

        private void BalanzaComprobacion_Load(object sender, EventArgs e)
        {
            cargarBalanza();


        }

        private void cargarBalanza()
        {
            decimal debe = 0.00m, haber = 0.00m, deudor = 0.00m, acreedor = 0.00m;




            cuentas = negocio.Cuentas().Where(cuenta => cuenta.Nivel == 3 && (cuenta.Debe > 0 || cuenta.Haber > 0)).ToList();

            foreach (CuentaCatalogo cuenta in cuentas)
            {
                if (cuenta.Nivel == 3 && (cuenta.Debe > 0 || cuenta.Haber > 0))
                {
 
                        int id = dataGridView1.Rows.Add();

                        dataGridView1.Rows[id].Cells[0].Value = cuenta.Codigo;
                        dataGridView1.Rows[id].Cells[1].Value = cuenta.Nombre;
                        dataGridView1.Rows[id].Cells[2].Value = cuenta.Debe > 0 ? String.Format("{0:c}", cuenta.Debe) : "";
                        dataGridView1.Rows[id].Cells[3].Value = cuenta.Haber > 0 ? String.Format("{0:c}", cuenta.Haber) : "";

                        if (cuenta.Debe > cuenta.Haber)
                        {
                            deudor += cuenta.Debe - cuenta.Haber;
                            dataGridView1.Rows[id].Cells[4].Value = String.Format("{0:c}", cuenta.Debe - cuenta.Haber);
                            dataGridView1.Rows[id].Cells[5].Value = "";

                        }
                        else if (cuenta.Debe == cuenta.Haber)
                        {
                            dataGridView1.Rows[id].Cells[4].Value = "";
                            dataGridView1.Rows[id].Cells[5].Value = "";
                        }
                        else
                        {
                            acreedor += cuenta.Haber - cuenta.Debe;
                            dataGridView1.Rows[id].Cells[5].Value = String.Format("{0:c}", cuenta.Haber - cuenta.Debe);
                            dataGridView1.Rows[id].Cells[4].Value = "";
                        }

                        debe += cuenta.Debe;
                        haber += cuenta.Haber;

                    


                }



            }

            int id2 = dataGridView1.Rows.Add();

            dataGridView1.Rows[id2].Cells[0].Value = "";
            dataGridView1.Rows[id2].Cells[1].Value = "TOTALES";
            dataGridView1.Rows[id2].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Rows[id2].Cells[2].Value = String.Format("{0:c}", debe);
            dataGridView1.Rows[id2].Cells[3].Value = String.Format("{0:c}", haber);
            dataGridView1.Rows[id2].Cells[4].Value = String.Format("{0:c}", deudor);
            dataGridView1.Rows[id2].Cells[5].Value = String.Format("{0:c}", acreedor);

        }

      
        private void button1_Click(object sender, EventArgs e)
        {

            BalanzaImprimible form = new BalanzaImprimible(cuentas);
            form.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
