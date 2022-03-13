using System;

namespace maximum_number
{
    class Program
    {
        static void Main(string[] args)
        {
            // считаем количество цифр в числе "123" = 3
            Console.Write("Введите число от 10 и это число ");
            int val = int.Parse(Console.ReadLine());

            int valMax = getMaxNumberOfNumber(val);
            Console.WriteLine($"Макимальная цифра числа \"{val}\" равна {valMax}");
            Console.ReadLine();
        }

        static int getMaxNumberOfNumber(int value)
        {
            int max = 0; 
            // если число больше чем мах, то изменяем
            while (value > 0)
            {
                if (max < value % 10) max = value % 10;
                value /= 10;
            }

            return max;
        }
    }
}
