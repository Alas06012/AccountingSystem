using CapaEntidades;
using CapaNegocio;
using CapaPresentacion.Contables;
using CapaPresentacion.Tablas;
using CapaPresentacion.Ventas;
using Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.FormsInicio
{
    public partial class VistaReportes : Form
    {
        //Estados Financieros
        List<CuentaCatalogo> cuentas;
        List<ISRrangos> rangos;
        List<CuentaCatalogo> lista_gastos;

        CN_Conta Negocio = new CN_Conta();
        EstadoResultados resultados;
        decimal ISR = 0.00m;





        public VistaReportes()
        {
            InitializeComponent();
        }

        public void AbrirFormulario<Formulario>(string caso) where Formulario : Form, new()
        {
            Form formulario;
            if (caso == "abierto")
            {
                formulario = panelContenedor.Controls.OfType<Formulario>().FirstOrDefault();
            }
            else
            {
                formulario = Application.OpenForms.OfType<Formulario>().FirstOrDefault();
            }
            if (formulario == null)
            {
                formulario = new Formulario();
                if (caso == "abierto")
                {
                    formulario.Dock = DockStyle.Fill;
                    formulario.FormBorderStyle = FormBorderStyle.None;
                    formulario.TopLevel = false;
                    panelContenedor.Controls.Add(formulario);
                    panelContenedor.Tag = formulario;
                }
                formulario.Show();
            }
            else
            {
                formulario.BringToFront();
            }
        }


    
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<LibroDiario>("abierto");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MayorizacionImprime>("abierto");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<BalanzaComprobacion>("abierto");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormulario<PartidaManual>("abierto");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<EstadosFinancieros>("abierto");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirFormulario<VerCatalogo>("abierto");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AdministrarCatalogo>("abierto");
        }
        private void button14_Click(object sender, EventArgs e)
        {
            //Estado Resultados
            var form = new ImprimirEstadoResultado(resultados, lista_gastos);
            form.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Balance General

            //Seleccionar las cuentas
            var cuentas_ac = cuentas.Where(x => x.Agrupacion == "Activo corriente" && x.Nivel == 3).ToList();
            var cuentas_anc = cuentas.Where(x => x.Agrupacion == "Activo no corriente" && x.Nivel == 3).ToList();
            var cuentas_Pc = cuentas.Where(x => x.Agrupacion == "Pasivo Corriente" && x.Nivel == 3 && x.Id1 != 28).ToList();

            //Agregar la utilidad calculada al balance
            //resultados.ISR1 viene de haber calculado la utilidad en este mismo form
            var impuesto_por_pagar = cuentas.Where(x => x.Id1 == 28).First();
            impuesto_por_pagar.Haber += resultados.ISR1;
            cuentas_Pc.Add(impuesto_por_pagar);

            var cuentas_Pnc = cuentas.Where(x => x.Agrupacion == "Pasivo no Corriente" && x.Nivel == 3).ToList();
            //Obtengo todas las cuentas a exepción de a cuenta de id 34: Utilidad/Perdida
            var cuentas_Capital = cuentas.Where(x => x.Rubro == "CAPITAL" && x.Nivel == 3 && x.Id1 != 34).ToList();

            //Agregar la utilidad calculada al balance
            //resultados.Utlilidad viene de haber calculado la utilidad en este mismo form
            var utilidad = cuentas.Where(x => x.Id1 == 34).First();
            utilidad.Haber += resultados.Utilidad_Neta;
            cuentas_Capital.Add(utilidad);

            //subtotales por agrupación
            decimal ac_subtotal = cuentas_ac.Sum(x => x.Debe - x.Haber);
            decimal anc_subtotal = cuentas_anc.Sum(x => x.Debe - x.Haber);
            decimal pc_subtotal = cuentas_Pc.Sum(x => x.Haber - x.Debe);
            decimal pnc_subtotal = cuentas_Pnc.Sum(x => x.Haber - x.Debe);
            decimal capital_subtotal = cuentas_Capital.Sum(x => x.Haber - x.Debe);

            //la clase de reporte "Balance filas" tiene 4 columnas
            // 1 ----- grupo o nombre de cuenta
            // 2 ----- saldo de cuenta
            // 3 ----- subtotales (para cuentas de agrupacion como pasivo corriente
            // 4 ----- rubro y totales
            List<BalanceFila> filas = new List<BalanceFila>();

            //ACTIVO
            filas.Add(new BalanceFila("ACTIVO"));
            //Activo Corriente
            filas.Add(new BalanceFila("Activo Corriente", String.Format("{0:c}", ac_subtotal)));

            //Cuentas de activo corriente
            foreach (CuentaCatalogo x in cuentas_ac)
            {
                filas.Add(new BalanceFila(x.Nombre, String.Format("{0:c}", x.Debe - x.Haber), "Cuenta"));
            }

            //Activo no Corriente
            filas.Add(new BalanceFila("Activo no Corriente", String.Format("{0:c}", anc_subtotal)));

            foreach (CuentaCatalogo x in cuentas_anc)
            {
                filas.Add(new BalanceFila(x.Nombre, String.Format("{0:c}", x.Debe - x.Haber), "Cuenta"));
            }

            //Total Activos
            var adding = new BalanceFila("TOTAL ACTIVO");
            adding.Total = String.Format("{0:c}", ac_subtotal + anc_subtotal);
            filas.Add(adding);



            //PAsivo
            filas.Add(new BalanceFila("PASIVO"));

            //Pasivo Corriente
            filas.Add(new BalanceFila("Pasivo Corriente", String.Format("{0:c}", pc_subtotal)));
            foreach (CuentaCatalogo x in cuentas_Pc)
            {
                filas.Add(new BalanceFila(x.Nombre, String.Format("{0:c}", x.Haber - x.Debe), "Cuenta"));
            }

            //Pasivo no Corriente
            filas.Add(new BalanceFila("Pasivo no Corriente", String.Format("{0:c}", pnc_subtotal)));
            foreach (CuentaCatalogo x in cuentas_Pnc)
            {
                filas.Add(new BalanceFila(x.Nombre, String.Format("{0:c}", x.Haber - x.Debe), "Cuenta"));
            }

            //Capital
            filas.Add(new BalanceFila("PATRIMONIO"));

            //Capital Personal
            filas.Add(new BalanceFila("Capital Personal", String.Format("{0:c}", capital_subtotal)));
            foreach (CuentaCatalogo x in cuentas_Capital)
            {
                filas.Add(new BalanceFila(x.Nombre, String.Format("{0:c}", x.Haber - x.Debe), "Cuenta"));
            }

            //Pasivo + Capital
            adding = new BalanceFila("TOTAL PASIVO Y PATRIMONIO");
            adding.Total = String.Format("{0:c}", capital_subtotal + pnc_subtotal + pc_subtotal);
            filas.Add(adding);

            //abrir imprimible
            var frm = new BalanceGeneral_Imprimible(filas);
            frm.ShowDialog();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (panelCuentas.Visible == true)
            {
                panelCuentas.Visible = false;
            }
            else
            {
                panelCuentas.Visible = true;
            }
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            if (panelEstadosFinan.Visible == true)
            {
                panelEstadosFinan.Visible = false;
            }
            else
            {
                panelEstadosFinan.Visible = true;
            }
        }


        #region EstadosFinancieros
        //Estados Financieros
        private void VistaReportes_Load(object sender, EventArgs e)
        {
            cargar();
            var ingreso_por_venta = cuentas.Where(x => x.Codigo == "5101").First();
            var costo_venta = cuentas.Where(x => x.Codigo == "4101").First();

            lista_gastos = cuentas.Where(x => x.Agrupacion == "Gastos Operativos" && x.Nivel == 3).ToList();
            var gastos_operativos = lista_gastos.Sum(x => x.Debe - x.Haber);
            var otros_ingresos = cuentas.Where(x => x.Codigo == "5102").First();

            resultados = new EstadoResultados(
                 ingreso_por_venta.Haber - ingreso_por_venta.Debe,
                 costo_venta.Debe - costo_venta.Haber,
                 gastos_operativos,
                 otros_ingresos.Haber - otros_ingresos.Debe
               );
            ISR = calcular_utilidad(resultados.Utilidad_antes_ISR);
            resultados.ISR1 = ISR;
            lblUtilidadNeta.Text = string.Format("{0:c}", resultados.Utilidad_Neta.ToString());
        }

        private decimal calcular_utilidad(decimal antes_deISR)
        {
            ISRrangos rango = rangos.Where(x => x.De <= antes_deISR && (x.Hasta >= antes_deISR || x.Hasta < 0.01m)).First();
            decimal porcentaje = Decimal.Parse(rango.Porcentaje.ToString()) / 100;

            return (((antes_deISR - rango.Exceso) * (porcentaje)) + rango.Cuota_fija);
        }



        private void cargar()
        {
            rangos = Negocio.rangos();
            cuentas = Negocio.Cuentas();


        }



        #endregion

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormSerie>("abierto");
        }
    }
}
