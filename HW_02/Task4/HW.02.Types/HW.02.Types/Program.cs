using System;

namespace HW._02.Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 10;
            Int32 x2 = 11;
            Console.WriteLine(x1.GetType());
            Console.WriteLine(x2.GetType());
            byte b1 = 10;
            Byte b2 = 11;
            Console.WriteLine(b1.GetType());
            Console.WriteLine(b2.GetType());
            bool good = true;
            Boolean bad = false;
            Console.WriteLine(good.GetType());
            Console.WriteLine(bad.GetType());
            decimal d1 = 8.151m;
            Decimal d2 = 4.56151m;
            Console.WriteLine(d1.GetType());
            Console.WriteLine(d2.GetType());
            object obj1 = "abracadabra";
            Object obj2 = "12123";
            Console.WriteLine(obj1.GetType());
            Console.WriteLine(obj2.GetType());
            char c1 = 'A';
            Char c2 = 'B';
            Console.WriteLine(c1.GetType());
            Console.WriteLine(c2.GetType());
            string s1 = "str";
            String s2 = "str2";
            Console.WriteLine(s1.GetType());
            Console.WriteLine(s2.GetType());




        }
    }
}
