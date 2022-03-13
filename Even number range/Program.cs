using System;
using System.Collections.Generic;

namespace Even_number_range
{
    class Program
    {
        static void Main(string[] args)
        {
            // вывести все четных числа в диапазоне от а до б
            Console.Write("Введите начальную границу (A): ");
            int aNum = int.Parse(Console.ReadLine());
            Console.Write("Введите конечную границу (Б): ");
            int bNum = int.Parse(Console.ReadLine());
            
            if(aNum > bNum)
            {
                Console.WriteLine("Диапазон указан не верно. Прекращаю работу.");
                return;
            }

            //List<int> res = evenNumberRange(aNum, bNum);
            //Console.WriteLine($"Четные числа в диапазоне от {aNum} до {bNum}:");
            //for (int i = 0; i < res.Count; i++) Console.Write(res[i] + " ");
            evenNumberRangeVoid(aNum, bNum);
        }

        static List<int> evenNumberRange(int a, int b)
        {
            // создаем коллекцию с типом инт
            var number = new List<int>();

            for (int i = a; i <= b; i++)
            {
                // проверка на четность и завись в созданную коллецию данных через метод
                if (i % 2 == 0) number.Add(i);
            }

            return number;
        }
        static void evenNumberRangeVoid(int a, int b)
        {
            Console.WriteLine($"Четные числа в диапазоне от {a} до {b}:");
            for (int i = a; i <= b; i++)
            {
                // проверка на четность
                if (i % 2 == 0) Console.Write(i + " ");  
            }

        }
    }
}
