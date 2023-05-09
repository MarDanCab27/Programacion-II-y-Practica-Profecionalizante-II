using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vector
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vec = new int[10];
            for (int i = 0; i < 10; i++) {
 
                vec[i]=int.Parse(Console.ReadLine());

            }
            Console.Clear();
            for(int i = 0; i < 10; i++){
            
                Console.WriteLine("[" + vec[i] + "]");
            
            }
            Console.Read();
        }
    }
}
