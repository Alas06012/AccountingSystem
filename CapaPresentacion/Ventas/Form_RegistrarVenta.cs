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
using CapaPresentacion.Compras;
using System.Configuration;
using System.Text.RegularExpressions;

namespace CapaPresentacion.Ventas
{
    public partial class Form_RegistrarVenta : Form
    {


        //List<Serie> allseries;
        Cliente cliente;

        Producto producto;
        CN_Documento NegocioDocumento = new CN_Documento();
        CN_Clientes clienteee = new CN_Clientes();
        CN_Series series = new CN_Series();
        List<Serie> TodoSeries = new List<Serie>();

        int T =1;
        string tiposeleccionado;
        //CN_Serie NegocioSerie = new CN_Serie();

        decimal IVA = decimal.Parse(ConfigurationManager.AppSettings["IVA"]);
        decimal Percepcion = decimal.Parse(ConfigurationManager.AppSettings["Percepcion"]);
        decimal Retencion = decimal.Parse(ConfigurationManager.AppSettings["Retencion"]);

        decimal SubtotalAfectas = 0.00m;
        decimal SubtotalExentas = 0.00m;

        public Form_RegistrarVenta()
        {
            InitializeComponent();
            
        }

        private void Form_RegistrarVenta_Load(object sender, EventArgs e)
        {
            ExentaNo.Checked = true;
            RetencionNo.Checked = true;
            cmbDetailType.SelectedIndex = 0;
            cmbTipoDocumento.SelectedIndex = 0;
            T = 0;

            TodoSeries = series.Todos();
            //allseries = NegocioSerie.Todos();
            //cmbTipoDocumento.SelectedIndex = 0;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form_BuscarCliente form = new Form_BuscarCliente();

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.cliente = form.cliente;

                txtCliente.Text = cliente.Nombre;
                txtDireccion.Text = cliente.Direccion;
                txtRegistro.Text = cliente.Nrc;
                txtNit.Text = cliente.Nit;
                txtClienteClasificacion.Text = cliente.Clasificacion;

                ExentaSi.Enabled = false;
                ExentaNo.Checked = true;
                RetencionNo.Checked = true;

                if (cliente.Clasificacion == "grande")
                {
                    RetencionSi.Checked = true;
                    RetencionNo.Enabled = false;
                }
                else if (cliente.Clasificacion == "ninguno")
                {
                    ExentaSi.Enabled = true;
                    RetencionSi.Enabled = true;
                }
                else
                {
                    RetencionNo.Enabled = true;
                    RetencionSi.Enabled = false;
                }
                form.Close();
            }
        }

        private void ExentaSi_CheckedChanged(object sender, EventArgs e)
        {
            cmbDetailType.SelectedIndex = ExentaSi.Checked ? 1 : 0;
        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            tiposeleccionado = cmbTipoDocumento.SelectedIndex == 0 ? "fcf" : (cmbTipoDocumento.SelectedIndex == 1 ? "ccf" : "fex");
           

            if (tiposeleccionado == "fcf")
            {
                cmbNumSerie.Text = series.dameSerie(tiposeleccionado);
                txtCorrelativo.Text = series.dameCorrelativo(tiposeleccionado);
                if (int.Parse(txtCorrelativo.Text) < 1000)
                {
                    txtCorrelativo.Text = series.dameCorrelativo(tiposeleccionado);
                }
                else
                {
                    MessageBox.Show("El limite de serir ha sido alcanzado, ingrese uno nuevo.");
                    txtCorrelativo.Text = "0";
                }
            }
            else if (tiposeleccionado == "ccf")
            {
                cmbNumSerie.Text = series.dameSerie(tiposeleccionado);
                txtCorrelativo.Text = series.dameCorrelativo(tiposeleccionado);
                if (int.Parse(txtCorrelativo.Text) < 1000)
                {
                    txtCorrelativo.Text = series.dameCorrelativo(tiposeleccionado);
                }
                else
                {
                    MessageBox.Show("El limite de serir ha sido alcanzado, ingrese uno nuevo.");
                    txtCorrelativo.Text = "0";
                }
            }
            else if (tiposeleccionado == "fex")
            { 
                cmbNumSerie.Text =  series.dameSerie(tiposeleccionado);
                txtCorrelativo.Text = series.dameCorrelativo(tiposeleccionado);
                if (int.Parse(txtCorrelativo.Text) < 1000)
                {
                    txtCorrelativo.Text = series.dameCorrelativo(tiposeleccionado);

                }
                else
                {
                    MessageBox.Show("El limite de serir ha sido alcanzado, ingrese uno nuevo.");
                    txtCorrelativo.Text = "0";
                }
            }


        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            FormSerie form = new FormSerie();

            if (form.ShowDialog() == DialogResult.OK)
            {
                cmbNumSerie.SelectedItem = form.serie._Serie;
                txtCorrelativo.Text = (form.serie.Inicia_desde + 1).ToString();
                form.Close();
            }
        }

