using System;


namespace Global
{
    class World
    {
        public static void Error()
        {

        }



        public static void Main()
        {

            int count = 0;

            while (count == 0)
            {
                Console.WriteLine("Введите размер массива");
                count = Convert.ToInt32(Console.ReadLine());
            }
            int[] array = new int[count];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите {i} элемент массива");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max, min, fmax = 0, fmin = 0, sum = 0;

            max = array[0];
            min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    fmax = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    fmin = i;
                }
            }


            if (fmax < fmin)
            {
                sum = fmax;
                fmax = fmin;
                fmin = sum;
            }

            if (fmin == fmax) Console.WriteLine("максимальное и минимальное совпадают");

            bool exit = false;


            for (int i = 0; i < array.Length; i++)
            {
                if (exit == true) break;
                if (array[i] == max || array[i] == min)
                {
                    for (int j = fmin + 1; j < Math.Abs(fmax - fmin); j++)
                    {
                        sum += array[j];
                        exit = true;
                    }
                }
            }


            Console.WriteLine($"Сумма чисел между максимальным и минимальным значением равна {sum}");
        }
    }
}