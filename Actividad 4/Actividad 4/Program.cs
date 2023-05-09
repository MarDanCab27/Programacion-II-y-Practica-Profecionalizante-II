using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    class Program
    {
        public struct cuentas
        {

            public int nc;
            public double saldo;

        }

        public static void carga_vec(cuentas[] v)
        {

            for (int i = 0; i < v.Length; i++)
            {
                string linea;
                Console.WriteLine("Ingrese el nuemro de cuenta:");
                linea = Console.ReadLine();
                v[i].nc = int.Parse(linea);

                Console.WriteLine("Ingrese el saldo:");
                linea = Console.ReadLine();
                v[i].saldo = double.Parse(linea);
                estadoCuen(v[i], v.Length);

            }
        }

        public static void estadoCuen(cuentas vec, int cant)
        {


            if (vec.saldo > 0)
            {

                Console.WriteLine("Acreedor");

            }
            else if (vec.saldo < 0)
            {

                Console.WriteLine("Deudor");


            }
            else
            {

                Console.WriteLine("Nulo");

            }




        }

        static void Main(string[] args)
        {
            int cant;
            Console.WriteLine("Ingrese la cantidad de cuentas con las que quiere operar");
            cant = int.Parse(Console.ReadLine());
            cuentas[] vec = new cuentas[cant];
            carga_vec(vec);
            Console.Read();



        }



    }
}
