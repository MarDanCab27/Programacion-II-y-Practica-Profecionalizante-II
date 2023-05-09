using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad_2_programacion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.SetCursorPosition(4, 2);
            Console.WriteLine("Ingrese n1: ");
            Console.SetCursorPosition(17, 2);
            n1 = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(4, 4);
            Console.WriteLine("Ingrese n2: ");
            Console.SetCursorPosition(17, 4);
            n2 = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("Ingrese n3: ");
            Console.SetCursorPosition(17, 6);
            n3 = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(4, 10);
            if (n1 > n2 & n1 > n3)
            {
                Console.WriteLine("El numero mayor es: " + n1);
                Console.Read();
            }
            else if (n2>n1 & n2>n3) {
                Console.WriteLine("El numero mayor es: " + n2);
                Console.Read();
            }
            else if (n3 > n1 & n3 > n2) {
                Console.WriteLine("El numero mayor es: " + n3);
                Console.Read();            
            }
            

        
        }
    }
}
