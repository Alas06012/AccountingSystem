using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;
using CapaEntidades.Utilities;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using Reportes;




namespace CapaNegocio
{
    public class CN_Documento
    {
        CD_Documento Datos = new CD_Documento();
        CD_Clientes DatosCliente = new CD_Clientes();
        CD_Productos DatosProducto = new CD_Productos();
        CD_Series CD_Series = new CD_Series();

        JavaScriptSerializer Serializer = new JavaScriptSerializer();


        public bool valida_Documento(int serie, int numero)
        {
            return Datos.validaDocumento(serie, numero);
        }

        public int GuardarDocumento(Documento doc, List<DetalleDocumento> detalles, Dictionary<String,String> data, bool agente, Cliente cliente)
        {
            if (doc.Cliente < 1)
            {
                Mensaje.ErrorMessage = "Debe seleccionar un cliente";
            }
            else if (detalles.Count() < 1)
            {
                Mensaje.ErrorMessage = "Agregue detalles al cuerpo del documento";
            }
            else if (doc.Tipo_documento == "ccf" && !new Regex("^[0-9]{4}-[0-9]{6}-[0-9]{3}-[0-9]{1}$").IsMatch(data["nit"]))
            {
                Mensaje.ErrorMessage = "El número de NIT es obligatorio, y debe tener el formato correcto";
            }
            else if (doc.Tipo_documento == "ccf" && !new Regex("^[0-9]{2,6}-[0-9]{1}").IsMatch(data["registro"]))
            {
                Mensaje.ErrorMessage = "El número de registro es obligatorio, y debe tener el formato correcto";
            }
            else if (doc.Numero < 1)
            {
                Mensaje.ErrorMessage = "Proporcione un número de documento valido";
            }
            else if (doc.Serie < 0)
            {
                Mensaje.ErrorMessage = "Seleccione un número de serie.";
            }
            else
            {
                if (valida_Documento(doc.Serie, doc.Numero))
                {
                    //verificar nit y nrc, si son iguales se deja y si no se actualiza
                    if (!cliente.Nit.Equals(data["nit"]) || !cliente.Nit.Equals(data["registro"]))
                    {
                        CD_Clientes datocliente = new CD_Clientes();
                        datocliente.ActualizarNIT(cliente._Id, data["nit"], data["registro"]);
                    }

                    var serializer = new JavaScriptSerializer();
                    doc.Datos_cliente = serializer.Serialize(data);

                    return Datos.GuardarDocumento(doc, detalles, agente);
                }
                else
                {
                    Mensaje.ErrorMessage = "El número de factura introducida ya ha sido utilizado";
                }
            }
            return 0;


        }


        public Documento prueba(int id)
        {
            return Datos.find(id);
        }


        public ReporteDocumento ImprimirDocumento(int id)
        {
            //Buscar documento en base de datos
            Documento doc = Datos.find(id);
            List<DetalleDocumento> dt = Datos.Buscar_detalles(id);

            Cliente cliente = DatosCliente.find(doc.Cliente);

            List<ReporteDocumentoDetalle> Detalles = new List<ReporteDocumentoDetalle>();
            if (doc.Tipo_documento == "fcf" && doc.Caso == "afectas")
            {
                foreach (DetalleDocumento det in dt)
                {

                    var prod = DatosProducto.find(det.Producto);
                    decimal precio = decimal.Round(det.Precio + doc.Iva, 4);
                    Detalles.Add(new ReporteDocumentoDetalle(det.Cant, prod.Nombre, precio, 0.00m, decimal.Round(precio * det.Cant, 2)));

                }
            }
            else if (doc.Caso == "exentas")
            {
                foreach (DetalleDocumento det in dt)
                {
                    var prod = DatosProducto.find(det.Producto);
                    Detalles.Add(new ReporteDocumentoDetalle(det.Cant, prod.Nombre, det.Precio, decimal.Round(det.Precio * det.Cant, 2), 0.00m));
                }

            }
            else
            {
                foreach (DetalleDocumento det in dt)
                {
                    var prod = DatosProducto.find(det.Producto);
                    Detalles.Add(new ReporteDocumentoDetalle(det.Cant, prod.Nombre, det.Precio, 0.00m, decimal.Round(det.Precio * det.Cant, 2)));
                }
            }

             string serie = CD_Series.buscarSerie(doc.Serie);
            string tipoDocumento="";

            if (doc.Tipo_documento == "fcf")
            {
                tipoDocumento = "Factura Consumidor Final";
            }
            else if (doc.Tipo_documento == "ccf")
            {
                tipoDocumento = "Comprobante Crédito Fiscal";
            }
            else if (doc.Tipo_documento == "fex")
            {
                tipoDocumento = "Factura Exportación";
            }
            else if (doc.Tipo_documento == "nc")
            {
                tipoDocumento = "Nota Crédito";
            }
            else if (doc.Tipo_documento == "fex")
            {
                tipoDocumento = "Nota Revisión";
            }
            else if (doc.Tipo_documento == "nd")
            {
                tipoDocumento = "Nota Débito";
            }
           

            var data = Serializer.Deserialize<Dictionary<string, string>>(doc.Datos_cliente);

            decimal total = doc.Afectas + doc.Exentas + doc.Iva - doc.Retencion + doc.Percepcion;
            ReporteDocumento reporte = new ReporteDocumento(
                tipoDocumento,
                serie,
                cliente.Nombre,
                doc.Numero,
                doc.Fecha,
                data["Direccion"],
                data["registro"],
                data["nit"],
                doc.Condiciones == 0 ? "Contado" : $"{doc.Condiciones} Crédito",
                doc.Afectas > 0.00m ? String.Format("{0:c}", doc.Afectas) : "",
                doc.Exentas > 0.00m ? String.Format("{0:c}", doc.Exentas) : "",
                doc.Iva > 0.00m ? String.Format("{0:c}", doc.Iva) : "",
                doc.Retencion > 0.00m ? String.Format("{0:c}", doc.Retencion) : "",
                doc.Percepcion > 0.00m ? String.Format("{0:c}", doc.Percepcion) : "",
                String.Format("{0:c}", total),
                Detalles,
                String.Format("{0:c}",
                doc.Afectas + doc.Iva)
                );

            //devuelve el resultado
            return reporte;
        }



