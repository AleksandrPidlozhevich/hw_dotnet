using System;

namespace HW._05.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            while (true)
            {
                Console.Write("Ввести число от 1 до 100: ");
                if (int.TryParse(Console.ReadLine(), out num) && num <= 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }
            }
            var indent = " ";
            for (int i = 1, limit = num; i <= num; i++, limit--)
            {
                for (int j = limit; j >= 1; j--)
                {
                    Console.Write(" " + i % 10);
                }
                Console.WriteLine();
                Console.Write(indent);
                indent += " ";
            }
        }
    }
}