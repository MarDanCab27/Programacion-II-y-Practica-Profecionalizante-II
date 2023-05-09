using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_4_4_23_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Estructura while";
            int cont = 0;
            double nota, prom, acu = 0;
            while(cont < 5 ){

                Console.WriteLine("Ingrese ingrese una nota: ");
                nota = double.Parse(Console.ReadLine());
                acu = nota + acu;
                cont++;
            }
            prom = acu / (cont );
            Console.WriteLine("El promedio de notas es: " + prom);
            Console.Read();
        }
    }
}
