using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades.Utilities;
using CapaEntidades;

namespace CapaNegocio
{
   public  class CN_Compra
    {
        public CD_Compras Datos = new CD_Compras();

        public int RegistraCompra(List<DetalleCompra> detalles, Compra compra, bool percepcion, bool retencion)
        {
            if (detalles.Count < 1)
            {
                Mensaje.ErrorMessage = "No se ha recibido detalles en el cuerpo de la compra";
                return 0;
            }
            else if (compra.Proveedor < 1)
            {
                Mensaje.ErrorMessage = "No se ha recibido un proveedor";
                return 0;
            }
            else if (String.IsNullOrEmpty(compra.Document_number))
            {
                Mensaje.ErrorMessage = "No se ha recibido un numero de factura";
                return 0;
            }
            else if (String.IsNullOrEmpty(compra.Document_type))
            {
                Mensaje.ErrorMessage = "No se ha recibido un tipo de documento";
                return 0;
            }
            else
            {

                return Datos.RegistrarCompra(detalles, compra, percepcion, retencion);
            }
        }











    }
}
