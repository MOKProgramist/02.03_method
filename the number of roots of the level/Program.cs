using System;

namespace the_number_of_roots_of_the_level
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Введите значение а: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write($"Введите значение b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write($"Введите значение c: ");
            int c = int.Parse(Console.ReadLine());

            int countKorni = getCountKorni(a: a, b: b, c: c);
            Console.WriteLine($"В данном уравнение {(countKorni != 0 ? $"{countKorni} корня" : "корней нет")}");
        }

        static int getCountKorni(int a, int b, int c)
        {
            // по формлуле
            double D;
            D = b * b - 4 * a * a;

            int result = 0;
            if (D < 0) {
                result = 0;
            }
            if (D == 0) {
                result = 1;
            }
            if (D > 0) {
                result = 2;
            }
            return result;
        }
    }
}
