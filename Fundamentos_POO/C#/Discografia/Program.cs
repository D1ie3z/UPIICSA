//PROGRAMA SENCILLO DE DISCOGRAFIA (SIN CONDICIONALES, NI BUCLES)
using System;

namespace Discografia
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre,grupo; //VARIABLES DE LOS NOMBRES
            string[] discografia = new string[] { "Rust in peace", "Countdown Extinction", "Youthanasia", "Peace Sells"}; //ARREGLO QUE GUARDA LA DISCOGRAFIA (REDUCIDA A 4)
            Console.WriteLine("Digita tu nombre:"); //PIDE EL NOMBRE
            nombre=Console.ReadLine();
            Console.WriteLine("Digita tu grupo favorito:"); //PIDE GRUPO
            grupo=Console.ReadLine();
            Console.WriteLine(nombre + " aquí está la discografia del grupo "+grupo); //IMPRIME EL NOMBRE JUNTO CON EL GRUPO
            /*IMPRIME EL ARRAY DE LA DISCOGRAFIA POR POSICIÓN*/
            Console.WriteLine(discografia[0]);
            Console.WriteLine(discografia[1]);
            Console.WriteLine(discografia[2]);
            Console.WriteLine(discografia[3]);
            /*FIN*/
        }
    }
}
