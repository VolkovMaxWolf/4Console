using System;

namespace _4console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Задание 1");
                Console.Write("Введите x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите n: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Результат: " + Func(x, n));

                Console.WriteLine("Задание 2");
                Console.Write("b1 = ");
                double b1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("q = "); //знаменатель
                double q = Convert.ToDouble(Console.ReadLine());
                Console.Write("n = "); 
                int n1 = Convert.ToInt32(Console.ReadLine());
                double sum = 0;
                GeometricProgression(b1, q, n1, sum);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static double Func(double x, double n)
        {
            if (n == 0) return 1;
            else if (n < 0) return 1 / Func(x, -n);
            else return x * Func(x, n - 1); 
        }
        private static void GeometricProgression(double b, double q, int n, double sum)
        {
            if (n == 0) return;
            Console.Write(b * q);
            sum += (b * q);
            Console.Write(" sum: " + sum + "\n");
            GeometricProgression(b * q, q, --n, sum);
        }
    }
}
