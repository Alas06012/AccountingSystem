using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion.Ventas
{
    public partial class FormSerie : Form
    {

        CN_Series negocio = new CN_Series();
        public Serie serie = new Serie();

        public FormSerie()
        {
            InitializeComponent();
        }

        bool mover = false;
        bool filtrar = false;


        #region Redimencionar y mover
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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

        private void FormSerie_Load(object sender, EventArgs e)
        {
            gridSerie.DataSource = negocio.Todos();
            txtserie.Text = "";
            txtdesde.Value = 0;
            txthasta.Value = 0;
            cmbtipo.SelectedIndex = 0;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void gridSerie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                serie.Id = Int32.Parse(gridSerie.Rows[e.RowIndex].Cells[0].Value.ToString());
                serie.Inicia_desde = Int32.Parse(gridSerie.Rows[e.RowIndex].Cells[1].Value.ToString());
                serie.Termina_en = Int32.Parse(gridSerie.Rows[e.RowIndex].Cells[2].Value.ToString());
                serie._Serie = gridSerie.Rows[e.RowIndex].Cells[3].Value.ToString();
                serie.Tipo = gridSerie.Rows[e.RowIndex].Cells[4].Value.ToString();


                btnSeleccionar.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtserie.Text == "")
            {
                MessageBox.Show("Para guardar debe ingresar un número de serie.", "Error/Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtdesde.Value == txthasta.Value)
            {
                MessageBox.Show("Ingrese un rango valido.", "Error/Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbtipo.Text != "ccf" && cmbtipo.Text != "fcf" && cmbtipo.Text != "nc" && cmbtipo.Text != "fex" && cmbtipo.Text != "nr" && cmbtipo.Text != "nd")
            {
                MessageBox.Show("Ingrese un tipo valido.", "Error/Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int a = int.Parse(txtdesde.Value.ToString());
                int b = int.Parse(txthasta.Value.ToString());
                string result = negocio.Ingresar(a, b, txtserie.Text, cmbtipo.Text);

                MessageBox.Show(result);
                gridSerie.DataSource = negocio.Todos();
            }
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtserie.Text = "";
            txtdesde.Value = 0;
            txthasta.Value = 0;
            cmbtipo.SelectedIndex = 0;
        }
    }
}
