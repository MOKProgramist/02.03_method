using System;

namespace Number_of_numbers_in_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            // считаем количество цифр в числе "123" = 3
            Console.Write("Введите число от 10 и это число ");
            int val = int.Parse(Console.ReadLine());

            int valSum = getCountNumberOfNumber(val);
            Console.WriteLine($"Число цифр числа \"{val}\" равна {valSum}");
            Console.ReadLine();
        }

        static int getCountNumberOfNumber(int value)
        {
            int result = 0;
            result += 1;
            value /= 10;
            if (value > 0)
            {
                // рекурсия
                result += getCountNumberOfNumber(value);
            };

            return result;
        }
    }
}
