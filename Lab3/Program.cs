using System;
using System.Runtime.CompilerServices;

namespace Global
{


    class Start
    {

        public static int Factorial(int k)
        {
            int fact = 1;
            int n = 2 * k + 1;
            for (int i = 2; i < n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }


        public static void Main()
        {

            double a, b, h, x, sum, rez, razn;
            int n, var;


            Console.WriteLine("Нажмите 1 для использования тестовых значений");

            var = Convert.ToInt32(Console.ReadLine());
            if (var == 1)
            {
                a = 0.1;
                b = 1.0;
                h = 0.1;
            }
            else
            {
                Console.WriteLine("Введите a");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите b");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите h");
                h = Convert.ToDouble(Console.ReadLine());
            }


            Console.WriteLine("Введите n");
            n = Convert.ToInt32(Console.ReadLine());
            x = a;


            Console.WriteLine("sum" + '\t' + "Y(x)");
            for (int k = 0; k < n; k++)
            {
                x += h;

                sum = Math.Pow(-1, k) * Math.Pow(x, 2 * k + 1) / Factorial(k);
                rez = Math.Sin(x);
                razn = Math.Abs(rez - sum);

                Console.WriteLine($"{sum} \t\t\t\t\t {rez} \t\t\t {razn}");
                //  Console.Write("\t");
                //Console.Write(rez = Math.Sin(x));
            }



            //for (int k = 0; k < n; k++)
            //{
            //    x += h;
            //    Console.Write(sum = Math.Pow(-1, k) * Math.Pow(x, 2 * k + 1) * Factorial(k));
            //    //  Console.Write("\t");
            //    Console.Write(rez = Math.Sin(x));
            //}


        }
    }
}