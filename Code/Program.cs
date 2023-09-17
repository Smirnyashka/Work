using System;
using System.Text.Json.Serialization;

namespace Global
{
    class World
    {
        public static void Main()
        {
            int stolb, strok;

            Console.Write("Введите число столбцов:");
            stolb= Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число строк");
            strok = Convert.ToInt32(Console.ReadLine());


            int[,] array = new int[stolb, strok];

            for(int i=0; i<stolb; i++)
            {
                for(int j=0; j<strok; j++)
                {
                    Console.Write($"Введите значение элемента {i}{j}: ") ;
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < stolb; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < strok; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
            }



        }
    }
}