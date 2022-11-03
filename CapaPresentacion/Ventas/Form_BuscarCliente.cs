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
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion.Ventas
{
    public partial class Form_BuscarCliente : Form
    {
        CN_Clientes negocio = new CN_Clientes();

        public Cliente cliente = new Cliente();

        bool filtrar = false;

        bool mover = false;


        public Form_BuscarCliente()
        {
            InitializeComponent();
        }

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
        #endregion

     

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBuscar.Text.Trim()))
            {
                gridProducto.DataSource = negocio.Buscar(txtBuscar.Text.Trim());
                filtrar = true;
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            if (filtrar)
            {
                gridProducto.DataSource = negocio.TodosClientes();
                filtrar = false;
            }
        }

        private void gridProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                cliente._Id = Int32.Parse(gridProducto.Rows[e.RowIndex].Cells[0].Value.ToString());
                cliente.Nombre = gridProducto.Rows[e.RowIndex].Cells[1].Value.ToString();
                cliente.Clasificacion = gridProducto.Rows[e.RowIndex].Cells[2].Value.ToString();
                cliente.Nit = gridProducto.Rows[e.RowIndex].Cells[3].Value.ToString();
                cliente.Nrc = gridProducto.Rows[e.RowIndex].Cells[4].Value.ToString();
                cliente.Direccion = gridProducto.Rows[e.RowIndex].Cells[5].Value.ToString();
                btnSeleccionar.Enabled = true;
            }
        }

        private void Form_BuscarCliente_Load(object sender, EventArgs e)
        {
            gridProducto.DataSource = negocio.TodosClientes();
            btnSeleccionar.Enabled = false;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
    }
}
