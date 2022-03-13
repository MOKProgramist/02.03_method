using System;

namespace negative_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для проверки: ");
            int num = int.Parse(Console.ReadLine());

            //int resCheckNumber = checkNegativeNumber(num);
            //Console.WriteLine(resCheckNumber);

            checkNegativeNumberVoid(num);
        }

        static int checkNegativeNumber(int num)
        {
            // проверка на отрицание. Если число больше 0 вернем 1, если нет сравнимаем дальше не равно 0 вернем -1, равно 0 вернем 0
            int c = num > 0 ? 1 : (num != 0 ? -1 : 0);
            
            return c;
        }
        static void checkNegativeNumberVoid(int num)
        {
            // проверка на отрицание. Если число больше 0 вернем 1, если нет сравнимаем дальше не равно 0 вернем -1, равно 0 вернем 0
            int c = num > 0 ? 1 : (num != 0 ? -1 : 0);

            Console.WriteLine(c);
        }
    }
}
