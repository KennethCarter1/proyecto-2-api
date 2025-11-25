using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto2.Models
{
    public class CalculadoraResultado
    {
        public string expresion { get; set; }
        public double resultado { get; set; }
        public DateTime fecha_operacion { get; set; }
    }
}