using System;
using System.Linq;

namespace HW._05.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи слово с большим количеством букв а :");
            string word = Console.ReadLine();
            char[] letter = "AaаА".ToCharArray();
            int count = 0;
            foreach (char letterA in word)
            {
                if (letter.Contains(letterA))
                {
                    count++;
                }
            }
            Console.WriteLine("в твоём слове {0}", count + " " + "буквы a");
            Console.ReadKey();
        }
    }
}