using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_4_4_23_3
{
    class Program
    {
         struct empleados {

            public string nombre;
            public double sueldo;

        }
        static void Main(string[] args)
        {

            Console.Title = "Do while y ciclo for";
            double acu = 0;
            int c = 0;
            string opcion;
            empleados emplea3;
            

            do
            {
                Console.WriteLine("Cargue un empleado");

                opcion = Console.ReadLine();

                Console.WriteLine("Ingrese el nombre del empleado: ");

                emplea3.nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el sueldo del empliau: ");

                emplea3.sueldo = double.Parse(Console.ReadLine());

                acu += emplea3.sueldo;

                Console.WriteLine("Desea seguir cargando empleados? (para continuar la carga presione 'C' si quiere finalizar 'F' o 'f'");
                opcion = Console.ReadLine();

                c++;

            } while ((opcion != "f") && (opcion != "F"));
;

            Console.WriteLine("El total de los sueldos que debe pagar es de :" + acu);

        }
    }
}
