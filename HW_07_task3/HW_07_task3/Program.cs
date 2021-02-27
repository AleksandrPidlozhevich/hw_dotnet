using System;
using System.Text;

namespace HW_07_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Склеивает цифры в одно число до математического знака и склеивает цифры в одно число после математического знака.введите любую белеберду");
            Console.WriteLine(DecipherArithmetics(Console.ReadLine()));
        }
        static int DecipherArithmetics(string text)
        {
            char operation = '\0';
            string num1 = string.Empty;
            string num2 = string.Empty;
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    str.Append(text[i]);
                }
                if (text[i] != '+' && text[i] != '-' && text[i] != '*' && text[i] != '/')
                {
                    continue;
                }
                operation = text[i];
                if (string.IsNullOrEmpty(num1))
                {
                    num1 = str.ToString();
                    str.Clear();
                }
            }
            num2 = str.ToString();
            str.Clear();
            decimal x = operation switch
            {
                '+' => int.Parse(num1) + int.Parse(num2),
                '-' => int.Parse(num1) - int.Parse(num2),
                '*' => int.Parse(num1) * int.Parse(num2),
                '/' => int.Parse(num1) / int.Parse(num2),
                _ => 0,
            };
            return (int)x;
        }
    }
}