        private void btn_BuscarProducto_Click(object sender, EventArgs e)
        {
            FormBuscarProductocs form = new FormBuscarProductocs(true);

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.producto = form.producto;
                txtCodigo.Text = form.producto.Codigo;
                txtPrecio.Text = form.producto.Precio.ToString();
                txtDescripcion.Text = form.producto.Nombre;
                txtCant.Value = 1;
                txtCant.Focus();
                form.Close();
                
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> row = (from r in gridDetalles.Rows.Cast<DataGridViewRow>() where Convert.ToInt32(r.Cells[0].Value) == producto.Id select r).ToList();
            if (row.Count() > 0)
            {
                int fila = row[0].Index;
                int agregados = (int)txtCant.Value;
                decimal currentPrice = Convert.ToDecimal(gridDetalles.Rows[fila].Cells[7].Value);

                int cantidad = Convert.ToInt32(gridDetalles.Rows[fila].Cells[1].Value) + (int)txtCant.Value;

                if (cantidad > Convert.ToInt32(gridDetalles.Rows[fila].Cells[6].Value))
                {
                    cantidad = Convert.ToInt32(gridDetalles.Rows[fila].Cells[6].Value);
                    agregados = Convert.ToInt32(gridDetalles.Rows[fila].Cells[6].Value) - Convert.ToInt32(gridDetalles.Rows[fila].Cells[1].Value);
                }

                gridDetalles.Rows[fila].Cells[1].Value = cantidad;

                if (cmbDetailType.SelectedIndex == 0)
                {
                    SubtotalAfectas += agregados * currentPrice;
                    gridDetalles.Rows[fila].Cells[4].Value = "";
                    decimal b = cantidad * producto.Precio;

                    if (cmbTipoDocumento.SelectedIndex == 0)
                    {
                        b = b * (1 + IVA);
                    }
                    gridDetalles.Rows[fila].Cells[5].Value = String.Format("{0:c}", b);
                }
                else
                {
                    SubtotalExentas += agregados * currentPrice;
                    gridDetalles.Rows[fila].Cells[4].Value = String.Format("{0:c}", cantidad * producto.Precio);
                    gridDetalles.Rows[fila].Cells[5].Value = "";
                }
            }
            else
            {
                int fila = gridDetalles.Rows.Add();
                int cantidad = (int)txtCant.Value;
                if (cantidad > producto.Existencias)
                {
                    cantidad = producto.Existencias;
                }

                gridDetalles.Rows[fila].Cells[0].Value = producto.Id;
                gridDetalles.Rows[fila].Cells[1].Value = cantidad;
                gridDetalles.Rows[fila].Cells[2].Value = producto.Nombre;
                gridDetalles.Rows[fila].Cells[3].Value = producto.Precio;
                gridDetalles.Rows[fila].Cells[6].Value = producto.Existencias;

                gridDetalles.Rows[fila].Cells[7].Value = producto.Precio;

                decimal b = cantidad * producto.Precio;

                if (cmbDetailType.SelectedIndex == 0)
                {
                    SubtotalAfectas += b;
                    gridDetalles.Rows[fila].Cells[4].Value = "";
                    if (cmbTipoDocumento.SelectedIndex ==0)
                    {
                        b = b * (1 + IVA);
                        gridDetalles.Rows[fila].Cells[3].Value = Decimal.Round(producto.Precio * (1 + IVA), 2);
                    }
                    gridDetalles.Rows[fila].Cells[5].Value = String.Format("{0:c}",b);
                }
                else
                {
                    SubtotalExentas += b;
                    gridDetalles.Rows[fila].Cells[4].Value = String.Format("{0:c}",b);
                    gridDetalles.Rows[fila].Cells[5].Value = "";
                }


            }
           // limpiar_Controles();
            totalizar();

        }

