using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio {
    public class CN_Usuarios {

        CD_Usuarios CapaDatos = new CD_Usuarios();

        public string Login(String usuario, String Pass) {
            //buscar usuario
            Usuario user = CapaDatos.BuscarUno("usuario", usuario);
            if (user == null) {
                return "Usuario o Contraseña Incorrectos";
            } else {
                //verificar el estado y el numero de intentos
                if (user.Estado == "desactivado") {
                    return "El Usuario ha sido desactivado y no puede iniciar sesion";
                } else if (user.Estado == "bloqueado") {
                    return "Ha exedido el numero de errores permitidos y su usuario ha sido Bloqueado";
                } else {
                    //verificar contraseña

                    if (user.Contra.Equals(Pass)) {
                        //si es correcta crear variables de persistencia de la sesion
                        UsuarioCache.id = user._Id;
                        UsuarioCache.nombre = user.Nombre;
                        UsuarioCache.pass = user.Contra;
                        UsuarioCache.usuario = user._Usuario;
                        return "";
                    } else {
                        //si es incorrecta actualizar estado y numero de intentos
                        CapaDatos.ReduceIntento(user);
                        return "Contraseña Incorrecta";
                    }
                }
            }

        }


        public String CrearUsuario(Usuario user) {
            if (String.IsNullOrEmpty(user.Nombre)) {
                return "No ha proporcionado un nombre para el usuario que desea guardar";
            } else if (String.IsNullOrEmpty(user.Contra) || user.Contra.Length < 8) {
                return "No ha proporcionado una contraseña Valida";
            } else if (String.IsNullOrEmpty(user._Usuario)) {
                return "El campo usuario es obligatorio";
            } else {
                return CapaDatos.Crear(user);
            }
        }

        public String ActualizarUsuario(Usuario user) {
            if (String.IsNullOrEmpty(user.Nombre)) {
                return "No ha proporcionado un nombre para el usuario que desea guardar";
            } else if (String.IsNullOrEmpty(user._Usuario)) {
                return "El campo usuario es obligatorio";
            } else {
                return CapaDatos.Actualizar(user);
            }
        }

        public String ActivarUsuario(Usuario user) {
            return user._Id < 1 ? "No ha proporcionado un identificador para el usuario que desea Activar" : CapaDatos.Activar(user);
        }

        public String DesactivarUsuario(Usuario user) {
            return user._Id < 1 ? "No ha proporcionado un identificador para el usuario que desea Activar" : CapaDatos.Desactivar(user);
        }

        public List<Usuario> TodosUsuarios() {
            return CapaDatos.todos();
        }

        public List<Usuario> Buscar(List<String> campos, String busqueda) {
            return CapaDatos.Buscar(campos, busqueda.Trim());
        }

    }
}
