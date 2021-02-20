using System;

namespace HW._05.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число положительное> 0");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = n * (1 + n) / 2;
            if (n == 0)
            {
                Console.WriteLine("Сказали ввести значение  больше 0!!!!!");
            }
            else
            Console.WriteLine("Ответ-" + sum);
            Console.ReadKey();

        }
    }
}