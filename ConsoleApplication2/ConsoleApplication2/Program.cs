using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        { /*vendedor=cod,nomap,comi*/

            vendedor vendedorPrueba= new vendedor();
            /* tiene el mismo nombre que la clase, es el metodo que se ejecuta primero, se ejecuta en forma automatica
             no puede retornar datos, se ejecuta una unica vez, gerelmente el constructor tiene como objetivo inicializar los 
             atributos*/
        }
    }
    class vendedor{

        private string[,] vendedores = new string[3,3];
        
       

       
        public void vendedor() {

            for (int i = 0; i < 3; i++) {
                vendedores[i, 0] = i.ToString();
                    Console.Write("Ingrese el nombre del vendedor");
                    vendedores[i,1]= Console.ReadLine();
                    Console.Write("Ingrese la comision del vendedor");
                    vendedores[i, 2] = Console.ReadLine();

            }
        }
 
        

    }
}
