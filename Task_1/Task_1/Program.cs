using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите размерность массива");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[n];
            Random value = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = value.Next();
                Console.WriteLine(array1[i]);
            }
            int[] array2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите {0} элемент массива", i);
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadLine();
            int[] array3 = new int[n];
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = array1[i] + array2[i];
                Console.WriteLine(array3[i]);
            }
            Console.ReadLine();
        }
    }
}