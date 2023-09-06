using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_practica_prof
{
    
    class Program
    {

        static void Main(string[] args)
        {
            
            cliente[] listado = new cliente[1];
            producto[] catalogo = new producto[1];
            bool salir = false;
            
            while (!salir)
            {
                Console.WriteLine("SISTEMA GESTION IMPRECION 3D");
                Console.WriteLine("1. Agregar Cliente");
                Console.WriteLine("2. Agregar Producto");
                Console.WriteLine("3. Consultar Clientes");
                Console.WriteLine("4. Consultar Productos");
                Console.WriteLine("5. Factura");
                Console.WriteLine("6. Salir");
                Console.WriteLine("Elige una de las opciones");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Has elegido Cargar Cliente");
                        Console.WriteLine("Ingrese la cantidad de cliente que quiere cargar: ");
                        Array.Resize(ref listado, (int.Parse(Console.ReadLine())));
                        cargar_vec_cliente(listado);
                       
                        break;

                    case 2:
                        Console.WriteLine("Has elegido Cargar Producto");
                        Console.WriteLine("Ingrese la cantidad de cliente que quiere cargar: ");
                        Array.Resize(ref catalogo, (int.Parse(Console.ReadLine())));
                        cargar_vec_producto(catalogo);
                        break;

                    case 3:
                        Console.WriteLine("Has elegido Consultar Clientes");
                        mostrar_clientes(listado);
                        break;
                    case 4:
                        Console.WriteLine("Has elegido consultara Productos");
                        mostrar_productos(catalogo);

                        break;

                    case 5:
                        hacer_factura(listado, catalogo);
                        break;
                    case 6:
                        Console.WriteLine("Has elegido salir de la aplicación");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Elige una opcion entre 1 y 4");
                        break;
                }
            }
        }

        public static void hacer_factura(cliente[] lis, producto[] cat) {

            producto[] carrito = new producto[cat.Length];
            Console.WriteLine("Ingrese el codigo de cliente");
            int buscado=int.Parse(Console.ReadLine());
            Console.WriteLine(lis[buscado-1].getCod() + " " + lis[buscado-1].getNombre());

            Console.WriteLine("Ingrese el codigo del aticulo");
            buscado = int.Parse(Console.ReadLine());
            for (int j = 0; j < carrito.Length; j++) {
                carrito[j] = new producto();
                if (buscado-1 == cat[j].getCod()) {
                    carrito[j] = cat[j];

                }
                
            }
            Console.WriteLine("\n FACTURA ");
            Console.WriteLine(lis[buscado-1].getCod() + " " + lis[buscado-1].getNombre());
            mostrar_productos(carrito);
            double suma=0;
            for (int k = 0; k < carrito.Length; k++) {
                suma+=carrito[k].getPrecioFinal();
            }
            Console.WriteLine("TOTAL: $" + suma);
        }
        public static void mostrar_productos(producto[] vec)
        {
            for (int i = 0; i < vec.Length; i++) {

                Console.WriteLine("|" + vec[i].getCod() + "| " + vec[i].getNombreP() + "|" + vec[i].getPrecioFinal() + " |" + vec[i].getGramos() + "|" + vec[i].getHoras() + "|");

            }

        } 

        public static void mostrar_clientes(cliente[] vec) {
            Console.WriteLine("los datos estan dispuestos de la siguiente manera: codigo, nombre, cuil, saldo");
            for (int i = 0; i < vec.Length; i++) {

                Console.WriteLine("|" + vec[i].getCod() + "| " + vec[i].getNombre() + " | " + vec[i].getCuil() + "|" + vec[i].getSaldo());

            }    

        }

        public static void cargar_vec_cliente(cliente[] vec)
        {

 
            for (int i = 0; i < vec.Length; i++) {

 
                vec[i] = new cliente();


                vec[i].setCod(i);
                Console.WriteLine("Ingrese un nombre:");
                vec[i].setNombre(Console.ReadLine());
                Console.WriteLine("Ingrese un cuil: ");
                vec[i].setCuil(Console.ReadLine());
                Console.WriteLine("Ingrese saldo inicial: ");
                vec[i].setSaldo(double.Parse(Console.ReadLine()));

            }

        }
        
        public static void cargar_vec_producto(producto[] vec) { 
            
            for(int i = 0; i<vec.Length; i++){

                vec[i] = new producto();

                vec[i].setCod(i);
                Console.WriteLine("Ingrese nombre del producto: ");
                vec[i].setNombreP(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de gramos que gasta el producto");
                vec[i].setGramos(double.Parse(Console.ReadLine()));
                Console.WriteLine("Ingrese las hs que tarda el prodcto");
                vec[i].setHoras(double.Parse(Console.ReadLine()));
                vec[i].setPreciofinal();
            }   

        }
  
    }

   
    class producto
    {

        private int cod;
        private string nombrep;
        private double gramos;
        private double horas;
        private double preciofinal;

        public producto()
        {
            cod = 0;
            nombrep = "";
            gramos = 0.0;
            horas = 0.0;
            preciofinal = 0.0;
        }
        public producto(string nombrep, double gramos, double horas)
        {

            this.nombrep = nombrep;
            this.gramos = gramos;
            this.horas = horas;
            
        }
        public int getCod() { return cod; }
        public string getNombreP() { return nombrep; }
        public double getGramos() { return gramos; }
        public double getHoras() { return horas; }
        public double getPrecioFinal() { return preciofinal; }
        public void setCod(int cod) { this.cod = cod; }
        public void setNombreP(string nombrep) { this.nombrep = nombrep; }
        public void setGramos(double gramos) { this.gramos = gramos; }
        public void setHoras(double horas) { this.horas = horas; }
        public void setPreciofinal() {

            preciofinal = (2 * ((horas * 42.6275) + (gramos * 5.217)));
            //Calculo precio final Ganancia((horas de imprecion*precio Kw/h)+(gramos de filamento * precio g filamento))

        }
    }

    class cliente {

        private int cod;
        private string nombre;
        private string cuil;
        private double saldo;

        public cliente() {

            cod = 0;
            nombre = "";
            cuil = "";
            saldo = 0.0;
        }
        public cliente(int Cod, string Nombre, string Cuil, double Saldo) {

            cod = Cod;
            nombre = Nombre;
            cuil = Cuil;
            saldo = Saldo;

        }
        public int getCod() { return cod; }
        public string getNombre() { return nombre; }
        public string getCuil() { return cuil; }
        public double getSaldo() { return saldo; }
        public void setCod(int cod) { this.cod = cod;}
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setCuil(string cuil) { this.cuil = cuil; }
        public void setSaldo(double saldo) { this.saldo = saldo; } 

    }
}
