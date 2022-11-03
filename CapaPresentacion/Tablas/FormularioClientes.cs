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
using CapaEntidades.Utilities;
using System.Text.RegularExpressions;

namespace CapaPresentacion {
    public partial class FormularioClientes : Form {
        CapaNegocio.CN_Clientes Negocio = new CapaNegocio.CN_Clientes();
        private bool busqueda = false;
        private Cliente ClienteSeleccionado;
        public FormularioClientes() {
            InitializeComponent();
        }

        private void GridClientes_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex > -1) {
                ClienteSeleccionado = new Cliente(
                    Int32.Parse(GridClientes.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    GridClientes.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    GridClientes.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    GridClientes.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    GridClientes.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    GridClientes.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    GridClientes.Rows[e.RowIndex].Cells[6].Value.ToString(),
                    GridClientes.Rows[e.RowIndex].Cells[7].Value.ToString(),
                    GridClientes.Rows[e.RowIndex].Cells[8].Value.ToString()
                );
                txtNombre.Text = ClienteSeleccionado.Nombre;
                txtClasificacion.Text = ClienteSeleccionado.Clasificacion;
                txtDireccion.Text = ClienteSeleccionado.Direccion;
                txtNIT.Text = ClienteSeleccionado.Nit;
                txtNCR.Text = ClienteSeleccionado.Nrc;
                txtRazon.Text = ClienteSeleccionado.Razon_social;
                txtGiro.Text = ClienteSeleccionado.Giro;
                txtTelefono.Text = ClienteSeleccionado.Telefono;
                txtID.Text = ClienteSeleccionado._Id.ToString();
     
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(txtBusqueda.Text)) {
                this.busqueda= true;
                GridClientes.DataSource = Negocio.Buscar(txtBusqueda.Text.Trim());
            }
        }

        private void FormularioClientes_Load(object sender, EventArgs e) {
            cargar_clientes();
            btnVer.Enabled = true;
        }

        private void limpiarControles() {
            if (this.busqueda) {
                this.busqueda = false;
                cargar_clientes();
            }
            txtBusqueda.Text = "";
            txtNombre.Text = "";
            txtClasificacion.Text = "";
            txtNIT.Text = "";
            txtNCR.Text = "";
            txtRazon.Text = "";
            txtGiro.Text = "";
            txtTelefono.Text = "";
            txtID.Text = "";
        }
        private void cargar_clientes(){
            GridClientes.DataSource = Negocio.TodosClientes();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e) {
            limpiarControles();
        }

        private void btnVer_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtNombre.Text.Trim())) {
                MessageBox.Show("Llene el campo nombre para Guardar el Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (String.IsNullOrEmpty(txtClasificacion.Text.Trim())) {
                MessageBox.Show("Elija la clasificacion del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (txtClasificacion.Text != "ninguno" && !new Regex("^[0-9]{4}-[0-9]{6}-[0-9]{3}-[0-9]{1}$").IsMatch(txtNIT.Text)) {
                MessageBox.Show("Debe llenar el Campo NIT con el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (txtClasificacion.Text != "ninguno" && !new Regex("^[0-9]{2,6}-[0-9]{1}$").IsMatch(txtNCR.Text)) {
                MessageBox.Show("Debe llenar el Numero de registro con el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                var client = new Cliente(txtNombre.Text.Trim(), txtClasificacion.Text.Trim(), txtDireccion.Text.Trim(), txtNIT.Text.Trim(), txtNCR.Text.Trim(), txtRazon.Text.Trim(), txtGiro.Text.Trim(), txtTelefono.Text.Trim());
                
                if (String.IsNullOrEmpty(txtID.Text)) {
                    client = Negocio.GuardarCliente(client);
                    if (client == null) {
                        MessageBox.Show(Mensaje.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } else {
                        MessageBox.Show("Guardado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else {
                    client._Id = Int32.Parse(txtID.Text);
                    string respuesta = Negocio.ActualizarCliente(client);
                    if (respuesta.Length > 0) {
                        MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } else {
                        MessageBox.Show("Guardado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                limpiarControles();
                cargar_clientes();
            }
        }
    }
}
