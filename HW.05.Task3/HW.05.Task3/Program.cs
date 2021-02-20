using System;

namespace HW._05.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan timeOfDay = DateTime.Now.TimeOfDay;
            Console.WriteLine(timeOfDay);
            int interval = timeOfDay.Hours;
            switch (interval)
            {
                case int h when h >= 9 && h < 12:
                    Console.WriteLine("Good morning, guys!");
                    break;
                case int h when h >= 12 && h < 15:
                    Console.WriteLine("Good day, guys!");
                    break;
                case int h when h >= 12 && h < 22:
                    Console.WriteLine("Good evening, guys!");
                    break;
                default:
                    Console.WriteLine("Good night, guys!");
                    break;
            }
        }
    }
}