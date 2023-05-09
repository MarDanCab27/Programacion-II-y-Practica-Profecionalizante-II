using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8_Prac
{

    class Program
{
static void Main(string[] args)
{
Console.WriteLine("Programa para ______________arreglos");
Console.WriteLine("Arreglo de _____________________valores aleatorios entre ___ y ___");
int[] Vector_Conjunto = new int[50];
Random Numero_aleatorio = new Random();
//aqui inicializamos el arreglo con valores aleatorios
for (int i = 0; i < Vector_Conjunto.Length; i++)
Vector_Conjunto[i] = Numero_aleatorio.Next(1, 101); //intervalo cerrado en límite inferior
// intervalo abierto en límite superior
//aqui visualizamos el contenido del arreglo
Console.WriteLine("El contenido del arreglo es: \n\n");

VisualizaArreglo(Vector_Conjunto,);

//buscamos el valor mayor del arreglo
int mayor = EncuentraMayor(Vector_Conjunto);
Console.WriteLine("\nEl valor mayor encontrado es: " +
mayor);
//vamos a identificar las posiciones donde aparece el
número mayor
int[] posicionesDelMayor = BuscaPosicionesValor(mayor,
Vector_Conjunto);
Console.WriteLine("\nEl número mayor está {0} veces en el arreglo " + Vector_Conjunto.Length);
Console.WriteLine("\nLas posiciones donde está el número
mayor son: ");
for (int i = 0; i < _____________________.Length; i++)
Console.WriteLine(posicionesDelMayor[i] + 1); //Posiciones

Práctica Profesionalizante II

//buscamos el valor menor del arreglo
int menor = EncuentraMenor(Vector_Conjunto);
Console.WriteLine("\nEl valor menor encontrado es: " +
menor);
//vamos a identificar las posiciones donde aparece el
número menor
int[] posicionesDelMenor=BuscaPosicionesValor(menor,
_________________);
Console.WriteLine("\nEl número menor está {0} veces en el
arreglo ",
____________________.Length);
Console.WriteLine("\nLas posiciones donde está el número
menor son: ");
for (int i = 10; i < ___________________.Length; i++)
Console.WriteLine(___________________ [i] + 1);
//Posiciones
//ordenamos el arreglo
int[] conjuntoOrdenado =
OrdenaArregloBurbuja(Vector_Conjunto);
//visualizamos el arreglo ordenado
Console.WriteLine("\n\nEl contenido del arreglo ordenado
es: \n\n");

VisualizaArreglo(__________________________);

//solución
int[] otroOrdenado = Vector_Conjunto;
Array.Sort(otroOrdenado);
Console.WriteLine("\n\nEl arreglo ordenado usando
Array.Sort(): \n\n");

VisualizaArreglo(_____________________);

Console.ReadKey();

}

// Función ____________________________
staticint[] OrdenaArregloBurbuja(int[] coleccion)

{

int[] coleccionOrdenada = coleccion;
int datoTemporal;
// implementamos el algoritmo ________________________
bool seHizoCambio = true;
//se repite el ciclo hasta que no se haga cambio
(seHizoCambio = false)
while (seHizoCambio == true)

{

//iniciamos cada ciclo indicando que no se hizo cambio

seHizoCambio = false;

Práctica Profesionalizante II
//recorremos el ciclo para hacer las comparaciones de
dos números adjacentes
for (int i = __; i <_________________.Length - 1; i+)
{
if (coleccionOrdenada[i] >_______________________)

{

//el primero es mayor que el segundo, se
cambian de posición

datoTemporal =______________________;

coleccionOrdenada[i + 1] =
coleccionOrdenada[i];
_____________________= datoTemporal;
//se hizo ordenamiento, se coloca la variable
"bandera" en true
seHizoCambio = true;
}
}
}

Return coleccionOrdenada;

}

//Función _____________________________________
Static int[] BuscaPosicionesValor(int valor, int[]
coleccion)
{

//1.Encontrar la cantidad de posiciones que tienen ese
valor almacenado
int cantidad = 0; // cantidad de posiciones que tienen el
valor buscado
for (int i = 0; i <______________________; i++)
if (coleccion[i] == valor)
cantidad++;
//2. Declarar un arreglo de esa cantidad de posiciones
int[]______________ = new int[_____________];
int ubicacion = 0; //ubicación en arreglo de
posiciones
//cada vez que encuentre una posición
//con el valor requerido, incremento este contador
//3. almacenar cada posición donde está el valor
requerido
for (int i = ; i < coleccion.Length; i++)
{
if (coleccion[i] = valor)

{
posiciones[ubicacion] = i;

_________________;

}
}

//finalmente, devolvemos el arreglo
return posiciones;

}

Práctica Profesionalizante II

// Función _____________________________
Static int EncuentraMayor(int[] coleccion)

{

int datoMayor = coleccion[0]; //arbitrariamente decimos que
el primer elemento
//es el mayor de los valores del arreglo
//aqui comparamos ese mayor a ver si hay otro mayor
for (int i = 0; i < coleccion.Length; i++)
if (______________ > _______________)
datoMayor = coleccion[i]; //se encontró un nuevo
mayor
return datoMayor;

}

// Función ____________________________________
Static int EncuentraMenor(int[] coleccion)

{

int datoMenor = coleccion[0]; //arbitrariamente decimos que
el primer elemento
//es el mayor de los valores del arreglo
//aqui comparamos ese mayor a ver si hay otro mayor
for (int i = 0; i < coleccion.Length; i++)
if (coleccion[i] < datoMenor)
____________ = ____________; //se encontró un nuevo
mayor
return datoMenor;

}

// funcion __________________________________
Static void VisualizaArreglo(int[] coleccion)
{
for (int____; i <_______________ ; ____)

{

Console.Write(coleccion[i] + "\t");
//si ya coloqué 10 numeros, salto de linea
if ((i + 1) % 10 == __)
Console.WriteLine();

}
}
}
}

}
