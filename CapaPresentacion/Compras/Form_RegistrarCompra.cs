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
using System.Configuration;
using CapaEntidades.Utilities;
using CapaNegocio;
using CapaPresentacion.Ventas;

namespace CapaPresentacion.Compras
{
    public partial class Form_RegistrarCompra : Form
    {
        CN_Compra NegocioCompras = new CN_Compra();
        Producto producto = new Producto();
        Proveedor proveedor = new Proveedor();
        decimal total = 0.00m;
        Dictionary<String, String> clasificaciones = new Dictionary<string, string>
        {
            {"grande","Gran Contribuyente"},{"mediano","Mediano Contribuyente"},{"pequenio","Pequeño Contribuyente"},{"otro","Otro Contribuyente"},{"ninguno","Ninguno"}
        };
        

        public Form_RegistrarCompra()
        {
            InitializeComponent();
            txtFechaFactura.MaxDate = DateTime.Now;
            txtFechaFactura.MinDate = DateTime.Now.AddDays(-60);
        }

        public void LimpiarTodo()
        {
            txtCant.Text = "";
            txtCodigoProducto.Text = "";
            //  txtFechaFactura.Value = DateTime.Now;
            txtNombreProducto.Text = "";
            //  txtNombreProveedor.Text = "";
            //  txtNumFactura.Text = "";
            txtPrecio.Text = "";
            //   num_diasCredito.Value = 0;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btn_BuscarProveedor_Click(object sender, EventArgs e)
        {
            FormBuscarProveedor form = new FormBuscarProveedor();

            if (form.ShowDialog() == DialogResult.OK)
            {
                txtNombreProveedor.Text = form.proveedor.Nombre;
                lblClasificacion.Text = clasificaciones[form.proveedor.Clasificacion];
                this.proveedor = form.proveedor;
                if (this.proveedor.Clasificacion == "grande")
                {
                    RadioBtn_Si.Checked = true;
                    RadioBtn_no.Enabled = false;
                }
                else
                {
                    RadioBtn_no.Checked = true;
                    RadioBtn_no.Enabled = true;
                    RadioBtn_Si.Enabled = false;
                }
                form.Close();
            }
        }

        private void btn_BuscarProducto_Click(object sender, EventArgs e)
        {
            FormBuscarProductocs form = new FormBuscarProductocs();

            if (form.ShowDialog() == DialogResult.OK)
            {
                txtNombreProducto.Text = form.producto.Nombre;
                txtCodigoProducto.Text = form.producto.Codigo;
                this.producto = form.producto;
            }
        }

        private void Form_RegistrarCompra_Load(object sender, EventArgs e)
        {
            txtFechaFactura.MaxDate = DateTime.Now;
            txtFechaFactura.MinDate = DateTime.Now.AddDays(-60);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtCodigoProducto.Text) || String.IsNullOrEmpty(txtNombreProducto.Text) || String.IsNullOrEmpty(txtCant.Text) || String.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("Existen campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (txtCant.Text == "0")
                {
                    MessageBox.Show("No pueden agregarse 0 cantidades.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    int cantidad = Int32.Parse(txtCant.Text);
                    Decimal precio = Decimal.Parse(txtPrecio.Text);

                    int filaAgregada = gridDetalleProducto.Rows.Add();
                    gridDetalleProducto.Rows[filaAgregada].Cells[0].Value = producto.Id.ToString();
                    gridDetalleProducto.Rows[filaAgregada].Cells[1].Value = producto.Codigo;
                    gridDetalleProducto.Rows[filaAgregada].Cells[2].Value = producto.Nombre;
                    gridDetalleProducto.Rows[filaAgregada].Cells[3].Value = cantidad.ToString();
                    gridDetalleProducto.Rows[filaAgregada].Cells[4].Value = precio.ToString();
                    gridDetalleProducto.Rows[filaAgregada].Cells[5].Value = String.Format("{0:c}", cantidad * precio);

                    total += cantidad * precio;
                    totalizar();
                    LimpiarTodo();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Error de formato. ", "Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void totalizar()
        {
            total = 0.00m;

            foreach (DataGridViewRow row in gridDetalleProducto.Rows)
            {
                total +=Int32.Parse(row.Cells[3].Value.ToString()) * Decimal.Parse(row.Cells[4].Value.ToString()); 
            }

            gridTotales.Rows.Clear();
            gridTotales.Rows.Add();
            if (Radiobtn_factura.Checked)
            {
                gridTotales.Rows[0].Cells[0].Value = "TOTAL";
                gridTotales.Rows[0].Cells[1].Value = String.Format("{0:c}",total);
            }
            else
            {
                gridTotales.Rows[0].Cells[0].Value = "SUBTOTAL";
                gridTotales.Rows[0].Cells[1].Value = String.Format("{0:c}", total);

                gridTotales.Rows.Add();
                gridTotales.Rows[1].Cells[0].Value = "IVA";
                gridTotales.Rows[1].Cells[1].Value = String.Format("{0:c}", total * Config.iva);
                bool aplicarRetencion = total >= 100.00m && RadioBtn_creditoFiscal.Checked && RadioBtn_Si.Checked && Config.clasificacion != "Gran Contribuyente";
                if (aplicarRetencion)
                {

                    gridTotales.Rows.Add();
                    gridTotales.Rows[2].Cells[0].Value = "PERCEPCIÓN";
                    gridTotales.Rows[2].Cells[1].Value = String.Format("{0:c}", total * Config.percepcion);



                    gridTotales.Rows.Add();
                    gridTotales.Rows[3].Cells[0].Value = "TOTAL";
                    gridTotales.Rows[3].Cells[1].Value = String.Format("{0:c}", total * (1 + Config.iva - Config.percepcion));
                }
                else
                {

                    gridTotales.Rows.Add();
                    gridTotales.Rows[2].Cells[0].Value = "TOTAL";
                    gridTotales.Rows[2].Cells[1].Value = String.Format("{0:c}", total * (1+Config.iva));

                }



            }



        }



        private void btnQuitar_Click(object sender, EventArgs e)
        {
            gridDetalleProducto.Rows.Remove(gridDetalleProducto.CurrentRow);
            totalizar();

        } 

        private void gridDetalleProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnQuitar.Enabled = true;
        }

        private void RadioBtn_Si_CheckedChanged(object sender, EventArgs e)
        {
            totalizar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombreProveedor.Text.Trim()))
            {
                MessageBox.Show("Llene el campo Proveedor para Guardar el Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txtNumFactura.Text))
            {
                MessageBox.Show("Ingrese el número de la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (total > 0.00m && gridDetalleProducto.Rows.Count > 0)
            {
                List<DetalleCompra> detalles = new List<DetalleCompra>();
                foreach (DataGridViewRow row in gridDetalleProducto.Rows)
                {
                    detalles.Add(new DetalleCompra(
                        Int32.Parse(row.Cells[0].Value.ToString()),
                        Int32.Parse(row.Cells[3].Value.ToString()),
                        Decimal.Parse(row.Cells[4].Value.ToString())
                        ));
                }

                Compra compra = new Compra();
                compra.Proveedor = this.proveedor._Id;
                compra.Condiciones = (int)txtdiasCredito.Value;
                compra.Fecha = txtFechaFactura.Value;
                compra.Document_type = Radiobtn_factura.Checked ? "fcf" : "ccf";
                compra.Document_number = txtNumFactura.Text;

                bool aplicaPercepcion = total >= 100.00m && RadioBtn_creditoFiscal.Checked && RadioBtn_Si.Checked && Config.clasificacion != "Gran Contribuyente";
                bool aplicarRetencion = total >= 100.00m && RadioBtn_no.Checked && Config.clasificacion == "Gran Contribuyente" && proveedor.Clasificacion != "ninguno";
                int id = NegocioCompras.RegistraCompra(detalles, compra, aplicarRetencion, aplicaPercepcion);

                if (id>1)
                {
                    //mostrar form de compra registrada
                    MessageBox.Show("Ingreso exitoso!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LibroDiarioImprimible form = new LibroDiarioImprimible();
                    form.ShowDialog();


                }
                else
                {
                    MessageBox.Show(Mensaje.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }

        }
       
    }
}
