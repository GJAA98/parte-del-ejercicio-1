using System;

namespace Practica_numero_mayor
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Inserte un numero:");
                string valor = Console.ReadLine();
                numeros[i] = int.Parse(valor);
            }

            int numeroMayor = 0;
            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] > numeroMayor)
                {
                    numeroMayor = numeros[i];
                }
            }

            Console.WriteLine("Numero mayor:" + numeroMayor);


        }
    }
}
