using System;
using System.Text;

namespace HW_07_task1
{
    class Program
    {
        static StringBuilder poems = new StringBuilder();
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стихотворение в строку, используйте ';' для разрывов строк");
            poems.Append(Console.ReadLine());
            poems.Replace(';', '\n');
            poems.Replace('O', 'A');//en
            poems.Replace('o', 'a');//en
            poems.Replace('О', 'А');//ru
            poems.Replace('о', 'а');//ru
            Console.WriteLine(poems);
        }
    }
}