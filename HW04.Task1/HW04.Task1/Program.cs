using System;

namespace HW_03_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Summary();
        }
        static void Summary()
        {
            try
            {
                Console.WriteLine("Введите первую цифру-");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите вторую цифру-");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int summary = num1 + num2;
                Console.WriteLine("Сумма-{0}", summary);
            }
            catch (Exception)
            {
                Console.WriteLine("Введёно недопустимое значение, введите целое число");
            }
        }
    }
}