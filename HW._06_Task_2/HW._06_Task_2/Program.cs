using System;

namespace HW._06_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива-");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Ввод массива");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("Введите {0} элемент массива-", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\nВведите значение для добавления в массива-");
            string key = Console.ReadLine();
            int.TryParse(key, out array[array.Length - 1]);
            Console.Write("Введите позицию числа в массиве-");
            int position = Convert.ToInt32(Console.ReadLine());
            for (int j = array.Length - 1; j != position; j--)
            {
                int num = array[j];
                array[j] = array[j - 1];
                array[j - 1] = num;
            }
            Console.WriteLine("Новый массив");
            for (int x = 0; x < array.Length; x++)
            {
                Console.Write(array[x] + " ");
            }
        }
    }
}