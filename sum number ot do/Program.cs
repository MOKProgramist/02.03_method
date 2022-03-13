using System;

namespace sum_number_ot_do
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Начальное число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Конечное число: ");
            int b = int.Parse(Console.ReadLine());

            //int sumNumber = sumNumberOt(a, b);
            //Console.WriteLine(sumNumber);
            sumNumberOtVoid(a, b);
        }
        static void sumNumberOtVoid(int a, int b)
        {
            if (a > b) { Console.WriteLine(0); return; }
            // запуска цикл от а до б и считаем сумму
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        static int sumNumberOt(int a, int b)
        {
            if (a > b) return 0;
            // запуска цикл от а до б и считаем сумму
            int sum = 0;
            for(int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
