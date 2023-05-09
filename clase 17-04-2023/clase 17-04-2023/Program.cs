using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_17_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz = new int [3, 4];
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 4; j++) {

                    matriz[i, j] = int.Parse(Console.ReadLine()); 

                }
            
            }


        }
    }
}
