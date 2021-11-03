
using System;

namespace POO_Discografia
{
    class Program
    {
        static void Main(string[] args)
        {
            string minombre, nombreg;
            Console.WriteLine("Ingresa tu nombre:");
            minombre= Console.ReadLine(); 
            Console.WriteLine("Ingresa tu grupo favorito:");
            nombreg= Console.ReadLine();
            //CREAMOS LOS OBJETOS g
            Grupo g = new Grupo("Rust in peace");
            Grupo g1 = new Grupo("Youthanasia");
            Grupo g2 = new Grupo("Peace Sells");
            Grupo g3 = new Grupo("Killing is my business");
            //IMPRIMIMOS LOS RESULTADOS
            Console.WriteLine(minombre + " aquí está la discografia del grupo " + nombreg);
            Console.WriteLine("*********DISCOGRAFIA************");
            Console.WriteLine(g.ToString()); //ESTE ToString() es el de la clase Grupo 
            Console.WriteLine(g1.ToString());
            Console.WriteLine(g2.ToString());
            Console.WriteLine(g3.ToString());
            Console.WriteLine("Presione Enter...");
            Console.ReadLine();
        }
    }
}
