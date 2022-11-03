using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;
using CapaNegocio;
using CapaEntidades;
using CapaEntidades.Utilities;
using Reportes;

namespace CapaPresentacion.Tablas
{
    public partial class PartidaManual : Form
    {
        List<CuentaCatalogo> cuentas;
        CN_Conta negocio = new CN_Conta();
        decimal totaldebe = 0.00m;
        decimal totalhaber = 0.00m;


        public PartidaManual()
        {
            InitializeComponent();
            this.cuentas = negocio.Cuentas();
        }

        private void PartidaManual_Load(object sender, EventArgs e)
        {
            cargarCuentas("");
        }

        private void cargarCuentas(string busqueda)
        {
            if (busqueda != "")
            {
                //filtrar cuentas
                gridCuentas.DataSource = cuentas.Where(x => x.Codigo.Contains(busqueda) || x.Nombre.Contains(busqueda)).ToList();
            }
            else
            {
                gridCuentas.DataSource = cuentas;
            }
            
        }

        private void txtBuscarCuenta_TextChanged(object sender, EventArgs e)
        {
            cargarCuentas(txtBuscarCuenta.Text);
        }

        private void gridCuentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = gridCuentas.Rows[e.RowIndex];
                lblError.Visible = false;

                if (row.Cells[9].Value.ToString() == "3")
                {
                    var agregadas = gridPartida.Rows.Cast<DataGridViewRow>().Where(x => x.Cells[0].Value.ToString() == row.Cells[0].Value.ToString()).ToList();

                    if (agregadas.Count < 2)
                    {
                        int index = gridPartida.Rows.Add();
                        gridPartida.Rows[index].Cells[0].Value = row.Cells[0].Value.ToString();

                        gridPartida.Rows[index].Cells[1].Value = row.Cells[3].Value.ToString();
                        gridPartida.Rows[index].Cells[2].Value = row.Cells[4].Value.ToString();
                        gridPartida.Rows[index].Cells[3].Value = "";
                        gridPartida.Rows[index].Cells[4].Value = "";
                    }
                    else
                    {
                        lblError.Visible = true;
                    }
                }


            }
        }

        private void gridPartida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 5)
                {
                    gridPartida.Rows.Remove(gridPartida.Rows[e.RowIndex]);
                    BeginInvoke(new MethodInvoker(Cuadrar));


                    //Cuadrar();
                }
            }
        }

        private void Cuadrar()
        {
            try
            {
                var undefind = gridPartida.Rows.Cast<DataGridViewRow>().Where(x => x.Cells[0].Value.ToString() == "" && x.Cells[4].Value.ToString() == "").ToList().OrderBy(x => x.Cells[1].Value.ToString()).ToList();
                var debe = gridPartida.Rows.Cast<DataGridViewRow>().Where(x => x.Cells[3].Value.ToString() != "" && x.Cells[4].Value.ToString() == "").ToList().OrderBy(x => x.Cells[1].Value.ToString()).ToList();
                var haber = gridPartida.Rows.Cast<DataGridViewRow>().Where(x => x.Cells[4].Value.ToString() != "" && x.Cells[3].Value.ToString() == "").ToList().OrderBy(x => x.Cells[1].Value.ToString()).ToList();
                totaldebe = 0.00m;
                totalhaber = 0.00m;
                gridPartida.Rows.Clear();

                foreach (var row in debe)
                {
                    gridPartida.Rows.Add(row);
                    totaldebe += Decimal.Parse(row.Cells[3].Value.ToString());
                }

                foreach (var row in haber)
                {
                    gridPartida.Rows.Add(row);
                    totalhaber += Decimal.Parse(row.Cells[4].Value.ToString());
                }

                foreach (var row in undefind)
                {
                    gridPartida.Rows.Add(row);
                }

                lblDebe.Text = String.Format("{0:c}", totaldebe);
                lblHaber.Text = String.Format("{0:c}", totalhaber);

                if (totaldebe == totalhaber)
                {
                    btnGuardar.Enabled = true;

                }
                else
                {
                    btnGuardar.Enabled = false;
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Error de formato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gridPartida.Rows.Clear();

            }
           

        }

        

      

        private void LimpiarControles()
        {
            gridPartida.Rows.Clear();
            btnGuardar.Enabled = false;
            lblError.Visible = false;
            txtDescripccion.Text = "";
            totaldebe = 0.00m;
            totalhaber = 0.00m;

        }

        private void gridPartida_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = gridPartida.Rows[e.RowIndex];


            if (e.ColumnIndex == 4)
            {
                row.Cells[3].Value = "";
                var existe = gridPartida.Rows.Cast<DataGridViewRow>().Where(x => x.Cells[0].Value.ToString()
                == row.Cells[0].Value.ToString() && x.Cells[4].Value.ToString() != "").ToList();
                if (existe.Count > 1)
                {
                    gridPartida.Rows.Remove(row);
                }


            }
            else if (e.ColumnIndex == 3)
            {
                row.Cells[4].Value = "";
                var existe = gridPartida.Rows.Cast<DataGridViewRow>().Where(x => x.Cells[0].Value.ToString()
                == row.Cells[0].Value.ToString() && x.Cells[3].Value.ToString() != "").ToList();
                if (existe.Count > 1)
                {
                    gridPartida.Rows.Remove(row);
                }

            }

            BeginInvoke(new MethodInvoker(Cuadrar));
            //Cuadrar()
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtFecha.Value == null)
            {
                MessageBox.Show("Campo fecha esta vacío.");
            }
            else if (String.IsNullOrEmpty(txtDescripccion.Text))
            {
                MessageBox.Show("Campo descripción esta vacío.");
            }
            else
            {
                List<DetallePartida> detalles = new List<DetallePartida>();
                foreach (DataGridViewRow row in gridPartida.Rows)
                {
                    detalles.Add(new DetallePartida(
                        Int32.Parse(row.Cells[0].Value.ToString()),
                        row.Cells[3].Value.ToString() != "" ? Decimal.Parse(row.Cells[3].Value.ToString()) : 0.00m,
                        row.Cells[4].Value.ToString() != "" ? Decimal.Parse(row.Cells[4].Value.ToString()) : 0.00m

                        ));
                }


                var partida = new Partida();
                partida.Fecha = txtFecha.Value;
                partida.Description = txtDescripccion.Text;
                partida.Debe = totaldebe;
                partida.Haber = totalhaber;

                int id = negocio.GuardarPartida(partida, detalles);

                if (id > 0)
                {
                    if (checkImprimir.Checked)
                    {

                        MessageBox.Show("Guardado Correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        PartidaIndividualImprimible report = new PartidaIndividualImprimible();
                       

                        for (int i = 0; i < gridPartida.Rows.Count; i++)
                        {
                            ReportePartidaIndividual datos = new Reportes.ReportePartidaIndividual();
                            datos.fecha = txtFecha.Value;
                            datos.descripcion = txtDescripccion.Text;
                            datos.codigo = this.gridPartida.Rows[i].Cells[1].Value.ToString();
                            datos.nombre = this.gridPartida.Rows[i].Cells[2].Value.ToString();
                            datos.debe = gridPartida.Rows[i].Cells[3].Value.ToString() == "" ? 0.00m : Decimal.Parse(gridPartida.Rows[i].Cells[3].Value.ToString());
                            datos.haber = gridPartida.Rows[i].Cells[4].Value.ToString() == "" ? 0.00m : Decimal.Parse(gridPartida.Rows[i].Cells[4].Value.ToString());
                            
                            report.Datos.Add(datos);
                        }
                        report.ShowDialog();   
                        
                        
                        
                        
                        
                        
                       
                    }
                    else
                    {
                        MessageBox.Show("Guardado.");
                    }
                    LimpiarControles();
                }
                else
                {
                    MessageBox.Show(Mensaje.ErrorMessage);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
