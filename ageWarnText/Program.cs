using System;

namespace ageWarnText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько вам лет?");
            ageWarnTextVoid(int.Parse(Console.ReadLine()));
            //Console.WriteLine(text);
        }

        static void ageWarnTextVoid(int age)
        {
            string text = (age >= 18 ? "Вы совершеннолетний" : "Вы еще не совершеннолетний");
            Console.WriteLine(text);
        }
    }
}
