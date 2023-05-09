using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_4_4_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Programacion II - 2023 - Utilizando la estructura FOR";
            double cubo;
            int cantidad;
            Console.WriteLine("Calculo de cubo");
            for (int i = 0; i < 5; i++) {

                Console.WriteLine("Escriba un numero entero: ");
                cantidad = int.Parse(Console.ReadLine());
                cubo = potencia(cantidad, 3);
                Console.WriteLine("El cubo de la cantidad es: " + cubo);

            }

            Console.WriteLine("Saliendo del programa...");
            Console.Read();
        }
        static double potencia(int c1, int c2) {
            return Math.Pow(c1, c2);
        }
    }
}
