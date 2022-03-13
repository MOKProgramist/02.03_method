using System;

namespace function_calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите значение a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("введите значение b: ");
            int b = int.Parse(Console.ReadLine());

            double calFun = calculateFun(a, b);
            Console.WriteLine($"Результат отработанной функции: {calFun}");
            calculateFunVoid(a, b);
        }
        static void calculateFunVoid(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                Console.WriteLine(0);
                return;
            }
               double x, y, z;
            x = Math.Pow(a, 2) / Math.Pow(b, 2);
            y = Math.Pow(a, 2) + (2 * Math.Pow(b, 2));

            // действие в скобках
            double z_1 = Math.Pow(x, 2) + Math.Pow(x, 2) + (x * y);
            // второе действие с извлечением корня
            double z_2 = Math.Sqrt(x / y);
            // итоговый результат
            z = 1.0 / 2.0 * z_1 * z_2;
            Console.WriteLine(z);
        }
        static double calculateFun(int a, int b)
        {
            if (a < 0 || b < 0) return 0;
            double x, y, z;
            x = Math.Pow(a, 2)/Math.Pow(b, 2);
            y = Math.Pow(a, 2) + (2 * Math.Pow(b, 2));

            // действие в скобках
            double z_1 = Math.Pow(x, 2) + Math.Pow(x, 2) + (x * y);
            // второе действие с извлечением корня
            double z_2 = Math.Sqrt(x / y);
            // итоговый результат
            z = 1.0/2.0 * z_1 * z_2;
            return z;
        }
    }
}
