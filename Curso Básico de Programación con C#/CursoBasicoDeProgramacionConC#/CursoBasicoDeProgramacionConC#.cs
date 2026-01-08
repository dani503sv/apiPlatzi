using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Llamar al método
            CursoBasicoCSharp.EstructuraFor();
        }
    }

    public class CursoBasicoCSharp
    {
        public static void AreaTriangulo() {

            try {
                //Crear variables
                var a = 0.00;
                var b = 0.00;
                var area = 0.00;

                //Asignar valores
                Console.WriteLine("Escribe lado A del triángulo:");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Escribe lado B del triángulo:");
                b = Convert.ToDouble(Console.ReadLine());

                //Calcular área
                area = (a * b);

                string resultado = area.ToString("F2");

                //Mostrar resultado
                Console.WriteLine("\nLado A: {0} \nLado B: {1} \nEl área del triángulo es: {2}", a, b, resultado);
            } catch (Exception ex)
            {
                Console.WriteLine("Se ha producido un error: {0}", ex.Message);
            }

        }

        public static void AreaCirculo()
        {
            try {

                //Realizar el cálculo del área de un círculo
                var radio = 0.00;
                const double Pi = 3.1416;

                Console.WriteLine("Escribe el radio del círculo:");
                radio = Convert.ToDouble(Console.ReadLine());

                //Calcular área
                radio = Pi * (Math.Pow(radio, 2));
                string resultado = radio.ToString("F2");

                //Mostrar resultado
                Console.WriteLine("\nRadio: {0} \nEl área del círculo es: {1}", radio, resultado);

            }
            catch (Exception ex) {
                Console.WriteLine("Se ha producido un error: {0}", ex.Message);
            }

        }

        public static void OperadoresLogicos()
        {
            Console.WriteLine("=== OPERADORES LÓGICOS EN ACCIÓN ===\n" +
                  "¿Listo para pensar como una computadora?\n" +
                  "AND (&&): Solo es verdadero si ambos lo son.\n" +
                  "OR  (||): Basta con que uno diga 'sí'.\n" +
                  "NOT (!): Le da la vuelta a la verdad.\n");


            //OPeradores lógicos
            var (valor1, valor2, valor3) = (true, false, true);

            //x0r (Verifica si valores son diferentes)
            bool resultadoXor = valor1 ^ valor2;

            //restados
            bool resultado = !(valor1 && valor2 || valor3);


            //Mostrar resultado
            Console.WriteLine("El resultado de la operación lógica es: {0}", resultado);
            Console.WriteLine("El resultado de la operación lógica XOR es: {0}", resultadoXor);
        }

        public static void OperadoresRelacionales() {

            //Operadores relacionales
            Console.WriteLine("=== OPERADORES RELACIONALES ===\n" +
                  "¿Son iguales? ¿Quién es mayor? ¿Quién es menor?\n" +
                  "==  : Comprueba si son idénticos.\n" +
                  "!=  : Detecta diferencias.\n" +
                  ">   : Pregunta quién es más grande.\n" +
                  "<   : Pregunta quién es más pequeño.\n" +
                  ">=  : No se conforma con menos.\n" +
                  "<=  : Acepta ser menor, pero igual también cuenta.\n");


        }

        public static void ManipuladorString() {
            Console.WriteLine(
             "=== MANIPULACIÓN DE STRINGS EN C# ===\n" +
             "Forjando identidades digitales a partir de texto...\n" +
             "- Concatenar + combinar datos: nombre + apellido + año.\n" +
             "- ToUpper()/ToLower(): normaliza para evitar errores.\n" +
             "- Substring() y Replace(): recorta, limpia y da forma al ID.\n" +
             "- PadLeft()/PadRight(): rellena con ceros o caracteres.\n" +
             "Cada carácter cuenta cuando creas una identificación única y segura.\n"
            );

            try
            {
                Console.WriteLine("Daniel Alejandro ID");
                int edad = 21;
                string nombreCompleto = "Daniel Alejandro";
                string anioNacimiento = "2004";
                double estatura = 1.70;
                string idUnico = "010101010-1";
                var hobby = "Programador";

                //Mostrar información formateada
                Console.WriteLine("\nNombre Completo: {0}\nEdad: {1}\nAño de Nacimiento: {2}\nEstatura: {3} m\nID Único: {4}\nHobby: {5}",
                    nombreCompleto.ToUpper(),
                    edad,
                    anioNacimiento,
                    estatura.ToString("F2"),
                    idUnico,
                    hobby.ToLower()
                 );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se ha producido un error: {0}", ex.Message);
            }

            

        }

        public static void EstructuraIF() {
            Console.WriteLine(
                "=== ESTRUCTURA IF EN C# ===\n" +
                "Tu primer filtro lógico en el código.\n" +
                "Sintaxis básica:\n" +
                "if (condicion)\n" +
                "{\n" +
                "    // Código si la condición es verdadera\n" +
                "}\n" +
                "else\n" +
                "{\n" +
                "    // Código si la condición es falsa\n" +
                "}\n" +
                "Piensa en 'if' como la pregunta: ¿se cumple la condición? Según la respuesta, el programa toma un camino u otro.\n"
            );

            try {
                var edad = 0;

                Console.WriteLine("Escribe tu edad:");
                edad = Convert.ToInt32(Console.ReadLine());

                //Estructura IF
                if (edad >= 18 && edad < 60)
                {
                    Console.WriteLine("Eres mayor de edad.");
                }
                else if (edad >= 60)
                {
                    Console.WriteLine("Eres un adulto mayor.");
                }
                else
                {
                    Console.WriteLine("Eres menor de edad.");
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Se ha producido un error: {0}", ex.Message);
            }
            
        }

        public static void EstructuraSwitch() {
            Console.WriteLine(
                "=== ESTRUCTURA SWITCH EN C# ===\n" +
                "El menú de decisiones de tu programa.\n" +
                "Sintaxis básica:\n" +
                "switch (expresion)\n" +
                "{\n" +
                "    case valor1:\n" +
                "        // Código para valor1\n" +
                "        break;\n" +
                "    case valor2:\n" +
                "        // Código para valor2\n" +
                "        break;\n" +
                "    default:\n" +
                "        // Código si no coincide ningún caso\n" +
                "        break;\n" +
                "}\n"
            );

            try {
                var opcion = "";

                //pedir opcion al usuario
                Console.WriteLine("Escribe una opción (A, B, C):");
                opcion = Console.ReadLine();

                switch (opcion) { 
                    case "A":
                        Console.WriteLine("Has seleccionado la opción A.");
                        break;
                    case "B":
                        Console.WriteLine("Has seleccionado la opción B.");
                        break;
                    case "C":
                        Console.WriteLine("Has seleccionado la opción C.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            catch (Exception ex) { 
                Console.WriteLine("Se ha producido un error: {0}", ex.Message);
            }
        }

        public static void EstructuraWhile()
        {
            Console.WriteLine(
                "=== BUCLE WHILE EN C# ===\n" +
                "Cuando necesitas repetir algo mientras una condición sea verdadera.\n" +
                "Sintaxis básica:\n" +
                "while (condicion)\n" +
                "{\n" +
                "    // Código que se ejecuta mientras la condición sea true\n" +
                "}\n" +
                "Úsalo cuando no sabes cuántas veces se repetirá el ciclo, pero sí sabes cuál es la condición de salida.\n"
            );

            try
            {
               var bandera = true;
                var numero = 0;

                while (bandera)
                {
                    Console.WriteLine("El bucle while está en ejecución. Escribe '0' para detenerlo.");
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero == 0)
                    {
                        bandera = false;
                        Console.WriteLine("Bucle detenido.");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Se ha producido un error: {0}", ex.Message);
            }
        }

        public static void EstructuraDoWhile() {
            Console.WriteLine(
                "=== BUCLE DO-WHILE EN C# ===\n" +
                "Perfecto cuando necesitas que el código se ejecute al menos una vez.\n" +
                "Sintaxis básica:\n" +
                "do\n" +
                "{\n" +
                "    // Código que se ejecuta al menos una vez\n" +
                "} while (condicion);\n" +
                "Primero actúa, luego pregunta: ¿seguimos repitiendo?\n"
            );

            try
            {
                var contador = 0;
                do
                {
                    Console.WriteLine("El bucle do-while está en ejecución. Contador: {0}", contador);
                    contador++;
                } while (contador < 5);

                Console.WriteLine("Bucle do-while finalizado.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se ha producido un error: {0}", ex.Message);
            }
        }

        public static void EstructuraFor() {
            Console.WriteLine(
                "=== BUCLE FOR EN C# ===\n" +
                "Ideal cuando sabes exactamente cuántas veces se repetirá el código.\n" +
                "Sintaxis básica:\n" +
                "for (inicializacion; condicion; actualizacion)\n" +
                "{\n" +
                "    // Código que se ejecuta en cada iteración\n" +
                "}\n" +
                "Piensa en el for como: empieza en un punto, avanza mientras se cumpla la condición y actualiza el contador en cada vuelta.\n"
            );

            try { 
                
                for(int i=0; i<5; i++) { 
                    Console.WriteLine("El bucle for está en ejecución. Iteración: {0}", i);
                }

            }catch (Exception ex) { 
                Console.WriteLine("Se ha producido un error: {0}", ex.Message);
            }
        }
    }
}
