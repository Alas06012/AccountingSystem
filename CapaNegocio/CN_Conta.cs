using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;
using Reportes;

namespace CapaNegocio
{
    public class CN_Conta
    {
        CD_Conta Datos = new CD_Conta();


        public int GuardarCuenta(CuentaCatalogo cuenta)
        {

            return Datos.RegistrarCuenta(cuenta);
        }

        //Eliminar cuenta
        public bool Eliminar(int id)
        {
            return Datos.elimiar_cuenta(id);
        }


        //Devuelve el listado de cuentas 
        public List<CuentaCatalogo> Cuentas()
        {
            List<CuentaCatalogo> cts = Datos.Catalogo();

//COMIENZAN ACTIVO------------------------------------------------------------------
            var cuenta = new CuentaCatalogo();
            cuenta.Codigo = "1";
            cuenta.Nombre = "----------------------------------------------ACTIVO----------------------------------------------";
            cuenta.Nivel = 1;
            cuenta.Tipo_saldo = "DEUDOR";
            cts.Add(cuenta);

            //Activo no corriente
            cuenta = new CuentaCatalogo();
            cuenta.Codigo = "11";
            cuenta.Nombre = "Activo Corriente";
            cuenta.Agrupacion = "Activo corriente";
            cuenta.Tipo_saldo = "DEUDOR";
            cuenta.Nivel = 2;
            cuenta.Rubro = "ACTIVO";
            cts.Add(cuenta);

            //activo corriente
            cuenta = new CuentaCatalogo();
            cuenta.Codigo = "12";
            cuenta.Nombre = "Activo No Corriente";
            cuenta.Agrupacion = "Activo corriente";
            cuenta.Tipo_saldo = "DEUDOR";
            cuenta.Nivel = 2;
            cuenta.Rubro = "ACTIVO";
            cts.Add(cuenta);
 /////TERMINAN ACTIVO --------------------------------------------------------------

 ////COMIENZAN PASIVO --------------------------------------------------------------
            cuenta = new CuentaCatalogo();
            cuenta.Codigo = "2";
            cuenta.Nombre = "----------------------------------------------PASIVO----------------------------------------------";
            cuenta.Tipo_saldo = "ACREEDOR";
            cuenta.Rubro = "PASIVO";
            cuenta.Nivel = 1;
            cts.Add(cuenta);


            //pasivo corriente
            cuenta = new CuentaCatalogo();
            cuenta.Codigo = "21";
            cuenta.Nombre = "Pasivo Corriente";
            cuenta.Agrupacion = "Pasivo Corriente";
            cuenta.Tipo_saldo = "ACREEDOR";
            cuenta.Rubro = "PASIVO";
            cuenta.Nivel = 2;
            cts.Add(cuenta);

            //pasivo no corriente
            cuenta = new CuentaCatalogo();
            cuenta.Codigo = "22";
            cuenta.Nombre = "Pasivo no Corriente";
            cuenta.Agrupacion = "Pasivo no Corriente";
            cuenta.Tipo_saldo = "ACREEDOR";
            cuenta.Rubro = "PASIVO";
            cuenta.Nivel = 2;
            cts.Add(cuenta);

////TERMINAN PASIVO --------------------------------------------------------------


////COMIENZAN CAPITAL --------------------------------------------------------------

            cuenta = new CuentaCatalogo();
            cuenta.Codigo = "3";
            cuenta.Nombre = "----------------------------------------------PATRIMONIO----------------------------------------------";
            cuenta.Tipo_saldo = "ACREEDOR";
            cuenta.Rubro = "CAPITAL";
            cuenta.Nivel = 1;
            cts.Add(cuenta);

            //patrimonio
            cuenta = new CuentaCatalogo();
            cuenta.Codigo = "31";
            cuenta.Nombre = "Patrimonio";
            cuenta.Agrupacion = "Patrimonio";
            cuenta.Tipo_saldo = "ACREEDOR";
            cuenta.Rubro = "CAPITAL";
            cuenta.Nivel = 2;
            cts.Add(cuenta);
////TERMINAN CAPITAL --------------------------------------------------------------

////COMIENZAN COSTOS Y GASTOS --------------------------------------------------------------

            cuenta = new CuentaCatalogo();
            cuenta.Codigo = "4";
            cuenta.Nombre = "----------------------------------------------COSTOS Y GASTOS----------------------------------------------";
            cuenta.Tipo_saldo = "DEUDOR";
            cuenta.Rubro = "COSTOS Y GASTOS";
            cuenta.Nivel = 1;
            cts.Add(cuenta);

            //costos
            cuenta = new CuentaCatalogo();
            cuenta.Codigo = "41";
            cuenta.Nombre = "Costos";
            cuenta.Agrupacion = "Costos";
            cuenta.Tipo_saldo = "DEUDOR";
            cuenta.Rubro = "COSTOS Y GASTOS";
            cuenta.Nivel = 2;
            cts.Add(cuenta);

            //gastos operativos
            cuenta = new CuentaCatalogo();
            cuenta.Codigo = "42";
            cuenta.Nombre = "Gastos Operativos";
            cuenta.Agrupacion = "Gastos Operativos";
            cuenta.Tipo_saldo = "DEUDOR";
            cuenta.Rubro = "COSTOS Y GASTOS";
            cuenta.Nivel = 2;
            cts.Add(cuenta);
////TERMINAN COSTOS Y GASTOS --------------------------------------------------------------


////COMIENZAN INGRESOS --------------------------------------------------------------

            cuenta = new CuentaCatalogo();
            cuenta.Codigo = "5";
            cuenta.Nombre = "----------------------------------------------INGRESOS----------------------------------------------";
            cuenta.Tipo_saldo = "ACREEDOR";
            cuenta.Rubro = "INGRESOS";
            cuenta.Nivel = 1;
            cts.Add(cuenta);

            //ingresos ordinarios
            cuenta = new CuentaCatalogo();
            cuenta.Codigo = "51";
            cuenta.Nombre = "Ingresos Ordinarios";
            cuenta.Agrupacion = "Ingresos Ordinarios";
            cuenta.Tipo_saldo = "ACREEDOR";
            cuenta.Rubro = "INGRESOS";
            cuenta.Nivel = 2;
            cts.Add(cuenta);


            //Se devuleve ordenando por codigo las cuentas
            return cts.OrderBy(x => x.Codigo).ToList();


        }



