using System;
using AssemblyOne;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            SportBike sb = new SportBike();
            sb.MaxSpeedPublic = 150;       //он не может найти тип, на который вы ссылается
        }
    }
}