using System;

namespace HW04.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26]
            { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z' };
            for (char abv = 'Z'; abv >= 'A'; abv--)
            {
                Console.WriteLine(abv);
            }
        }
    }
}