        public int GuardarPartida(Partida partida, List<DetallePartida> cuerpo)
        {
            return Datos.GuardarPartida(partida, cuerpo);
        }


        public List<ReporteDiario> buscarPartida(int? entero)
        {
            List<ReporteDiario> detalles = new List<ReporteDiario>();
            DataTable dt = Datos.buscarPartida(entero);
          
            foreach (DataRow row in dt.Rows)
            {
                DateTime fecha = Convert.ToDateTime(row["fecha"].ToString());

                detalles.Add(new ReporteDiario(
                          row["codigo"].ToString(),
                          row["nombre"].ToString(),
                          row["descripcion"].ToString(),
                          fecha.ToString("dd/MM/yyyy h:mm:ss tt"),
                          Int32.Parse(row["numero"].ToString()),
                          Int32.Parse(row["id_cuenta"].ToString()),
                          Decimal.Parse(row["debe"].ToString()) > 0 ? Decimal.Parse(row["debe"].ToString()) 
                          :0,
                          Decimal.Parse(row["haber"].ToString()) > 0 ? Decimal.Parse(row["haber"].ToString())
                          :0
                          )); 


                

            }
            return detalles;
        }


        public DataTable DetalleMayor(int idCuenta)
        {
            return Datos.buscarDetalleMayor(idCuenta);
        }

  
        public CuentaCatalogo Buscar(int idCuenta)
        {
            return Datos.EncontrarCuenta(idCuenta);
        }

        public List<ISRrangos> rangos()
        {
            return Datos.rangos();
        }
    }
}
