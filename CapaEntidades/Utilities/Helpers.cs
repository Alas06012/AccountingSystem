using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Utilities
{
    public class Helpers
    {
        public static string dinero_A_string(decimal cantidad, string plural = "Dolares", string singular="Dolar")
        {
            if (cantidad == 0.00m)
            {
               return $"Cero dolares.";
            }
            else
            if (cantidad > 9999999999999999999999.99m)
            {
                Mensaje.ErrorMessage = $"La cantidad {cantidad} no es soportada por esta función.";
                return null;
            }
            else if (cantidad == 1m)
            {
                return $"Un {singular}";
            }
            else
            {
                string letra = "0." + cantidad.ToString().Split('.')[1];
                string respuesta = "";
                int enteros = int.Parse(cantidad.ToString().Split('.')[0]);
                float centimos = float.Parse(letra);

                if (enteros >= 1 && enteros <= 29)
                {
                    respuesta = basicos(enteros);
                }
                else if (enteros >= 30 && enteros <=100)
                {
                    respuesta = tens(enteros);
                }
                else if (enteros >= 100 && enteros <= 999)
                {
                    respuesta = cientos(enteros);
                }
                else if (enteros >= 1000 && enteros <= 999999)
                {
                    respuesta = miles(enteros);
                }
                else if (enteros>=1000000)
                {
                    respuesta = millones(enteros);
                }

                return centimos == 0 ? $"{respuesta} {centimos}/100 {plural}" : $"{respuesta} {plural} con {centimos} ctvs";
            }
        }



        private static string basicos(int number)
        {
            string[] val = new string[29] { "un", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve", "veinte", "veintiuno", "veintidos", "veintitres", "veinticuatro", "veinticinco", "veintiséis", "veintisiete", "veintiocho", "veintinueve" };
            return val[number - 1];
        }


        private static string tens(int n)
        {
            Dictionary<int, string> val = new Dictionary<int, string>()
            {
                {10, "diez" },
                {20, "veinte" },
                {30, "treinta" },
                {40, "cuarenta" },
                {50, "cincuenta"},
                {60, "sesenta" },
                {70, "setenta" },
                {80, "ochenta" },
                {90, "noventa" }
            };
            if (n<30)
            {
                return basicos(n);
            }
            int x = n % 10;
            if (x==0)
            {
                return val[n];
            }
            return $"{val[n - x]} y {basicos(x)}";
        }


        private static string cientos(int n)
        {

            Dictionary<int, string> val = new Dictionary<int, string>()
            {
                {100, "ciento" },
                {200, "doscientos" },
                {300, "trescientos" },
                {400, "cuatrocientos" },
                {500, "quinientos"},
                {600, "seiscientos" },
                {700, "setecientos" },
                {800, "ochecientos" },
                {900, "novecientos" }
            };
            if (n == 100)
            {
                return "cien";
            }
            else if (n>100)
            {
                int decenas = n % 100;
                return decenas == 0 ? val[n - decenas] : $"{val[n - decenas]}{tens(decenas)}";
            }
           else
            {
                return tens(n);
            }
        }


        private static string miles(int n)
        {
            if (n>999)
            {
                if(n == 1000)
                {
                    return "mil";
                }

                string str = n.ToString();
                int l = str.Length;
                int c = Int32.Parse(str.Substring(0, l - 3));
                int x = Int32.Parse(str.Substring(l - 3, 3));

                if (c == 1)
                {
                    return $"mil {cientos(x)}";
                }
                else if (x != 0)
                {
                    return cientos(n) + " mil " + cientos(x);
                }
                else
                {
                    return cientos(c) + " mil";
                }

            }
            return cientos(n);

        }

        private static string millones(int n)
        {
            if (n == 1000000)
            {
                return "un millon";
            }
            if (n > 999999)
            {

                string str = n.ToString();
                int l = str.Length;
                int c = Int32.Parse(str.Substring(0, 1 - 6));
                int x = Int32.Parse(str.Substring(1 - 6, 3));
                str = c == 1 ? " millon " : " millones ";

                return miles(c) + str + (x > 0 ? miles(x) : "");
            }
            
            return miles(n);
        }
    }
}
