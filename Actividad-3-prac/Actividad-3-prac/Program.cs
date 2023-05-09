using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3_prac
{
    class Program
    {
        class Act_Matriz // Clase
        {
            private string[] empleados;
            private double[,] sueldos;
            private double[] totalsueldos;
        }
        public void Cargar()
    {
        string[] empleados= new string[4];
        double[,] sueldos = new double[4, 3];

        Console.Title = "Práctica Profesionalizante II - Métodosen C# y uso de un procedimiento";

        for (int f = 0; f < empleados.Length; f++)
        {
        Console.Write("Ingrese el nombre del empleado:");
        empleados[f] = Console.ReadLine();
        for (int c = 0; c < sueldos.GetLength(1); c++)
           {
                Console.Write("Ingrese sueldo:");
                string linea;
                linea = Console.ReadLine();
                sueldos[f, c] = double.Parse(linea);
                }
          }
          }
        public void CalcularSumaSueldos(double[,] sueldos)
        {
            double[] totalsueldos = new double[4];
            for (int f = 0; f < sueldos.GetLength(0); f++)
            {
                double suma = 0;
                for (int c = 0; c < sueldos.GetLength(1); c++)
                {
                    suma = suma + sueldos[f, c];
                }
            }
        }
       static void Main(string[] args)
        {
        }
    }
}