        public void limpiar_Controles()
        {
            txtCant.Value = 0;
            txtCliente.Text = "";
            txtClienteClasificacion.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtDireccion.Text = "";
            txtRegistro.Text = "";
            txtPrecio.Text = "";
            txtLetrasPrecio.Text = "0.00";
            txtCant.Value = 0;
            txtNit.Text = "";
            txtFecha.Value = DateTime.Now;
            txtCorrelativo.Text = "";
            gridDetalles.Rows.Clear();




        }

        public void totalizar()
        {
            if (SubtotalExentas + SubtotalAfectas > 0.00m)
            {
                if (cliente == null)
                {
                    MessageBox.Show("Selecciona un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool aplicarRetencion = Config.clasificacion != "Gran Contribuyente" && (cliente.Clasificacion == "gran" || RetencionSi.Checked) && SubtotalAfectas > 100.00m;
                    bool aplicarPercepcion = cmbTipoDocumento.SelectedIndex == 1 && Config.clasificacion == "Gran Contribuyente" && (cliente.Clasificacion != "gran" || RetencionNo.Checked) && SubtotalAfectas > 100.00m;

                    if (cmbTipoDocumento.SelectedIndex == 2)
                    {
                        aplicarRetencion = false;
                        aplicarPercepcion = false;
                    }

                    decimal bigtotal = 0.00m;

                    lblSumaExentas.Text = String.Format("{0:c}", SubtotalExentas);
                    lblVentasExentas.Text = String.Format("{0:c}", SubtotalExentas);

                    switch (cmbTipoDocumento.SelectedIndex)
                    {
                        case 0:
                            bigtotal += decimal.Round(SubtotalAfectas * (1 + IVA), 2);
                            lblSumaAfectas.Text = String.Format("{0:c}", decimal.Round(SubtotalAfectas * (1 + IVA), 2));
                            if (aplicarRetencion)
                            {
                                lblRetencion.Text = String.Format("{0:c}", decimal.Round(SubtotalAfectas * (Retencion), 2));
                                lblPercepcion.Text = "$ 0.00";
                                bigtotal -= decimal.Round(SubtotalAfectas * (Retencion), 2);
                            }
                            else if (aplicarPercepcion)
                            {
                                lblPercepcion.Text = String.Format("{0:c}", decimal.Round(SubtotalAfectas * (Percepcion), 2));
                                lblRetencion.Text = "$ 0.00";
                                bigtotal += decimal.Round(SubtotalAfectas * (Percepcion), 2);
                            }
                            else
                            {
                                lblPercepcion.Text = "$ 0.00";
                                lblRetencion.Text = "$ 0.00";
                            }

                            break;

                        case 1:
                            bigtotal += decimal.Round(SubtotalAfectas * (1 + IVA), 2);
                            lblSumaAfectas.Text = String.Format("{0:c}", decimal.Round(SubtotalAfectas), 2);
                            lblSumaSubtotal.Text = String.Format("{0:c}", decimal.Round(SubtotalAfectas * (1 + IVA), 2));
                            lblSumaIVA.Text = String.Format("{0:c}", decimal.Round(SubtotalAfectas * (1 + IVA), 2));
                            if (aplicarRetencion)
                            {
                                lblRetencion.Text = String.Format("{0:c}", decimal.Round(SubtotalAfectas * (Retencion), 2));
                                lblPercepcion.Text = "$ 0.00";
                                bigtotal -= decimal.Round(SubtotalAfectas * (Retencion), 2);
                            }
                            else if (aplicarPercepcion)
                            {
                                lblPercepcion.Text = String.Format("{0:c}", decimal.Round(SubtotalAfectas * (Percepcion), 2));
                                lblRetencion.Text = "$ 0.00";
                                bigtotal += decimal.Round(SubtotalAfectas * (Percepcion), 2);
                            }
                            else
                            {
                                lblPercepcion.Text = "$ 0.00";
                                lblRetencion.Text = "$ 0.00";
                            }

                            break;


                        case 2:
                            
                            bigtotal += SubtotalExentas;
                            lblPercepcion.Text = "$ 0.00";
                            lblRetencion.Text = "$ 0.00";
                            lblSumaAfectas.Text = "$ 0.00";
                            lblSumaSubtotal.Text = "$ 0.00";
                            lblSumaIVA.Text = "$ 0.00";

                            break;




                        default:
                            break;
                    }


                    lblTotal1.Text = String.Format("{0:c}", bigtotal);
                    lblTotal.Text = String.Format("{0:c}", bigtotal);
                    txtLetrasPrecio.Text = Helpers.dinero_A_string(bigtotal);
                }

            }
            else
            {
                lblPercepcion.Text = "$ 0.00";
                lblRetencion.Text = "$ 0.00";
                lblSumaAfectas.Text = "$ 0.00";
                lblSumaSubtotal.Text = "$ 0.00";
                lblSumaIVA.Text = "$ 0.00";
                lblSumaExentas.Text = "$ 0.00";
                lblVentasExentas.Text = "$ 0.00";
                lblTotal1.Text = "$ 0.00";

            }
        }

        private void RetencionSi_CheckedChanged(object sender, EventArgs e)
        {
            if (T == 0)
            {
                totalizar();
            }

        }

        private void RetencionNo_CheckedChanged(object sender, EventArgs e)
        {
            if (T == 0)
            {
                totalizar();
            }

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (gridDetalles.CurrentRow != null)
            {
                int cantidad = Convert.ToInt32(gridDetalles.CurrentRow.Cells[1].Value);
                decimal precio = Convert.ToDecimal(gridDetalles.CurrentRow.Cells[7].Value) * cantidad;
                if (cmbDetailType.SelectedIndex == 0)
                {
                    SubtotalAfectas -= precio;
                }
                else
                {
                    SubtotalExentas -= precio;
                }

                gridDetalles.Rows.Remove(gridDetalles.CurrentRow);
                totalizar();
            
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (gridDetalles.CurrentRow != null)
            {
                decimal currentPrice = Convert.ToDecimal(gridDetalles.CurrentRow.Cells[7].Value);
                int cantidad = Convert.ToInt32(gridDetalles.CurrentRow.Cells[1].Value) + 1;
                if (Convert.ToInt32(gridDetalles.CurrentRow.Cells[6].Value) >= cantidad )
                {
                    gridDetalles.CurrentRow.Cells[1].Value = cantidad;
                    if (cmbDetailType.SelectedIndex == 0)
                    {
                        SubtotalAfectas += currentPrice;
                        gridDetalles.CurrentRow.Cells[4].Value = "";
                        decimal b = cantidad * currentPrice;
                        
                        if (cmbTipoDocumento.SelectedIndex == 0)
                        {
                            b = b * (1 + IVA);
                        }

                        gridDetalles.CurrentRow.Cells[5].Value = String.Format("{0:c}", b);

                    }
                    else
                    {
                        SubtotalExentas += currentPrice;
                        gridDetalles.CurrentRow.Cells[4].Value = String.Format("{0:c}", cantidad*currentPrice);
                        gridDetalles.CurrentRow.Cells[5].Value = "";
                    }
                    totalizar();
                }
            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            if (gridDetalles.CurrentRow != null)
            {
                decimal currentPrice = Convert.ToDecimal(gridDetalles.CurrentRow.Cells[7].Value);
                int cantidad = Convert.ToInt32(gridDetalles.CurrentRow.Cells[1].Value) - 1;
                gridDetalles.CurrentRow.Cells[1].Value = cantidad;
                if (cmbDetailType.SelectedIndex == 0)
                {
                    SubtotalAfectas -= currentPrice;
                    gridDetalles.CurrentRow.Cells[4].Value = "";
                    decimal b = cantidad * currentPrice;

                    if (cmbTipoDocumento.SelectedIndex == 0)
                    {
                        b = b * (1 + IVA);


                    }
                    gridDetalles.CurrentRow.Cells[5].Value = String.Format("{0:c}", b);
                }
                else
                {
                    SubtotalExentas -= currentPrice;
                    gridDetalles.CurrentRow.Cells[4].Value = String.Format("{0:c}", cantidad * currentPrice);
                    gridDetalles.CurrentRow.Cells[5].Value = "";
                }
                    totalizar();
                }
            }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.cliente == null)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(gridDetalles.Rows.Count < 1)
            {
                MessageBox.Show("Agregue detalles al documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbTipoDocumento.SelectedIndex == 1 && !new Regex("^[0-9]{4}-[0-9]{6}-[0-9]{3}-[0-9]{1}$").IsMatch(txtNit.Text))
            {
                MessageBox.Show("El número de NIT es obligatorio, y debe tener el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbTipoDocumento.SelectedIndex == 1 && !new Regex("^[0-9]{2,6}-[0-9]{1}$").IsMatch(txtRegistro.Text))
            {
                MessageBox.Show("El número de Registro es obligatorio, y debe tener el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(cmbNumSerie.Text))
            {
                MessageBox.Show("Seleccione un número de serie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Info de capa negocio
                List<DetalleDocumento> detalles = new List<DetalleDocumento>();

                foreach (DataGridViewRow row in gridDetalles.Rows) 
                {
                    detalles.Add(new DetalleDocumento(
                        Int32.Parse(row.Cells[0].Value.ToString()),
                        Int32.Parse(row.Cells[1].Value.ToString()),
                        Decimal.Parse(row.Cells[3].Value.ToString())
                        ));
                }

                Documento doc = new Documento();
                doc.Numero = int.Parse(txtCorrelativo.Text);
                doc.Cliente = cliente._Id;
                doc.Serie = TodoSeries.Where(a => a._Serie == cmbNumSerie.Text).ToList()[0].Id;
                doc.Fecha = txtFecha.Value;
                doc.Condiciones = (int)numCondiciones.Value;
                doc.Tipo_documento = cmbTipoDocumento.SelectedIndex == 0 ? "fcf" : (cmbTipoDocumento.SelectedIndex == 1 ? "ccf" : "fex");
                doc.Caso = ExentaSi.Checked ? "exentas" : "afectas";

                Dictionary<String, String> datos = new Dictionary<String, String>()
                {
                    {"registro", txtRegistro.Text },
                    {"nit",txtNit.Text },
                    {"Direccion", txtDireccion.Text }
                };

                int id = NegocioDocumento.GuardarDocumento(doc, detalles, datos, RetencionSi.Checked, this.cliente);
                if (id > 0) 
                {
                    //    mostrar mensaje
                    MessageBox.Show("Documento guardado exitosamente.");

                    FacturaVentas facturaVenta = new FacturaVentas(id);
                    facturaVenta.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show(Mensaje.ErrorMessage, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }    
        }

     

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

