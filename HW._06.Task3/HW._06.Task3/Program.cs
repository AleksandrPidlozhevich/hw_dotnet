using System;

namespace HW._06.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива-");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Ввод массива");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите {0} элемент массива-", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
