using System;

namespace Ejercicio_2___Practica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaOrdenar = new int[10];
            Random r = new Random();
            Console.WriteLine("VALORES GENERADOS");

            for(int i = 0; i < 10; i++)
            {
                listaOrdenar[i] = r.Next(1, 100);
                Console.Write("[" + listaOrdenar[i] + "] ");
            }
            Console.WriteLine();

            for(int x = 0; x < 10; x++)
            {
                for(int y = 0; y < 10; y++)
                {
                    if(listaOrdenar[x] < listaOrdenar[y])
                    {
                        int temp = listaOrdenar[y];
                        listaOrdenar[y] = listaOrdenar[x];
                        listaOrdenar[x] = temp;
                    }
                }
            }

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("LISTA ORDENADA");

            for(int z = 0; z < 10; z++)
            {
                Console.Write("[" + listaOrdenar[z] + "] ");
            }
            Console.ReadKey();
        }
    }
}
