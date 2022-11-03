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
using CapaPresentacion.Compras;
using CapaPresentacion.FormsInicio;
using CapaPresentacion.Ventas;

namespace CapaPresentacion {
    public partial class FormularioPrincipal : Form {
        public FormularioPrincipal() {
            InitializeComponent();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e) {
            lbl_Bienvenido.Text = "Bienvenido de nuevo \n"+ "\t"+UsuarioCache.nombre;
        }


        int lx, ly, sw, sh;
       

        private void btnCerrar_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Size antes = new Size(190, 843);
        Size despues = new Size(46, 843);
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            lbl_Bienvenido.Visible = false;
            btn_CerrarSesion.Visible = false;

            menuLateral.Size = despues;
            

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            menuLateral.Size = antes;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            lbl_Bienvenido.Visible = true;
            btn_CerrarSesion.Visible = true;
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

      
        bool mover = false;
        private void panelTitulo_MouseDown(object sender, MouseEventArgs e) {
            mover = true;
        }
        private void panelTitulo_MouseUp(object sender, MouseEventArgs e) {
            mover = false;
        }
        private void panelTitulo_MouseMove(object sender, MouseEventArgs e) {
            if (mover) {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormularioClientes>("abierto");
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormularioProductos>("abierto");
        }

        private void btn_Proveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormularioProveedores>("abierto");
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form_RegistrarVenta>("abierto");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form_RegistrarCompra>("abierto");
        }

        private void btn_Usuarios_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<VistaReportes>("abierto");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormularioUsuarios>("abierto");
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (panelLibros.Visible == false)
            {
                panelLibros.Visible = true;

            }
            else
            {
                panelLibros.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<LibroVentasConsumidor>("abierto");
        }





        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            
        }



        public void AbrirFormulario<Formulario>(string caso) where Formulario : Form, new() {
            Form formulario;
            if (caso == "abierto") {
                formulario = panelContenedor.Controls.OfType<Formulario>().FirstOrDefault();
            } else { 
                formulario = Application.OpenForms.OfType<Formulario>().FirstOrDefault();
            }
            if (formulario == null) {
                formulario = new Formulario();
                if (caso == "abierto") {
                    formulario.Dock = DockStyle.Fill;
                    formulario.FormBorderStyle = FormBorderStyle.None;
                    formulario.TopLevel = false;
                    panelContenedor.Controls.Add(formulario);
                    panelContenedor.Tag = formulario;
                }
                formulario.Show();
            } else {
                formulario.BringToFront();
            }
        }

        #region Redimencionar y mover
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;

      

        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m) {
            switch (m.Msg) {
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
        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.MainContainer.Region = region;
            this.Invalidate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<LibroComprasImprimible>("abierto");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormulario<LibroVentaContribuyente_Imprime>("abierto");
        }

        private void menuLateral_Paint(object sender, PaintEventArgs e)
        {

        }


















        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e) {
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
    }
}
