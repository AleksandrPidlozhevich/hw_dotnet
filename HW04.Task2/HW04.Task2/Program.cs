using System;

namespace HW04.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Summary();
        }
        static void Summary()
        {
            int trusum;
            try
            {
                Console.WriteLine("Введите первую цифру-");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите вторую цифру-");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите сумму");
                int summary = Convert.ToInt32(Console.ReadLine());
                trusum = num1 + num2;
                if (trusum == summary)
                {
                    Console.WriteLine("Правильный ответ");
                }
                else
                {
                    Console.WriteLine("Неправильный ответ");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Введёно недопустимое значение, введите целое число");
            }
        }
    }
}