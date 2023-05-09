using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descuentos
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion;
            DateTime fecha;
            double precioProducto;
            double descuento = 0;
            double total;
            double importeDescuento;

            Console.WriteLine("Ingrese la fecha de compra (dd/mm/aaaa)");

            if (DateTime.TryParse(Console.ReadLine(), out fecha){
            
                if ((int)fecha.DayOfWeek == 6){
  
                    descuento+=3;
                
                }
                else if((int)fecha.DayOfWeek ==0) {

                    descuento+=5;                

                }else {
                
                    descuento+=8;

                }
            
            }

            Console.WriteLine("Opcion || 1: Electrodomesticos || 2: Comestibles || 3: Ferrteria ");
            Console.WriteLine("Ingrese una opcion");
            
            if (int.TryParse(Console.ReadLine(), out opcion){
            
                if (opcion == 1){
                
                    descuento+=2;
                }else if (opcion == 2){
                
                    descuento+=5;

                }else if (opcion == 3){
                
                    descuento+=4;

                }else {

                    Console.WriteLine("Ingrese una opcion correcta.");
                    Console.ReadKey();
                    Environment.Exit(1);
                
                }
            }

            Console.Write("Ingrese precio del producto: ");
            precioProducto = double.Parse(Console.ReadLine());
            importeDescuento = Math.Round((precioProducto * (descuento/100)),4);
            total = precioProducto - importeDescuento;
            Console.WriteLine("El importe final es:");
            Console.WriteLine("Precio:" + precioProducto.ToString());
            Console.WriteLine("Descuento: (" + descuento + "%):" + importeDescuento.ToString() );
            Console.WriteLine("Total: " + total.ToString());
            Console.ReadKey();
        }


    
    }
}
