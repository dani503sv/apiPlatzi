using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {

                var opcion = 0;
                var division = new Division();
                var multiplicacion = new Multiplicacion();
                var suma = new Suma();

                do {
                    Console.WriteLine("\nCalculadora Simple");
                    Console.WriteLine("-------------------");
                    Console.Write("Digite el primer número: ");
                    decimal num1 = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Digite el segundo número: ");
                    decimal num2 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Escoga la operacion:");
                    Console.WriteLine("1 - Suma (+)");
                    Console.WriteLine("2 - Multiplicar (*)");
                    Console.WriteLine("3 - Dividir (/)");
                    Console.WriteLine("6 - Salir");
                    Console.Write("Digite el numero para iniciar la operacion: ");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            suma.ObtenerResultado(num1, num2);
                            break;
                        case 2:
                            multiplicacion.ObtenerResultado(num1, num2);
                            break;
                        case 3:
                            division.ObtenerResultado(num1, num2);
                            break;
                        case 6:
                            Console.WriteLine("Saliendo de la calculadora...");
                            break;
                        default:
                            Console.WriteLine("Operacion inválida.");
                            return;
                    }

                } while (opcion != 6);

               
            }
            catch (Exception ex) 
            {
              Console.WriteLine("Ocurrio un error: " + ex.Message);
            }
            
        }
    }
}
