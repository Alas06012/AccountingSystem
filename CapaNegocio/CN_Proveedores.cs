using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CapaEntidades;
using CapaEntidades.Utilities;

namespace CapaNegocio {
    public class CN_Proveedores {
        private CapaDatos.CD_Proveedores Datos = new CapaDatos.CD_Proveedores();

        public List<Proveedor> Todos(){
            return Datos.todos();
        }

        public List<Proveedor> Busqueda(String busqueda) {
            busqueda = busqueda.Trim();
            return !String.IsNullOrEmpty(busqueda) ? Datos.Buscar(new List<String>{"nit","nrc","nombre"},busqueda) : null;
        }

        public Proveedor guardar(Proveedor prov) {
            if (String.IsNullOrEmpty(prov.Nombre)) {
                Mensaje.ErrorMessage = "Escriba el nombre del proveedor";
            } else if (String.IsNullOrEmpty(prov.Tipo)) {
                Mensaje.ErrorMessage = "Elija el tipo de proveedor";
            } else if (String.IsNullOrEmpty(prov.Clasificacion)) {
                Mensaje.ErrorMessage = "Elija la clasificacion del Proveedor";
            } else if (prov.Clasificacion != "ninguno" && !new Regex("^[0-9]{4}-[0-9]{6}-[0-9]{3}-[0-9]{1}$").IsMatch(prov.Nit)) {
                Mensaje.ErrorMessage = "Debe llenar el Campo NIT con el formato correcto";
            } else {
                if (prov.Clasificacion != "ninguno" && !new Regex("^[0-9]{2,6}-[0-9]{1}$").IsMatch(prov.Nrc)) {
                    Mensaje.ErrorMessage = "Debe llenar el Numero de registro con el formato correcto";
                } else {
                    return Datos.Crear(prov);
                }
            } 
            return null;
        }

        public String Actualizar(Proveedor prov) {
            if (String.IsNullOrEmpty(prov.Nombre)) {
                return "Escriba el nombre del proveedor";
            } else if (String.IsNullOrEmpty(prov.Tipo)) {
                return "Elija el tipo de proveedor";
            } else if (String.IsNullOrEmpty(prov.Clasificacion)) {
                return "Elija la clasificacion del Proveedor";
            } else if (prov.Clasificacion != "ninguno" && !new Regex("^[0-9]{4}-[0-9]{6}-[0-9]{3}-[0-9]{1}$").IsMatch(prov.Nit)) {
                return  "Debe llenar el Campo NIT con el formato correcto";
            } else {
                if (prov.Clasificacion != "ninguno" && !new Regex("^[0-9]{2,6}-[0-9]{1}$").IsMatch(prov.Nrc)) {
                    return "Debe llenar el Numero de registro con el formato correcto";
                } else {
                    return Datos.Actualizar(prov);
                }
            }
        }


        public String Eliminar(Proveedor prov) {
            return prov._Id < 1 ? "Dame un Id para eliminar" : Datos.delete(prov);
        }





    }
}
