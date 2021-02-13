using System;

namespace HW03.Calculator
{
    class Program
    {
        class Calculator
        {
            public int Add(int num1, int num2)
            {
                return num1 + num2;
            }

            public int Subtract(int num3, int num4)
            {
                return num3 - num4;
            }

            public int Multiply(int num5, int num6)
            {
                return num5 * num6;
            }

            public double Divide(int num7, int num8)
            {
                return (double)num7 / num8;
            }

            public int Remainder(int num9, int num10)
            {
                return num9 % num10;
            }

            public double CircleArea(double rad)
            {
                return 3.14 * Math.Pow(rad, 2);
            }
        }
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            // Сложение
            Console.WriteLine("Сложение 2 чисел");
            Console.WriteLine("Введите первое число-");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число-");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num1} + {num2} = {calc.Add(num1, num2)}");
            //Вычитание 
            Console.WriteLine("Вычитание 2 чисел");
            Console.WriteLine("Введите первое число-");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число-");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num3} - {num4} = {calc.Subtract(num3, num4)}");
            //Умножение 
            Console.WriteLine("Умножение 2 чисел");
            Console.WriteLine("Введите первое число-");
            int num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число-");
            int num6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num5} * {num6} = {calc.Multiply(num5, num6)}");
            //Деление
            Console.WriteLine("Деление 2 чисел");
            Console.WriteLine("Введите первое число-");
            int num7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число-");
            int num8 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num7} / {num8} = {calc.Divide(num7, num8)}");
            //Остаток от деления 
            Console.WriteLine("Остаток от деления 2 чисел");
            Console.WriteLine("Введите первое число-");
            int num9 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число-");
            int num10 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num9} % {num10} = {calc.Remainder(num9, num10)}");
            //Площадь круга
            Console.WriteLine("Площадь круга");
            Console.WriteLine("Введите радиус окружности-");
            int rad = int.Parse(Console.ReadLine());
            Console.WriteLine($"Площадь круга равна = { calc.CircleArea(rad)}");
        }
    }
}