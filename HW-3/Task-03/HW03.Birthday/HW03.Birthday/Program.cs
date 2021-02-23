using System;

namespace HW03.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            UserAge();
        }
        public static int RangeMonths(int value)
        {
            if (value < 1 || value > 12)
                {
                throw new ArgumentOutOfRangeException("Error");
            }
            else
                return value;
        }
        public static void UserAge()
        {
            Console.WriteLine("Введите год рождения ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц рождения ");
            int month = int.Parse(Console.ReadLine());
            month = RangeMonths(month);
            var birthday = new DateTime(year, month, 01);
            Console.WriteLine("Введите текущий год ");
            int year1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите текущий месяц ");
            int month1 = int.Parse(Console.ReadLine());
            month1 = RangeMonths(month1);
            var now = new DateTime(year1, month1, 01);
            var years = TotalYears(birthday, now);
            Console.WriteLine($"Вам {years} лет");
            Console.ReadKey();
        }
        static int TotalYears(DateTime d1, DateTime d2)
        {
            var years = 0;
            while (d1.AddYears(years) <= d2)
                years++;

            return years - 1;
        }
    }
}