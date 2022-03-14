using System;

namespace the_arithmetic_mean_of_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число => " );
            int oneNum = int.Parse(Console.ReadLine());
            Console.Write("Введите первое число => ");
            int twoNum = int.Parse(Console.ReadLine()); 

            double arithmeticSum = getArithmeticMean(oneNum, twoNum);
            Console.WriteLine($"Среднее арифметиеское цифр чисел = {Math.Round(arithmeticSum, 2)}");
        }

        // количество цифр в числе
        static int getCountNumberOfNumber(int value, int result = 0)
        {
            result++;
            value /= 10;
            if (value > 0)
            {
                // рекурсия
                result += getCountNumberOfNumber(value);
            };

            return result;
        }
        // сумма цифр числа
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
        static double getArithmeticMean(int a, int b)
        {
            // считаем сумма цифр числа
            double arifmetNum = ((SumNumber(a)/ getCountNumberOfNumber(a)) + (SumNumber(b) / getCountNumberOfNumber(b)))/2;
            // Console.WriteLine($"getCountNumberOfNumber a = {getCountNumberOfNumber(a)}\ngetCountNumberOfNumber b = {getCountNumberOfNumber(b)}");

            return arifmetNum;
        }
    }
}
