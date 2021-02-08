using System;
using System.Collections;
namespace HW._02.Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Неявные преобразования(преобразования не вызывают каких-то затруднений)
            //1
            byte a = 255;
            ushort b = a;
            //2
            sbyte x = -128;
            short y = x;
            //3
            int q = 2147483647;
            long w = q;

            Console.WriteLine($"{b} {y} {w}");
            //Явные преобразования
            //1
            int l = 1010;
            byte c = (byte)l;
            //2
            int i = 200;
            int v = 15;
            var e = (double)i / v;
            //3
            double dbl = 30.80;
            int rnd = (short)dbl;
            Console.WriteLine($"{c} {e} {rnd}");
            //3 примера операции упаковки (boxing)
            //1
            int t = 100;
            Object obj = t;
            //2
            ArrayList arr = new ArrayList();
            int g = 8;
            arr.Add(g);
            //3
            int num2 = 666;
            string hell = "hell";
            string resul = hell + num2;
            //3 примера операции распаковки (unboxing) 
            //1
            int num = 666;
            object box = (object)num;
            int num3 = (int)box;
            //2
            int value = 34;
            object value1 = value;
            short value2 = (short)(int)value1;
            //3 не придумал

        }
    }
}
