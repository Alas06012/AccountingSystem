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
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion.Compras
{
    public partial class FormBuscarProveedor : Form
    {

        CN_Proveedores negocio = new CN_Proveedores();

        public Proveedor proveedor = new Proveedor();


        bool filtrar = false;

        public FormBuscarProveedor()
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

        bool mover = false;

        private void FormBuscarProveedor_Load(object sender, EventArgs e)
        {
            gridProveedores.DataSource = negocio.Todos();
            btnSeleccionar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBuscar.Text.Trim()))
            {
                gridProveedores.DataSource = negocio.Busqueda(txtBuscar.Text.Trim());
                filtrar = true;
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            if (filtrar)
            {
                gridProveedores.DataSource = negocio.Todos();
                filtrar = false;
            }
        }

        private void gridProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                proveedor._Id = Int32.Parse(gridProveedores.Rows[e.RowIndex].Cells[0].Value.ToString());
                proveedor.Nombre = gridProveedores.Rows[e.RowIndex].Cells[1].Value.ToString();
                proveedor.Clasificacion = gridProveedores.Rows[e.RowIndex].Cells[3].Value.ToString();
                proveedor.Tipo = gridProveedores.Rows[e.RowIndex].Cells[2].Value.ToString();

                btnSeleccionar.Enabled = true;


            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
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
