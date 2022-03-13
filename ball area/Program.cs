using System;

namespace ball_area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус шара в см:  ");
            double rad = double.Parse(Console.ReadLine());
            // вызываем метод
            double area_ball = areaBall(rad);

            Console.WriteLine($"объем шара при радиусе {rad} равен: {Math.Round(area_ball, 2)} cм куб.");
            areaBallVoid(rad);
            Console.ReadLine();
        }
        static double areaBall(double radius)
        {
            if (radius <= 0) return 0;
            // формула объема шара
            double res = (4.0 / 3.0) * (Math.PI * Math.Pow(radius, 3));
            return res;
        }
        static void areaBallVoid(double radius)
        {
            if (radius <= 0)
            {
                Console.WriteLine(0);
                return;
            }
                // формула объема шара
            double res = (4.0 / 3.0) * (Math.PI * Math.Pow(radius, 3));
            Console.WriteLine($"Объем шара при радиусе {radius} равен: {Math.Round(res, 2)} cм куб.");
        }
    }
}
