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

namespace CapaPresentacion.Compras
{
    public partial class FormBuscarProductocs : Form
    {
       CN_Productos negocio = new CN_Productos();

        public Producto producto = new Producto();

        bool filtrar = false;

        bool venta = false;

        public FormBuscarProductocs()
        {
            InitializeComponent();
        }

        public FormBuscarProductocs(bool a)
        {
            InitializeComponent();
            venta = a;
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

       

        private void btn_cerrar_Click(object sender, EventArgs e)
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
                if (venta == true)
                {
                    gridProducto.DataSource = negocio.BuscarProducto(txtBuscar.Text.Trim()).Where(producto => producto.Existencias > 0).ToList();
                }
                else
                {
                    gridProducto.DataSource = negocio.BuscarProducto(txtBuscar.Text.Trim());
                }
               
                filtrar = true;
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            if (filtrar)
            {
                gridProducto.DataSource = negocio.TodosProductos();
                filtrar = false;
            }
        }

        private void gridProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                producto.Id = Int32.Parse(gridProducto.Rows[e.RowIndex].Cells[0].Value.ToString());
                producto.Codigo = gridProducto.Rows[e.RowIndex].Cells[1].Value.ToString();
                producto.Nombre = gridProducto.Rows[e.RowIndex].Cells[2].Value.ToString();
                producto.Existencias = Convert.ToInt32(gridProducto.Rows[e.RowIndex].Cells[3].Value.ToString());
                producto.Precio = Convert.ToDecimal(gridProducto.Rows[e.RowIndex].Cells[4].Value.ToString());
                

                btnSeleccionar.Enabled = true;
            }
        }

        private void FormBuscarProductocs_Load(object sender, EventArgs e)
        {
            gridProducto.DataSource = venta ? negocio.TodosProductos().Where(producto => producto.Existencias > 0).ToList() : negocio.TodosProductos();
            btnSeleccionar.Enabled = false; 
        }

        private void btnCerrar_Click(object sender, EventArgs e)
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