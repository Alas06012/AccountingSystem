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

namespace CapaPresentacion.Tablas
{
   
    public partial class FormularioKardex : Form
    {
        int producto;
        CN_Productos n_Productos = new CN_Productos();

        public FormularioKardex(int a)
        {
            InitializeComponent();
            this.producto = a;
        }

        private void FormularioKardex_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime desde = new DateTime(txtdesde.Value.Year, txtdesde.Value.Month, txtdesde.Value.Day, 0, 0, 0, 0);

            DateTime hasta = new DateTime(txthasta.Value.Year, txthasta.Value.Month, txthasta.Value.Day, 23, 59, 59, 0);


            var data = n_Productos.Kardex(this.producto, desde, hasta);
            ReporteKardexBindingSource.DataSource = data;
            ReportekardexDetalleBindingSource.DataSource = data.Detalles;
            ProductoBindingSource.DataSource = n_Productos.Buscar(this.producto);

            this.reportViewer1.RefreshReport();
        }




        #region Redimencionar y mover
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }







        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);












        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool mover = false;
        int lx, ly, sw, sh;

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.Location = new Point(lx, ly);
            this.Size = new Size(sw, sh);
            btn_maximizar.Visible = true;
            btn_restaurar.Visible = false;
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

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void panelTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
        }
    }
}
