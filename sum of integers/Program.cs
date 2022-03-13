using System;

namespace sum_of_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            // получаем целое число и считаем сумму его чисел (757) = 7 + 5 + 7 
            Console.Write("Введите число от 10 и это число ");
            int val = int.Parse(Console.ReadLine());

            int valSum = SumNumber(val);
            Console.WriteLine($"Сумма цифр числа \"{val}\" равна {valSum}");
            Console.ReadLine();
        }

        static int SumNumber(int value)
        {
            if (value <= 10) return value;
            int result = 0;
            result += value % 10;
            value /= 10;
            if (value > 0)
            {
                // рекурсия
                result += SumNumber(value);
            }; 

            return result;
        }
    }
}
