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

namespace CapaPresentacion.Tablas
{
    public partial class AdministrarCatalogo : Form
    {
        CN_Conta negocio = new CN_Conta();
        CuentaCatalogo cuenta_elegida = new CuentaCatalogo();




        public AdministrarCatalogo()
        {
            InitializeComponent();
        }


        private void CheckSi_CheckedChanged(object sender, EventArgs e)
        {
            txtSaldo.Text = txtSaldo.Text == "ACREEDOR" ? "DEUDOR" : "ACREEDOR";
        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {
            txtCodigo.Text = txtbase.Text + txtnumero.Text;
        }

      

        private void AdministrarCatalogo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negocio.Cuentas();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtnumero.Text))
            {
                MessageBox.Show("Coloque una número para la cuenta que desea agregar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Proporcione un nombre para la cuenta que desea agregar", "Eliminar/Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CuentaCatalogo ct = new CuentaCatalogo();
                ct.Nombre = txtNombre.Text;
                ct.Nivel = cuenta_elegida.Nivel + 1;
                ct.Cuenta_padre = cuenta_elegida.Id1;
                ct.Agrupacion = cuenta_elegida.Agrupacion;
                ct.Tipo_saldo = cuenta_elegida.Nivel == 2 ? txtSaldo.Text : cuenta_elegida.Tipo_saldo;
                ct.Rubro = cuenta_elegida.Rubro;
                ct.Codigo = txtbase.Text + txtnumero.Text;

                int id = negocio.GuardarCuenta(ct);
                if (id > 0)
                {
                    MessageBox.Show("Ingresado correctamente.", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = negocio.Cuentas();
                }
                else
                {
                    MessageBox.Show(Mensaje.ErrorMessage, "Agregar/Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cuenta_elegida.Nivel > 2)
            {
                if (negocio.Eliminar(cuenta_elegida.Id1))
                {
                    MessageBox.Show("Eliminado correctamente.", "Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = negocio.Cuentas();
                }
                else
                {
                    MessageBox.Show("No se puede eliminar esta cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
                lblError.Visible = false;
                CheckNo.Checked = true;

                if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() == "1")
                {
                    lblError.Visible = true;
                    lblError.Text = "     Elija otra cuenta";
                }
                else
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    cuenta_elegida.Codigo = row.Cells[3].Value.ToString();
                    cuenta_elegida.Nombre = row.Cells[4].Value.ToString();
                    cuenta_elegida.Nivel = Int32.Parse(row.Cells[5].Value.ToString());
                    cuenta_elegida.Tipo_saldo = row.Cells[8].Value.ToString();
                    cuenta_elegida.Rubro = row.Cells[1].Value.ToString();
                    cuenta_elegida.Agrupacion = row.Cells[2].Value.ToString();

                    txtSaldo.Text = row.Cells[8].Value.ToString();
                    txtbase.Text = cuenta_elegida.Codigo;

                    switch (row.Cells[5].Value.ToString())
                    {
                        case "2":
                            txtpadre.Text = cuenta_elegida.Codigo;
                            cmbNivel.Text = "3";
                            btnGuardar.Enabled = true;
                            btnEliminar.Enabled = false;
                            break;


                        case "3":
                            cuenta_elegida.Agrupacion = row.Cells[2].Value.ToString();
                            cuenta_elegida.Id1 = Int32.Parse(row.Cells[0].Value.ToString());
                            txtpadre.Text = cuenta_elegida.Codigo;
                            cmbNivel.Text = "4";
                            btnGuardar.Enabled = true;
                            btnEliminar.Enabled = true;
                            break;

                        case "4":
                            cuenta_elegida.Agrupacion = row.Cells[2].Value.ToString();
                            cuenta_elegida.Id1 = Int32.Parse(row.Cells[0].Value.ToString());
                            txtpadre.Text = cuenta_elegida.Codigo;
                            cmbNivel.Text = "5";
                            btnGuardar.Enabled = true;
                            btnEliminar.Enabled = true;
                            break;

                        case "5":
                            lblError.Text = "    Solo Eliminación";
                            lblError.Visible = true;
                            cuenta_elegida.Id1 = Int32.Parse(row.Cells[0].Value.ToString());
                            btnEliminar.Enabled = true;
                            break;

                    }

                }


            }
        }
    }
}
