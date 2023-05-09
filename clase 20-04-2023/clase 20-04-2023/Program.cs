using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_20_04_2023
{
    class Program
    {

        static void Main(string[] args)
        {
            int cant;
            Console.WriteLine("ingrese la cantidad de empleados");
            cant = int.Parse(Console.ReadLine());
            string[] empleado = new string[cant];
            double[,] sueldos = new double[empleado.Length, 4];
            carga(sueldos, empleado);
            sumaSueldos(sueldos);
            mostrar(sueldos, empleado);
        }

        public static void mostrar(double[,] mat, string[] vec) {

            for (int i = 0; i < mat.GetLength(0); i++) {
                Console.WriteLine(vec[i]);

                for (int j = 0; j < mat.GetLength(1); j++) {

                    Console.WriteLine(mat[i, j]);

                }

            }

        }

        public static void sumaSueldos(double[,] matrix)
        {
            
            double acu=0;
            int k = (matrix.GetLength(0) - 1);

            for (int i = 0; i < matrix.GetLength(1); i++ )
            {
                for (int j = 0; j < k; j++)
                {
                    acu = acu + matrix[k, i];
                    matrix[k, i] = acu;

                }


            }

        }



        public static void carga(double[,] mat, string[] vec)
        {

            for (int i = 0; i < mat.GetLength(0); i++)
            {

                Console.WriteLine("Ingrese el nombre del empleado " + (i + 1) + ":");
                vec[i] = Console.ReadLine();

                for (int j = 0; j < mat.GetLength(1) - 1; j++)
                {

                    Console.WriteLine("Ingrese el sueldo del empleado" + vec[i] + ":");
                    mat[i, j] = double.Parse(Console.ReadLine());
                }
            }

        }
    }
}
