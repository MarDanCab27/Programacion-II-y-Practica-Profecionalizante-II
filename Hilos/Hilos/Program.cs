﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(WriteY);
            t.Start();
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("x");
            }
            Console.Read();
        }
        static void WriteY() 
        {
            for (int i = 0; i < 1000; i++) { Console.Write("y"); }
        }
    }
}
