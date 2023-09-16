using System;


namespace Global
{

    class world
    {
        public static void Main()
        {
            double y, x, z, fi;


            Console.WriteLine("Введите значение z");
            z = Convert.ToDouble(Console.ReadLine());
            if (z < 1)
            {
                x = z * z;
                Console.WriteLine("x=z*z");
            }
            else
            {
                Console.WriteLine("x=Z+1");
                x = z + 1;
            }

            Console.WriteLine("Выберите значение ф(x): 1-2x; 2-x^2; 3-x/3");

            int var = Convert.ToInt32(Console.ReadLine());

            if (var == 1)
            {
                fi = 2 * x;
            }
            else if (var == 2)
            {
                fi = x * x;
            }
            else
            {
                fi = x / 3;
            }

            y = Math.Log(1 + Math.Pow(x, 1 / 5)) + Math.Pow(Math.Cos(fi + 1), 2);


            Console.WriteLine(y);

        }

    }

}