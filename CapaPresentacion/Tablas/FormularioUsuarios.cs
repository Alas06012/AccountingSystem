using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion {
    public partial class FormularioUsuarios : Form {
        CN_Usuarios CapaNegocio = new CN_Usuarios();
        public FormularioUsuarios() {
            InitializeComponent();
        }

        private void FormularioUsuarios_Load(object sender, EventArgs e) {
            LimpiarActualizar();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            if (txtBuscar.Text.Trim().Length < 2) {
                MessageBox.Show("Para poder filtrar escriba algo en el campo de busqueda");
            } else {
                List<String> campos = new List<string> { "nombre", "usuario", "estado" };
                List<Usuario> users = CapaNegocio.Buscar(campos, txtBuscar.Text);
                gridUsuarios.DataSource = users;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtNombre.Text) || txtNombre.Text.Length < 5) {
                MessageBox.Show("El campo Nombre debe contener al menos cinco caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (String.IsNullOrEmpty(txtUsuario.Text) || txtUsuario.Text.Length < 4) {
                MessageBox.Show("El campo Nombre debe contener al menos cuatro caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (String.IsNullOrEmpty(txtID.Text) && (String.IsNullOrEmpty(txtPass.Text) || txtPass.Text.Length < 8)) {
                MessageBox.Show("la Contraseña debe contener al menos ocho caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                Usuario user = new Usuario();
                user.Nombre = txtNombre.Text;
                user.Contra = txtPass.Text;
                user._Usuario = txtUsuario.Text;

                String respuesta = "";

                if (String.IsNullOrEmpty(txtID.Text)) {
                    respuesta = CapaNegocio.CrearUsuario(user);
                } else {
                    user._Id = Int32.Parse(txtID.Text);
                    respuesta = CapaNegocio.ActualizarUsuario(user);
                }

                if (respuesta.Length > 0) {
                    MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else {
                    MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarActualizar();
                }
            }
        }


        public void LimpiarActualizar() {
            gridUsuarios.DataSource = CapaNegocio.TodosUsuarios();
            txtBuscar.Text = "";
            txtID.Text = "";
            txtNombre.Text = "";
            txtPass.Text = "";
            txtUsuario.Text = "";
            btnActivar.Enabled = false;
            btnDesactivar.Enabled = false;
        }

       

        private void btnClean_Click(object sender, EventArgs e) {
            LimpiarActualizar();
        }

        private void btnActivar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtID.Text)) {
                MessageBox.Show("Error del programador, esta accion no deberia ser posible");
            } else {
                string a = CapaNegocio.ActivarUsuario(new Usuario(Int32.Parse(txtID.Text)));
                if (a.Length > 0) {
                    MessageBox.Show(a, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else {
                    MessageBox.Show("Usuario Activado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarActualizar();

                }
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtID.Text)) {
                MessageBox.Show("Error del programador, esta accion no deberia ser posible");
            } else {
                string a = CapaNegocio.DesactivarUsuario(new Usuario(Int32.Parse(txtID.Text)));
                if (a.Length > 0) {
                    MessageBox.Show(a, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else {
                    MessageBox.Show("Usuario Activado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarActualizar();

                }
            }
        }

        private void gridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                String estado = gridUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtPass.Enabled = false;
                txtID.Text = gridUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = gridUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtUsuario.Text = gridUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                btnActivar.Enabled = estado != "activo";
                btnDesactivar.Enabled = estado == "activo";
            }
        }
    }
}
