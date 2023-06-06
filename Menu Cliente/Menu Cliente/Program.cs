using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Cliente
{

    class Program
    {


        //Se declaran los tipos de 
        //datos propios para ahorrar trabajo xd


        public struct proveedor
        {

            public int caracteristicas;
            public int numTel;
            public string Empresa;
            public double importe;
            public string fecha;

        }

        public struct user
        {

            public string nombre;
            public string password;
        }

        static void Main(string[] args)
        {
            //Se declara el vector de user 
            user[] usuarios = new user[3];
            //Se inicializa el vector
            usuarios[0].nombre = "Marcelo";
            usuarios[0].password = "Marcelo123";
            usuarios[1].nombre = "Juan";
            usuarios[1].password = "Juanito777";
            usuarios[2].nombre = "Emir";
            usuarios[2].password = "Emirates";
            //Se lee un usurio y su contraseña
            user ingreso;
            ingreso.nombre = Console.ReadLine();
            ingreso.password = Console.ReadLine();
            //Se comprueba que el usuario sea correcto
            
            string[] ventas = new string[50];
            if (comprobar_contra(usuarios, ingreso)) 
            {
                int opcion;
                Menu();
                Console.WriteLine("Ingrese una opcion:");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion){
                    case 1:
                        recargar(ventas,ingreso);
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                }

            }
            recargar(ventas,ingreso);


            Console.Read();
        }

        public static void recargar(string[] vector, user operador)
        {
            proveedor aux;
            for (int i = 0; i < vector.Length; i++)
            {
                string elije;
                elije = Console.ReadLine();
                if (elije == "C" || elije == "c")
                {

                    Console.WriteLine("Ingrese la caracteristica");
                    aux.caracteristicas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese numero de telefon");
                    aux.numTel = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la empresa");
                    aux.Empresa = Console.ReadLine();
                    Console.WriteLine("Ingrese el importe");
                    aux.importe = double.Parse(Console.ReadLine());
                    aux.fecha = DateTime.UtcNow.ToString("yy-mm-dd");//Esto lo copie de internet
                    vector[i] = (operador.nombre + " | " + aux.caracteristicas + "-" + aux.numTel + " | " + aux.Empresa + " | " + aux.importe + " | " + aux.fecha);
                }

            }
        }

        public static bool comprobar_contra(user[] v, user aux)
        {
            bool bandera = false;
            //Console.WriteLine(aux.nombre + " " + aux.password);
            for (int i = 0; i < v.Length; i++)
            {
                //Console.WriteLine(v[i].nombre + v[i].password);

                if (v[i].nombre == aux.nombre && v[i].password == aux.password)
                {
                    bandera = true;
                    break;
                }

            }
            return bandera;
        }

        public static void Menu()
        {
            Console.WriteLine("***************");
            Console.WriteLine("* 1 Recargar  *");
            Console.WriteLine("* 2 Reporte V.*");
            Console.WriteLine("* 3 Salida    *");
            Console.WriteLine("***************");

        }


    }


}


