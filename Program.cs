using System;

namespace T05Ejercicio18
{
    class Program
    {
        static void Main()
        {
            int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("¿Qué longitud (entero positivo) quiere para el array?: ");
            int longitud = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] array = new int[longitud];

            ValoresRandom(array, numeros);
            Console.WriteLine();
            MuestraySuma(array);
        }

        static void ValoresRandom(int[] array, int[] numeros)
        {

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = numeros[GenerarRandom(numeros)];
            }
        }

        static void MuestraySuma(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("El {0}º valor del array es: {1}", i + 1, array[i]);
            }
            Console.WriteLine("La suma de todos los valores del array es: " + array.Sum());
        }

        private static int GenerarRandom(int[] numeros)
        {
            Random rnd = new Random();
            int aleatorio = rnd.Next(0, numeros.Length);
            return aleatorio;
        }
    }
}