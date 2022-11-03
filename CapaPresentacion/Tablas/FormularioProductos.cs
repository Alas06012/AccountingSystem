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
using CapaNegocio;
using CapaPresentacion.Tablas;

namespace CapaPresentacion {
    public partial class FormularioProductos : Form {

        CN_Productos CapaNegocio = new CN_Productos();
        private bool buscado = false;

        public FormularioProductos() {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FormularioProductos_Load(object sender, EventArgs e) {
            rechargeGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtBuscar.Text)) {
                MessageBox.Show("Colocque algo en el cuadro de busqueda para poder filtrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                gridProductos.DataSource = CapaNegocio.BuscarProducto(txtBuscar.Text);
                buscado = true;
            }
        }

        private void btnClean_Click(object sender, EventArgs e) {
            cleanControls();
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            try
            {
                if (txtId.Text.Length > 0)
                {
                    String resultado = CapaNegocio.EliminarProducto(new Producto(Int32.Parse(txtId.Text)));
                    if (resultado.Length > 0)
                    {
                        MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("registro eliminado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleanControls();
                        rechargeGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Este mensaje no deberia de estarse visualizando");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede eliminar un producto\nque esta siendo utilizado.", "Error/Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void cleanControls() {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtId.Text = "";
            txtExistencias.Text = "";
            txtDescripcion.Text = "";
            txtCosto.Text = "";
            txtCodigo.Text = "";
            txtBuscar.Text = "";

            btnEliminar.Enabled = false;
            if (buscado) {
                rechargeGrid();
                gridProductos.DataSource = CapaNegocio.TodosProductos();
                buscado = false;
            }
        }

        private void rechargeGrid(){
            gridProductos.DataSource = CapaNegocio.TodosProductos();
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtNombre.Text)) {
                MessageBox.Show("El Campo nombre es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (String.IsNullOrEmpty(txtDescripcion.Text)) {
                MessageBox.Show("El Campo descripcion es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (txtPrecio.Value < 0.01m) {
                MessageBox.Show("El Campo precio es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (String.IsNullOrEmpty(txtCodigo.Text)) {
                MessageBox.Show("El Campo Codigo es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else { 
                Producto prod = new Producto();
                prod.Nombre = txtNombre.Text;
                prod.Descripcion = txtDescripcion.Text;
                prod.Precio = txtPrecio.Value;
                prod.Codigo = txtCodigo.Text;
                
                if (!String.IsNullOrEmpty(txtId.Text)) {
                    prod.Id = Convert.ToInt32(txtId.Text);
                    string respuesta = CapaNegocio.ActualizarProducto(prod);
                    if (respuesta.Length > 0) {

                        MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } else {
                        MessageBox.Show("Guardado Correctamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleanControls();
                        rechargeGrid();
                    }
                } else {
                    if (CapaNegocio.CrearProducto(prod) == 0) {
                        txtDescripcion.Text = Mensaje.ErrorMessage;
                        MessageBox.Show(Mensaje.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } else {
                        MessageBox.Show("Guardado Correctamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleanControls();
                        rechargeGrid();
                    }
                }
            }
        }

        private void gridProductos_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex > -1) {
                txtId.Text = gridProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = gridProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtExistencias.Text = gridProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrecio.Text = gridProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtCosto.Text = gridProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDescripcion.Text = gridProductos.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtCodigo.Text = gridProductos.Rows[e.RowIndex].Cells[7].Value.ToString();
                btnEliminar.Enabled = true;


                if (int.Parse(txtId.Text) > 0)
                {
                    btnVer.Enabled = true;
                }
                else
                {
                    btnVer.Enabled = false;
                }

            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtId.Text) > 0)
            {
               
                var form = new VerProducto(Int32.Parse(txtId.Text), txtNombre.Text, txtExistencias.Text,txtDescripcion.Text, txtPrecio.Text, txtCodigo.Text, txtCosto.Text);
                form.Show();
            }
  
        }
    }

}
