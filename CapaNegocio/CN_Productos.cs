using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaEntidades.Utilities;
using CapaDatos;
using Reportes;

namespace CapaNegocio {

    public class CN_Productos {
        private CD_Productos CD = new CD_Productos();
        public List<Producto> TodosProductos() {
            return CD.todos();
        }

        public List<Producto> BuscarProducto(string busqueda) {
            return CD.Buscar(new List<string> {"nombre", "codigo", "precio", "existencias"}, busqueda);
        }

        public string EliminarProducto(Producto prod) {
            return prod.Id < 1 ? "no se ha recibido ningun ID" : CD.delete(prod);
        }

        public int CrearProducto(Producto prod) {
            if (String.IsNullOrEmpty(prod.Nombre)) {
                Mensaje.ErrorMessage = "El Campo nombre es obligatorio";
            } else if (String.IsNullOrEmpty(prod.Descripcion)) {
                Mensaje.ErrorMessage = "El Campo descripcion es obligatorio";
            } else if (prod.Precio < 0.01m) {
                Mensaje.ErrorMessage = "El Campo precio es obligatorio";
            } else if (String.IsNullOrEmpty(prod.Codigo)) {
                Mensaje.ErrorMessage = "El Campo Codigo es obligatorio";
            } else {
                prod = CD.Crear(prod);
                return prod == null ? 0 : prod.Id;
            }
            return 0;
        }
        public string ActualizarProducto(Producto prod) {
            if (String.IsNullOrEmpty(prod.Nombre)) {
                return "El Campo nombre es obligatorio";
            } else if (String.IsNullOrEmpty(prod.Descripcion)) {
                return "El Campo descripcion es obligatorio";
            } else if (prod.Precio < 0.01m) {
                return "El Campo precio es obligatorio";
            } else if (String.IsNullOrEmpty(prod.Codigo)) {
                return "El Campo Codigo es obligatorio";
            } else {
                return CD.Actualizar(prod);
            }
        }


        public ReporteKardex Kardex(int product_id, DateTime desde, DateTime hasta)
        {
            List<ReportekardexDetalle> detalles = new List<ReportekardexDetalle>();
            Producto producto = CD.find(product_id);
            var moves = CD.movimientos(product_id, new DateTime(desde.Year, desde.Month, desde.Day, 00, 00, 00, 00), new DateTime(hasta.Year, hasta.Month, hasta.Day, 23, 59 ,59, 59));

            var inicial = new ReportekardexDetalle(
                    desde.ToString("dd/MM/yyyy"),
                    "Saldo inicial a la fecha", "", "",
                    0, 0, 0, 0, 0, 0, 0, 0, 0
                );
            if (moves.Count > 0)
            {
                //si hay movimiento se llenan con datos que habian hasta la fecha
                inicial.Saldos_unidades = moves[0].Existencia_anterior;
                inicial.Saldos_unitario = moves[0].Costo_anterior;
                inicial.Saldos_valor = (moves[0].Existencia_anterior * moves[0].Costo_anterior);
                detalles.Add(inicial);
                foreach (Movimiento move in moves)
                {
                    // verifica si es venta(0) o si es compra(1)
                    if (move.Tipo == 0)
                    {
                        detalles.Add(new ReportekardexDetalle(
                            move.Fecha.ToString("dd/MM/yyyy hh:mm:t"), //fecha
                            move.Doc, // documento
                            move.Cliente, // cliente
                            "Venta",//tipo de accion
                            0, 0, 0,//entradas
                            move.Cant,//cantidades salidas
                            move.Costo,//costo salida
                            Decimal.Round(move.Cant * move.Costo, 2),//subtotal salidas
                            move.Existencia_anterior - move.Cant,//saldos unidades
                            move.Costo, // saldos costo promedio
                            Decimal.Round((move.Existencia_anterior - move.Cant) * move.Costo, 2) // Saldo total
                            ));
                    }
                    else
                    {
                        var promedio = Decimal.Round((move.Cant * move.Costo) + (move.Existencia_anterior * move.Costo_anterior)) / (move.Existencia_anterior + move.Cant);
                        detalles.Add(new ReportekardexDetalle(
                            move.Fecha.ToString("dd/MM/yyyy hh:mm: t"), // fecha
                            move.Doc, //documento
                            move.Cliente,//proveedor
                            "Compra", // tipo de accion
                            move.Cant, //cantidades entrada
                            move.Costo, // costo entrada
                            Decimal.Round(move.Cant * move.Costo, 2), // subtotal entrada (compra)
                            0, 0, 0, // salidas porque es compra(compra)
                            move.Existencia_anterior + move.Cant, // saldos unidades
                            promedio, // saldos costos promedio
                            Decimal.Round((move.Existencia_anterior + move.Cant) * promedio, 2) //Saldos total
                            ));       
                    }
                }
            }
            else
            {
                detalles.Add(inicial);
            }
            return new ReporteKardex(desde.ToString(), hasta.ToString(), detalles, producto.Nombre);
        }



        public Producto Buscar(int id)
        {
            return CD.find(id);
        }



    }
}
