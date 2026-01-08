using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadora
{
    internal class Division : Calculadora
    {
        public override decimal Calcular(decimal a, decimal b)
        {
            if (b == 0)
            {
                return 0;
            }
            else {
                return a / b;
            }
                
        }



        public override void ObtenerResultado(decimal a, decimal b)
        {
            decimal resultado = Calcular(a, b);

            if (b==0) 
            { 
                Console.WriteLine("\nError: División por cero no está definida.");
            }
            else
            {
                string formato = resultado.ToString("N2");
                Console.WriteLine("\nResultado de la división: " + formato);
            }
                
           
        }
    }
    
}
