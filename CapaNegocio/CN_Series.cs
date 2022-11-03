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

namespace CapaNegocio
{
    public class CN_Series
    {
        CD_Series serie = new CD_Series();
        public string dameSerie(string tipo)
        {
           return serie.dameSerie(tipo);
        }

        public string dameCorrelativo(string tipo)
        {
            return serie.dameCorrelativo(tipo);
        }

        public List<Serie> Todos()
        {
            return serie.todos();

        }

        public string Ingresar(int desde, int hasta, string serie_, string tipo)
        {

            return serie.Ingresar(desde, hasta, serie_, tipo);


        }


    }
}
