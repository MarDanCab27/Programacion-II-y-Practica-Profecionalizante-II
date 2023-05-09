using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_en_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            float notas = 0, prom, c ,acu=0;
            Console.WriteLine("Defina la cantidad de notas que va a cargar:");
            c = float.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++) {

                Console.WriteLine("ingrese la nota " + (i+1) + ": ");
                notas = float.Parse(Console.ReadLine());
                acu = notas + acu;
            }
            prom = acu / c;
            Console.WriteLine("El promedio es: " + prom);

            Console.Read();
        }
    }
}
