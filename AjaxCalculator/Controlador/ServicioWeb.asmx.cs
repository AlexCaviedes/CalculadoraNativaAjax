using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AjaxCalculator.Vista;
using AjaxCalculator.Modelo;

namespace AjaxCalculator.Controlador
{
    /// <summary>
    /// Descripción breve de ServicioWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class ServicioWeb : System.Web.Services.WebService
    {
        Resultado r = new Resultado();
        [WebMethod]
        public double suma(string a, string b)
        {
            double n1 = Convert.ToDouble(a);
            double n2 = Convert.ToDouble(b);
            PropiedadesNum n = new PropiedadesNum(Convert.ToDouble(n1), Convert.ToDouble(n2));//La nuevas variables se guardan creando un nuevo objeto.
            double d = r.sumar(n);
            return d;
        }

        [WebMethod]
        public double resta(string a, string b)
        {
            double n1 = Convert.ToDouble(a);
            double n2 = Convert.ToDouble(b);
            PropiedadesNum n = new PropiedadesNum(Convert.ToDouble(n1), Convert.ToDouble(n2));//La nuevas variables se guardan creando un nuevo objeto.
            double d = r.restar(n);
            return d;
        }

        [WebMethod]
        public double multiplica(string a, string b)
        {
            
            double n1 = Convert.ToDouble(a);
            double n2 = Convert.ToDouble(b);
            PropiedadesNum n = new PropiedadesNum(Convert.ToDouble(n1), Convert.ToDouble(n2));//La nuevas variables se guardan creando un nuevo objeto.
            double d = r.multiplicar(n);
            return d;
        }

        [WebMethod]
        public double divida(string a, string b)
        {
            double n1 = Convert.ToDouble(a);
            double n2 = Convert.ToDouble(b);
            PropiedadesNum n = new PropiedadesNum(Convert.ToDouble(n1), Convert.ToDouble(n2));//La nuevas variables se guardan creando un nuevo objeto.
            double d = r.dividir(n);
            return d;
        }
    }
}
