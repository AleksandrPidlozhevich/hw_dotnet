using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            SportBike sportBike = new SportBike();
            //sportBike.MaxSpeedPrivate = 80;
            //sportBike.MaxSpeedProtected = 70;
            sportBike.MaxSpeedPublic = 100;
            sportBike.MaxSpeedInternal = 150;
            sportBike.MaxSpeedInternalProtected();
        }
    }
}