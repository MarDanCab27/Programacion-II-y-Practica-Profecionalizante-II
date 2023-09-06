using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Menu_2(int op, cliente[] cli, producto[] produc)
        {

            switch (op)
            {
                case 1: Console.WriteLine("*************************** ");
                        Console.WriteLine("*************************** ");
                        Console.WriteLine("***1-Cargar Cliente******** ");
                        Console.WriteLine("***2-Consultar Clietne***** ");
                        Console.WriteLine("*************************** ");
                        Console.WriteLine("*************************** ");
                        Console.WriteLine("*************************** ");
                        int opp = opcion();
                        if (opp == 2) {
                            for (int i = 0; i < cli.Length; i++) {

                                Console.WriteLine("["+ cli[i].getCod() + "]  -" + cli[i].getNombre() + "-  -" + cli[i].getCuil());
                            
                            } 
                            }else if(opp == 1){

                                cargar_vec(cli);
                                    
                                }

                         

                    break;

                case 2:
                    Console.WriteLine("*************************** ");
                    Console.WriteLine("*************************** ");
                    Console.WriteLine("***1-Consultar productos*** ");
                    Console.WriteLine("***2-Cargar productos****** ");
                    Console.WriteLine("*************************** ");
                    Console.WriteLine("*************************** ");
                    
                    break;
                default: break;
            }}


        static void Main(string[] args)
        {
            cliente[] listado = new cliente[5];
            producto[] catalogo = new producto[0];
            Menu();
             
            Menu_2(opcion(), listado, catalogo);
            
            Console.Read();
        }

        public static void cargar_vec(cliente[] vec)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                vec[i].construc();
                vec[i].setCod(i);
                Console.Write("Ingrese un nombre");
                vec[i].setNombre(Console.ReadLine());
                Console.Write("Ingrese el cuil");
                vec[i].setCuil(Console.ReadLine());
                Console.Write("Ingrese Telefono");
                vec[i].setTelefono(Console.ReadLine());

            }


        }

        public static int opcion() 
        {
            int op;
            Console.WriteLine("Ingrese una opcion");
            op = int.Parse(Console.ReadLine());
            return op;

        }
        
        public static void Menu() {
            Console.WriteLine("*************************** ");
            Console.WriteLine("*************************** ");
            Console.WriteLine("***1-Alta Cliente********** ");
            Console.WriteLine("***2-Produtos************** ");
            Console.WriteLine("***3-Ventas**************** ");
            Console.WriteLine("*************************** ");
            Console.WriteLine("*************************** ");
        }
        
        }

            public void cargar_vec_producto(producto[] vec) {

                for (int i = 0; i < vec.Length; i++) { 
                
                    vec[i].setCod(i);
                    Console.WriteLine("ingrese nombre");
                    vec[i].setNombreP(Console.ReadLine());
                    Console.WriteLine("Ingrese Gramos");
                    vec[i].setGramos(double.Parse(Console.ReadLine()));
                    Console.WriteLine("Ingrese Horas");
                    vec[i].setHoras(double.Parse(Console.ReadLine()));
                    
                }    

            }
        }
        class cliente
        {

            private string nombre="";
            private string cuil="";
            private string telefono="";
            private double saldo=0.0;
            private int cod=0;

            public void construc()
            {
                nombre = "";
                cuil = "";
                telefono = "";
                saldo = 0.00;
                cod = 0;
            }

            public cliente(string nombre, string cuil, string telefono, double saldo, int cod)
            {

                this.cod = cod;
                this.cuil = cuil;
                this.telefono = telefono;
                this.saldo = saldo;

            }

            public int getCod() { return cod; }
            public string getCuil() { return cuil; }
            public string getTelefono() { return telefono; }
            public double getSaldo() { return saldo; }
            public string getNombre() { return nombre; }

            public void setCod(int cod) { this.cod = cod; }
            public void setNombre(string nombre) { this.nombre = nombre; }
            public void setTelefono(string telefono) { this.telefono = telefono; }
            public void setCuil(string cuil) { this.cuil = cuil; }
            public void setSaldo(double saldo) { this.saldo = saldo; }

            

        }



    }