        public ReporteVentaConsumidor libroVentasConsumidor(DateTime fecha)
        {
            //Buscar documentos que sean = fcf entre el rango de fechas
            fecha = new DateTime(fecha.Year, fecha.Month, 1, 00, 00, 00, 0);
            DateTime hasta = fecha.AddMonths(1).AddSeconds(-1);


            //Seleccionar todos los documentos de fcf y ex, cuando la fecha este entre los datetime que le di y me devuelve una lista
            List<Documento> docs = Datos.busca_facturas(fecha, hasta);

            Dictionary<String, ReporteVentasConsumidorDetalle> detalles = new Dictionary<string, ReporteVentasConsumidorDetalle>();
            //Agrupar por fecha
            decimal internas_gravadas = 0.00m, internas_debito = 0.00m, internas_exentas = 0.00m, exportacion = 0.00m;

            //Llenar detalles de reporte
            foreach (Documento dc in docs)
            {
                string key = dc.Fecha.ToString("dd/MM/yyyy");
                if (detalles.ContainsKey(key))
                {
                    if (dc.Tipo_documento == "fex")
                    {
                        detalles[key].Exportacion_gravadas1 += dc.Afectas;
                        detalles[key].Fex = detalles[key].Fex + "FEX" + dc.Numero.ToString() + "," ;
                        exportacion += dc.Afectas;
                    }
                    else
                    {
                        internas_gravadas += dc.Afectas;
                        internas_debito += dc.Iva;
                        internas_exentas += dc.Exentas;

                        detalles[key].Local_gravadas += dc.Afectas;
                        detalles[key].Hasta = dc.Numero;

                    }
                    detalles[key].Totales += Decimal.Round(dc.Afectas + dc.Exentas + dc.Percepcion + dc.Iva - dc.Retencion, 2);

                }
                else
                {
                    ReporteVentasConsumidorDetalle toAdd;
                    if (dc.Tipo_documento == "fex")
                    {
                        toAdd = new ReporteVentasConsumidorDetalle(
                            key,
                            0,
                            0,
                            0.00m,
                            dc.Afectas,
                            dc.Exentas,
                            Decimal.Round(dc.Afectas + dc.Exentas + dc.Percepcion + dc.Iva - dc.Retencion, 2),
                            "FEX" + dc.Numero.ToString() + ","
                            );
                        exportacion += dc.Afectas;
                    }
                    else
                    {
                        toAdd = new ReporteVentasConsumidorDetalle(
                            key,
                            dc.Numero,
                            dc.Numero,
                            dc.Afectas + dc.Iva,
                            0.00m,
                            dc.Exentas,
                            Decimal.Round(dc.Afectas + dc.Exentas + dc.Percepcion + dc.Iva - dc.Retencion, 2),
                            ""
                            );

                        internas_gravadas += dc.Afectas;
                        internas_debito += dc.Iva;
                        internas_exentas += dc.Exentas;

                    }

                    detalles.Add(key, toAdd);
                }
            }



            //llenar y devolver el objeto del reporte, para llenar el reporte con sus datos respectivos
            ReporteVentaConsumidor data = new ReporteVentaConsumidor(fecha.ToString("MM/yyyy"),
                internas_gravadas, internas_debito,internas_exentas,exportacion, new List<ReporteVentasConsumidorDetalle>());

            foreach (KeyValuePair<string, ReporteVentasConsumidorDetalle> par in detalles)
            {
                data.Detalles.Add(par.Value);
            }

            return data;


        }

