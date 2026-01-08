using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadora
{
    internal class Multiplicacion : Calculadora
    {
        public override decimal Calcular(decimal a, decimal b)
        {
            return a * b;
        }

        public override void ObtenerResultado(decimal a, decimal b)
        {
            decimal resultado = Calcular(a, b);
            string formato = resultado.ToString("N2");
            Console.WriteLine("\nResultado de la multiplicacion: " + formato);
        }
    }
}
