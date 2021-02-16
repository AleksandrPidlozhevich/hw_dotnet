using System;

namespace HW_03_Task4
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
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите вторую цифру-");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Выберете + или - ");
                char ch1 = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Введите ответ");
                int summary = Convert.ToInt32(Console.ReadLine());
                if (ch1 == '+')
                {
                    trusum = number1 + number2;
                }
                else
                {
                    trusum = number1 - number2;
                }
                if (trusum == summary)
                {
                    Console.WriteLine("Правильный ответ");
                }
                else
                {
                    Console.WriteLine("Неправильный ответ");
                    if (summary < trusum)
                    {
                        Console.WriteLine("Ответ должен быть больше");
                    }
                    else
                    {
                        Console.WriteLine("Ответ должен быть меньше");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Введёно недопустимое значение, введите целое число");
            }
        }
    }
}