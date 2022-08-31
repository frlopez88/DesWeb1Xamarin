using System;
using System.Collections.Generic;
using System.Text;

namespace DesWebRepaso.Models
{
    public class persona
    {

        public string nombre {get; set;}
        public int edad { get; set; }
        public string telefono { get; set; }
        public string pass { get; set; }


        public string reportePersona() {

            return "No nombre es: " + nombre + " Mi telefono es: " + telefono;


        }

    }
}
