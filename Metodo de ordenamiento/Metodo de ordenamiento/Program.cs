using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_de_ordenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prueba = new int[5];
            cargar(prueba);
            imprime(prueba);
            Console.WriteLine("---");
            ordenar(prueba);
            imprime(prueba);
            Console.Read();
        }
        public static void imprime(int[] v)
        {

            for (int i = 0; i < v.Length; i++)
            {

                Console.WriteLine("[ " + v[i] + "]");

            }

        }

        public static void cargar(int[] vex)
        {

            for (int i = 0; i < vex.Length; i++)
            {
                Console.WriteLine("Ingrese el elemento " + i + ":");
                vex[i] = int.Parse(Console.ReadLine());
            }

        }



        static void ordenar(int[] arreglo)
        {
            for (int x = 0; x < arreglo.Length; x++)
            {
                for (int i = 0; i < arreglo.Length - 1; i++)
                {
                   
                    if (arreglo[i] < arreglo[i + 1])
                    {
                        int temporal = arreglo[i];
                        arreglo[i] = arreglo[i + 1];
                        arreglo[i + 1] = temporal;
                    }
                }
            }
        }
    }
}
