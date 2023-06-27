using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {

            cliente[] listado = new cliente[0];

            Menu(1);
            Console.Read();
        }

        public static void Menu(int op)
        {

            switch (op)
            {
                case 1: Console.WriteLine("*************************** \n" + "*************************** \n" + "***1-Clientes************** \n" + "***2-Produtos************** \n" + "*************************** \n" + "*************************** ");
                    break;

                case 2:
                    Console.WriteLine("*************************** \n" + "*************************** \n" + "***1-Clientes************** \n" + "***2-Produtos************** \n" + "*************************** \n" + "*************************** ");
                    break;
                default: break;
            }

        }

        class cliente
        {

            private string nombre;
            private string cuil;
            private string telefono;
            private double saldo;
            private int cod;

            public cliente()
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

            public void cargar_vec(cliente[] vec)
            {
                for (int i = 0; i < vec.Length; i++)
                {
                    vec[i].setCod(i);
                    Console.Write("Ingrese un nombre");
                    vec[i].setNombre(Console.ReadLine());
                    Console.Write("Ingrese el cuil");
                    vec[i].setCuil(Console.ReadLine());
                    Console.Write("Ingrese Telefono");
                    vec[i].setTelefono(Console.ReadLine());
                }


            }

        }



    }

}
