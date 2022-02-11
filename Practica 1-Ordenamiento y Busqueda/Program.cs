using System;

namespace Practica_1_Ordenamiento_y_Busqueda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE LA CANTIDAD DE PERSONAS => ");
            int tamaño = int.Parse(Console.ReadLine());

            Persona[] listaPersonas = new Persona[tamaño];

            for(int i = 0; i < tamaño; i++)
            {
                Persona miPersona = new Persona();
                Console.Write("Nombre: ");
                miPersona.Nombre = Console.ReadLine();
                Console.Write("Edad: ");
                miPersona.Edad = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------");
                listaPersonas[i] = miPersona;
            }

            Console.WriteLine("LISTA DE PERSONAS");
            for (int j = 0; j < listaPersonas.Length; j++)
            {
                Console.WriteLine("Nombre: " + listaPersonas[j].Nombre + " | Edad: " + listaPersonas[j].Edad);
            }
            ElMenor(listaPersonas);
            OrdenNombre(listaPersonas);
            OrdenEdad(listaPersonas);
            Console.ReadKey();
        }

        static void ElMenor(Persona[] listaPersonas)
        {
            int menor = listaPersonas[0].Edad;
            int posMenor = 0;
            for (int i = 1; i < listaPersonas.Length; i++)
            {
                if(listaPersonas[i].Edad < menor)
                {
                    posMenor = i;
                    menor = listaPersonas[i].Edad;
                }
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("La persona con menor edad es : " + listaPersonas[posMenor].Nombre + " | " +listaPersonas[posMenor].Edad + " años");
        }

        static void OrdenNombre(Persona[] listaPersonas)
        {
            for(int i = listaPersonas.Length - 1; i > 0; i-- )
            {
                for (int j = 0; j < i ; j++)
                {
                    if(listaPersonas[j].Nombre.CompareTo(listaPersonas[j+1].Nombre) > 0)
                    {
                        Persona temp = listaPersonas[j];
                        listaPersonas[j] = listaPersonas[j + 1];
                        listaPersonas[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("ORDENADO POR NOMBRE");
            for (int j = 0; j < listaPersonas.Length; j++)
            {
                Console.WriteLine("Nombre: " + listaPersonas[j].Nombre + " | Edad: " + listaPersonas[j].Edad);
            }
        }
        static void OrdenEdad(Persona[] listaPersonas)
        {
            for (int i = listaPersonas.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (listaPersonas[j].Edad > listaPersonas[j + 1].Edad)
                    {
                        Persona temp = listaPersonas[j];
                        listaPersonas[j] = listaPersonas[j + 1];
                        listaPersonas[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("ORDENADO POR EDAD");
            for (int j = 0; j < listaPersonas.Length; j++)
            {
                Console.WriteLine("Nombre: " + listaPersonas[j].Nombre + " | Edad: " + listaPersonas[j].Edad);
            }
        }
    }

    class Persona 
    {
        public string Nombre;
        public int Edad;
    }
}