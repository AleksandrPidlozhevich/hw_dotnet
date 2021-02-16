using System;

namespace HW04.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбрать направление движения-нажмите один из вариантов W,A,S,D)");
            char mov = Convert.ToChar(Console.ReadLine());
            if (mov == 'W')
            {
                Console.WriteLine("герой идет вверх");
            }
            else if (mov == 'A')
            {
                Console.WriteLine("герой идет влево");
            }
            else if (mov == 'S')
            {
                Console.WriteLine("герой идет вниз");
            }
            else if (mov == 'D')
            {
                Console.WriteLine("герой идет вправо");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}