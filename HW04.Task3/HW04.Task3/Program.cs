using System;

namespace HW_03_Task3
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