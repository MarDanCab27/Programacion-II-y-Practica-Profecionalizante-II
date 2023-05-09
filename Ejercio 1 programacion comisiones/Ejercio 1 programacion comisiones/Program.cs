using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercio_1_programacion_comisiones
{
    class Program
    {
        static void Main(string[] args)
        {
            double ventas, sueldo ,total, min, max;

            Console.WriteLine("Ingrese el sueldo base del vendedor:");
            sueldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las vnetas de vendedor:");
            ventas = double.Parse(Console.ReadLine());
            min = 1000000;
            max = 3000000;
            if (ventas <= min) { 
                
                total=(sueldo+(ventas*0.03));
                Console.WriteLine("El total a pagar es de: " + (total));
                Console.Read();
            } else if (ventas > min & ventas < max) {
                
                total = (sueldo + (min*0.03)+((ventas-min)*0.04));
                
                Console.WriteLine("El total a pagar es de: " + (total));
                Console.Read();
            } else if (ventas >  max){

                total = ((sueldo * 1.07) + (min * 0.03) + ((ventas - max) * 0.05)+((max-min)*0.04));
                Console.WriteLine("El total a pagar es de: " + (total));
                Console.Read();
            }
            Console.Read();   
        }
    }
}
