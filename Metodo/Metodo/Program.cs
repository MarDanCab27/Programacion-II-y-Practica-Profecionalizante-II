using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************");
            Console.WriteLine(alea());
            Console.WriteLine("******************");
            Console.ReadLine();
        }
        static int alea(){
           
        Random azar = new Random();

        return azar.Next(0, 100);

        }
    }
}
