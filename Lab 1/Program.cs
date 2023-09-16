using System;


namespace Code
{
    class Code
    {



        public static void Main()
        {

            double x, y, z;

            Console.WriteLine("hello world");


            Console.WriteLine("Напишите 1 чтобы использовать тестовые значения");


            bool test = true;

            if (Convert.ToInt32(Console.ReadLine()) != 1)
            {
                test = false;
            }

            if (test)
            {
                x = 14.26;
                y = -1.22;
                z = 3.5 * Math.Pow(10, -2);
            }


            else
            {
                Console.WriteLine("Введите x");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите y");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите z");
                z = Convert.ToInt32(Console.ReadLine());
            }


            double rez;

            rez = (2 * Math.Cos(x - Math.PI / 6)) / (0.5 + Math.Pow(Math.Sin(y), 2)) * 1 + z * z / 3 - z * z / 5;

            Console.WriteLine(rez);





        }
    }


}