        public ReporteVentaConsumidor libroCompras(DateTime fecha)
        {
            //Buscar documentos que sean = fcf entre el rango de fechas
            fecha = new DateTime(fecha.Year, fecha.Month, 1, 00, 00, 00, 0);
            DateTime hasta = fecha.AddMonths(1).AddSeconds(-1);


            //Seleccionar todos los documentos de compra, cuando la fecha este entre los datetime que le di y me devuelve una lista
            List<Compra> docs = Datos.busca_compras(fecha, hasta);

            List<LibroComprasDetalles> det = new List<LibroComprasDetalles>();
            //Agrupar por fecha
            decimal internas_gravadas = 0.00m, internas_debito = 0.00m, retencion = 0.00m, exportacion = 0.00m;

            foreach (Compra dc in docs)
            {
                CD_Proveedores nomProve = new CD_Proveedores();
                Proveedor nombreProve = nomProve.find(dc.Proveedor);

                LibroComprasDetalles toAdd;
                toAdd = new LibroComprasDetalles(
                        dc.Fecha.ToString("dd/MM/yyyy"),
                        dc.Document_type.ToUpper() + "# " + dc.Document_number,
                        nombreProve.Nombre +"\n"+ nombreProve.Clasificacion + "\nNIT: "+nombreProve.Nit+"\nNRC: "+nombreProve.Nrc,
                        dc.Afectas,
                        dc.Iva,
                        0.00m,
                        dc.Retencion,
                        Decimal.Round(dc.Afectas + dc.Iva - dc.Retencion, 2)
                        ); 

                internas_gravadas += dc.Afectas;
                internas_debito += dc.Iva;
                retencion += dc.Retencion;



                det.Add(toAdd);
            }

            ReporteVentaConsumidor data = new ReporteVentaConsumidor(fecha.ToString("MM/yyyy"),
                internas_gravadas, internas_debito, retencion, exportacion, new List<LibroComprasDetalles>());

            foreach (LibroComprasDetalles par in det)
            {
                data.Detall.Add(par);
            }

            return data;


        }



        public ReporteVentaConsumidor libroVentasContribuyente(DateTime fecha)
        {
            //Buscar documentos que sean = fcf entre el rango de fechas
            fecha = new DateTime(fecha.Year, fecha.Month, 1, 00, 00, 00, 0);
            DateTime hasta = fecha.AddMonths(1).AddSeconds(-1);


            //Seleccionar todos los documentos de fcf y ex, cuando la fecha este entre los datetime que le di y me devuelve una lista
            List<Documento> docs = Datos.busca_ccf(fecha, hasta);

            List<ReporteVentasConsumidorDetalle> detalles = new List<ReporteVentasConsumidorDetalle>();
            //Agrupar por fecha
            decimal internas_gravadas = 0.00m, internas_debito = 0.00m, internas_exentas = 0.00m, exportacion = 0.00m;

            //Llenar detalles de reporte
            foreach (Documento dc in docs)
            {

                ReporteVentasConsumidorDetalle toAdd;
                    toAdd = new ReporteVentasConsumidorDetalle(
                            dc.Fecha.ToString("dd/MM/yyyy"),
                            dc.Numero,
                            dc.Numero,
                            dc.Afectas + dc.Iva,
                            0.00m,
                            dc.Exentas,
                            Decimal.Round(dc.Afectas + dc.Exentas + dc.Percepcion + dc.Iva - dc.Retencion, 2),
                            ""
                            );

                    internas_gravadas += dc.Afectas;
                    internas_debito += dc.Iva;
                    internas_exentas += dc.Exentas;



                    detalles.Add(toAdd);
            }




            //llenar y devolver el objeto del reporte, para llenar el reporte con sus datos respectivos
            ReporteVentaConsumidor data = new ReporteVentaConsumidor(fecha.ToString("MM/yyyy"),
                internas_gravadas, internas_debito, internas_exentas, exportacion, new List<ReporteVentasConsumidorDetalle>());

            foreach (ReporteVentasConsumidorDetalle par in detalles)
            {
                data.Detalles.Add(par);
            }

            return data;


        }


    }




     





}
