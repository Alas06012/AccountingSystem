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
using CapaPresentacion;

namespace CapaPresentacion.Tablas
{
    public partial class VerProducto : Form
    {
        int producto;
        string Nombre, Existencias, Descripcion, Precio, Codigo, Costo;

        private void btnKardex_Click_1(object sender, EventArgs e)
        {
            var form = new FormularioKardex(this.producto);
            form.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void VerProducto_Load(object sender, EventArgs e)
        {
            lblNombre.Text = Nombre;
            txtExistencias.Text = Existencias;
            txtDecripcion.Text = Descripcion;
            txtPrecio.Text = Precio;
            txtCodigo.Text = Codigo;
            txtCosto.Text = Costo;
        }

        public VerProducto(int id, string nombre, string existencias, string descripcion, string precio, string codigo, string costo)
        {
            this.producto = id;
            this.Nombre = nombre;
            this.Existencias = existencias;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Codigo = codigo;
            this.Costo = costo;

            InitializeComponent();

        }

        private void btnKardex_Click(object sender, EventArgs e)
        {
           
        }
    }
}
