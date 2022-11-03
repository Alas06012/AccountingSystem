using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion {
    public partial class Login : Form {
        CapaNegocio.CN_Usuarios Negocio = new CapaNegocio.CN_Usuarios();

        public Login() {
            InitializeComponent();
        }

      

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool mover = false;

        private void panel_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
        }

        private void panel_Titulo_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void panel_Titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
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

        public void iniciarSesion()
        {
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Coloque su nombre de Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtPass.Text) || txtPass.Text.Length < 8)
            {
                MessageBox.Show("Contraseña Invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                String respuesta = Negocio.Login(txtUsuario.Text, txtPass.Text);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Hide();
                    FormBienvenido Bienvenido = new FormBienvenido();
                    Bienvenido.ShowDialog();
                    FormularioPrincipal principal = new FormularioPrincipal();
                    principal.Show();
                    this.Hide();
                }
            }
        }
       
        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            iniciarSesion();
        }
    }
}
