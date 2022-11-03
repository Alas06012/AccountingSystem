using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades.Utilities;
using CapaNegocio;
using CapaEntidades;
using System.Runtime.InteropServices;
using Reportes;

namespace CapaPresentacion.Ventas
{
    public partial class LibroMayor : Form
    {
        CuentaCatalogo CuentaCatalogo = new CuentaCatalogo();
       CN_Conta negocio = new CN_Conta();

        int cuenta;

       


        public LibroMayor(int cuenta)
        {
            InitializeComponent();
            this.cuenta = cuenta;
            this.CuentaCatalogo = negocio.Buscar(cuenta);
        }
         
        private void Mayorizacion_Load(object sender, EventArgs e)
        {
            lblSaldoTipo.Text = "Tipo de Saldo: " + CuentaCatalogo.Tipo_saldo;
            lblcuentaNombre.Text = CuentaCatalogo.Nombre;
            
            
            
            DataTable table = negocio.DetalleMayor(this.cuenta);

            
            foreach (DataRow row in table.Rows)
            {
               int id = dataGridView1.Rows.Add();
                DateTime fecha = Convert.ToDateTime(row["fecha"].ToString());

                decimal saldo = Decimal.Parse(row["saldo_anterior"].ToString());

                dataGridView1.Rows[id].Cells[0].Value = fecha.ToString("dd/MM/yyyy h:mm:ss tt");
                dataGridView1.Rows[id].Cells[1].Value = row["numero"].ToString();
                dataGridView1.Rows[id].Cells[2].Value = row["codigo"].ToString();
                dataGridView1.Rows[id].Cells[3].Value = row["descripcion"].ToString();

                if (Decimal.Parse(row["debe"].ToString()) > 0)
                {
                    dataGridView1.Rows[id].Cells[4].Value = row["debe"].ToString();
                    dataGridView1.Rows[id].Cells[5].Value = "";
                }
                else
                {
                    dataGridView1.Rows[id].Cells[4].Value = "";
                    dataGridView1.Rows[id].Cells[5].Value = row["haber"].ToString();
                    dataGridView1.Rows[id].Cells[6].Value = row["numero"].ToString();
                }


                dataGridView1.Rows[id].Cells[6].Value = CuentaCatalogo.Tipo_saldo == "ACREEDOR"
                    ? (Decimal.Parse(row["saldo_anterior"].ToString()) + Decimal.Parse(row["haber"].ToString()) - Decimal.Parse(row["debe"].ToString())).ToString()
                    : (Decimal.Parse(row["saldo_anterior"].ToString()) + Decimal.Parse(row["debe"].ToString()) - Decimal.Parse(row["haber"].ToString())).ToString();


            }

        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {

            LibroMayor_imprime report = new LibroMayor_imprime();

            if (dataGridView1.RowCount == 1)
            {
                MessageBox.Show("No hay nada que mostrar.", "Libro Mayor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    DateTime fechaa = DateTime.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());

                    ReporteLibroMayor datos = new ReporteLibroMayor();
                    datos.tipoSaldo = CuentaCatalogo.Tipo_saldo;
                    datos.nombre = CuentaCatalogo.Nombre;
                    datos.fecha = fechaa;
                    datos.partida = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                    datos.codigo = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
                    datos.enunciado = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
                    datos.cargos = dataGridView1.Rows[i].Cells[4].Value.ToString() == "" ? 0.00m : Decimal.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    datos.abonos = dataGridView1.Rows[i].Cells[5].Value.ToString() == "" ? 0.00m : Decimal.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                    datos.saldos = dataGridView1.Rows[i].Cells[6].Value.ToString() == "" ? 0.00m : Decimal.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());

                    report.datos.Add(datos);
                }
                report.ShowDialog();
            }

            
        }



        #region Todo lo que tiene que ver con movimiento del form
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region Redimencionar y mover
        
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion







        bool mover = false;
        int lx, ly, sw, sh;

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btn_maximizar.Visible = false;
            btn_restaurar.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {

            this.Location = new Point(lx, ly);
            this.Size = new Size(sw, sh);
            btn_maximizar.Visible = true;
            btn_restaurar.Visible = false;
        }

        

        private void panel_Titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void panel_Titulo_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void panel_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
        }

        #endregion
    }
}
