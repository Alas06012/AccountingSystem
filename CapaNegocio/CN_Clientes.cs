using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaEntidades.Utilities;
using CapaDatos;
using System.Text.RegularExpressions;

namespace CapaNegocio {
    public class CN_Clientes {

        CD_Clientes Datos = new CD_Clientes();
        public List<Cliente> Buscar(string busqueda) {
            return Datos.Buscar(new List<string> { "nombre", "nit", "nrc", "razon_social" }, busqueda);
        }

        public List<Cliente> TodosClientes() {
            return Datos.todos();
        }

        public Cliente GuardarCliente(Cliente client) {
            if (String.IsNullOrEmpty(client.Nombre)) {
                Mensaje.ErrorMessage = "Llene el campo nombre para Guardar el Cliente";
            } else if (String.IsNullOrEmpty(client.Clasificacion)) {
                Mensaje.ErrorMessage = "Llene el campo nombre para Guardar el Cliente";
            } else if (client.Clasificacion != "ninguno" && !new Regex("^[0-9]{4}-[0-9]{6}-[0-9]{3}-[0-9]{1}$").IsMatch(client.Nit)) {
                Mensaje.ErrorMessage =  "Debe llenar el Campo NIT con el formato correcto";
            } else if (client.Clasificacion != "ninguno" && !new Regex("^[0-9]{2,6}-[0-9]{1}$").IsMatch(client.Nrc)) {
                Mensaje.ErrorMessage = "Debe llenar el Numero de registro con el formato correcto";
            } else {
                return Datos.Crear(client);
            }
            return null;
        }

        public string ActualizarCliente(Cliente client) {
            if (String.IsNullOrEmpty(client.Nombre)) {
                return "Llene el campo nombre para Guardar el Cliente";
            } else if (String.IsNullOrEmpty(client.Clasificacion)) {
                return "Llene el campo nombre para Guardar el Cliente";
            } else if (client.Clasificacion != "ninguno" && !new Regex("^[0-9]{4}-[0-9]{6}-[0-9]{3}-[0-9]{1}$").IsMatch(client.Nit)) {
                return "Debe llenar el Campo NIT con el formato correcto";
            } else if (client.Clasificacion != "ninguno" && !new Regex("^[0-9]{2,6}-[0-9]{1}$").IsMatch(client.Nrc)) {
                return "Debe llenar el Numero de registro con el formato correcto";
            } else {
                return Datos.Actualizar(client);
            }
        }


        public Cliente prueba(int id)
        {
            return Datos.find(id);
        }

    }
}
