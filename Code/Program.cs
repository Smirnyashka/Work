using System;


namespace Global
{


    class Start
    {

        public static void Factorial(int k)
        {
            k += 2;
        }


        public static void Main()
        {

            double a, b, h,x, sum, rez;
            int n, var;


            Console.WriteLine("Нажмите 1 для использования тестовых значений");

            var = Convert.ToInt32(Console.ReadLine());
            if(var == 1)
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

            for(int k=0; k<n; k++)
            {
                x += h;
                sum = Math.Pow(-1, k) * Math.Pow(x, 2 * k + 1) * Factorial(k);
            }




        }
    }
}