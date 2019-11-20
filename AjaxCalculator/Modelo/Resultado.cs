using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxCalculator.Modelo
{
    public class Resultado
    {
        public double sumar(PropiedadesNum n)
        {
            double suma;
            suma = n.N1 + n.N2;
            return suma;
        }

        public double restar(PropiedadesNum n)
        {
            double restar;
            restar = n.N1 - n.N2;
            return restar;
        }

        public double multiplicar(PropiedadesNum n)
        {
            double restar;
            restar = n.N1 * n.N2;
            return restar;
        }

        public double dividir(PropiedadesNum n)
        {
            double restar;
            restar = n.N1 / n.N2;
            return restar;
        }
    }
}