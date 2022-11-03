using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaEntidades.Utilities;
using CapaNegocio;

namespace CapaPresentacion {
    public partial class FormularioProveedores : Form {
        private CN_Proveedores Negocio = new CN_Proveedores();
        private bool filtrado = false;
        private Proveedor selecteProvider;

        public FormularioProveedores() {
            InitializeComponent();
        }

        public void cargar_Proveedores() {
            gridProveedor.DataSource = Negocio.Todos();
        }

        public void limpiar() {
            txtNombre.Text = "";
            txtTipo.Text = "";
            txtClasificacion.Text = "";
            txtNIT.Text = "";
            txtRegistro.Text = "";
            txtRazon.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            TxtId.Text = "";
            txtBusqueda.Text = "";
            btnDelete.Enabled = false;

            if (filtrado) {
                filtrado = false;
                cargar_Proveedores();
            }
        }

        private void FormularioProveedores_Load(object sender, EventArgs e) {
            cargar_Proveedores();
        }

        private void btnClean_Click(object sender, EventArgs e) {
            limpiar();
        }

        private void gridProveedor_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex > -1) {
                selecteProvider = new Proveedor(
                    Int32.Parse(gridProveedor.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    gridProveedor.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    gridProveedor.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    gridProveedor.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    gridProveedor.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    gridProveedor.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    gridProveedor.Rows[e.RowIndex].Cells[6].Value.ToString(),
                    gridProveedor.Rows[e.RowIndex].Cells[7].Value.ToString(),
                    gridProveedor.Rows[e.RowIndex].Cells[8].Value.ToString()
                );
                txtNombre.Text = selecteProvider.Nombre;
                txtTipo.Text = selecteProvider.Tipo;
                txtClasificacion.Text = selecteProvider.Clasificacion;
                txtNIT.Text = selecteProvider.Nit;
                txtRegistro.Text = selecteProvider.Nrc;
                txtRazon.Text = selecteProvider.Razon_social;
                txtDireccion.Text = selecteProvider.Direccion;
                txtTelefono.Text = selecteProvider.Telefono;
                TxtId.Text = selecteProvider._Id.ToString();
                btnDelete.Enabled = true;
            }
        }

        private void txtBuscar_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(txtBusqueda.Text.Trim())) {
                gridProveedor.DataSource =  Negocio.Busqueda(txtBusqueda.Text.Trim());
                filtrado = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(TxtId.Text)) {
                MessageBox.Show("Error, esto no deberia de ser posible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                string respuesta = Negocio.Eliminar(new Proveedor(Int32.Parse(TxtId.Text)));
                if (respuesta.Length >0) {
                    MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    MessageBox.Show("Proveedor Eliminado del Sistema", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    cargar_Proveedores();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtNombre.Text)) {
                MessageBox.Show("Escriba el nombre del proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (String.IsNullOrEmpty(txtTipo.Text.Trim())) {
                MessageBox.Show("Elija el tipo de proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (String.IsNullOrEmpty(txtClasificacion.Text.Trim())) {
                MessageBox.Show("Elija la clasificacion del Proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (txtClasificacion.Text != "ninguno" && !new Regex("^[0-9]{4}-[0-9]{6}-[0-9]{3}-[0-9]{1}$").IsMatch(txtNIT.Text)) {
                MessageBox.Show("Debe llenar el Campo NIT con el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (txtClasificacion.Text != "ninguno" && !new Regex("^[0-9]{2,6}-[0-9]{1}$").IsMatch(txtRegistro.Text)) {
                MessageBox.Show("Debe llenar el Numero de registro con el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {

                Proveedor prov = new Proveedor(
                    txtTipo.Text,
                    txtClasificacion.Text,
                    txtNIT.Text,
                    txtRegistro.Text,
                    txtNombre.Text,
                    txtRazon.Text,
                    txtDireccion.Text,
                    txtTelefono.Text
                );

                if (String.IsNullOrEmpty(TxtId.Text)) {
                    prov = Negocio.guardar(prov);
                    if (prov == null) {
                        MessageBox.Show(Mensaje.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } else {
                        MessageBox.Show("Guardado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        cargar_Proveedores();
                    }
                } else {
                    prov._Id = Int32.Parse(TxtId.Text);
                    string respuesta = Negocio.Actualizar(prov);
                    if (respuesta.Length > 0) {
                        MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } else {
                        MessageBox.Show("Guardado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        cargar_Proveedores();
                    }
                }
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
