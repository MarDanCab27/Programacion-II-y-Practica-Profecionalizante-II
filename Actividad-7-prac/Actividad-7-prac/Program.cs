using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_7_prac
{
    class Program
    {
        public struct cliente
        {

            public string apellidoNombre;
            public string cuit;
            public string sitImp;
            public double saldo;

        }
        static void Main(string[] args)
        {
            cliente[] prueva = new cliente[2];
            cargar(prueva);
            listado(prueva);
            busquedaxcuit(prueva, "23411199649");
            Console.Read();

        }

        public static void listado(cliente[] m)
        {

            for (int i = 0; i < m.Length; i++)
            {

                Console.WriteLine(m[i].apellidoNombre + " - " + m[i].cuit + " - " + m[i].sitImp + " - " + m[i].saldo);

            }

        }



        public static void busquedaxcuit(cliente[] v, string buscado)
        {

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i].cuit == buscado)
                {
                    Console.WriteLine("El cliente fue econctrado con exito :D");
                    Console.WriteLine(v[i].apellidoNombre + " - " + v[i].cuit + " - " + v[i].sitImp + " - " + v[i].saldo);
                }
            }

        }


        public static void cargar(cliente[] vec) {
            int opcion = 0;
            for (int i = 0; i < vec.Length; i++) {

                Console.WriteLine("Ingrese el nombre y apellido del cliente");
                vec[i].apellidoNombre = Console.ReadLine();
                Console.WriteLine("Ingrese el cuit del cliente");
                vec[i].cuit = Console.ReadLine();
                Console.WriteLine("Ingrese la situacion impositiva del cliente: (1-Cons.Final, 2-Monotributo, 3-Res. Inscripto, 4-Exento, 5-No Categorizado");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        vec[i].sitImp = "Consumidor final";
                        break;
                    case 2:
                        vec[i].sitImp = "Monotributista";
                        break;
                    case 3:
                        vec[i].sitImp = "Resp. Inscripto";
                        break;
                    case 4:
                        vec[i].sitImp = "Excento";
                        break;
                    case 5:
                        vec[i].sitImp = "No Categorizado";
                        break;
                    default:
                        vec[i].sitImp = "";
                        break;
                }

                Console.WriteLine("Ingrese el saldo del cliente");
                vec[i].saldo = double.Parse(Console.ReadLine());
            }
            
        }

    }
}
