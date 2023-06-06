using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public struct cliente { 

            public string nombre;
            public string cuil;
            public string telefono;
            public double saldo;
            public int cod;

        }
        static void Main(string[] args)
        {



        }
        public static void cargar_cliente(cliente ingresa, cliente[]vec){
           
            vec.ToArray();
            Array.Resize(ref vec, vec.Length + 1);
            Console.Write("Ingrese nombre del cliente: ");
            vec[vec.Length - 1].nombre = Console.ReadLine();
            Console.Write("Ingrese cuil del cliente: ");
            vec[vec.Length - 1].cuil = Console.ReadLine();
            Console.Write("Ingrese telefono: ");
            vec[vec.Length - 1].telefono = Console.ReadLine();
            vec[vec.Length - 1].saldo = 0.0;
            vec[vec.Length - 1].cod = vec.Length;

            }
/*        public static void modificar_cliente(cliente[] vec, int buscado){
             
            int opcion;
            opcion =  int.Parse(Console.ReadLine());
           if ()
            switch (opcion)
            {
                case 1: 
                default:  
                    break;
            }

            }*/

        }

    }
}
