using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11
{
    public class Motorcycle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Odometer { get; set; }
        private static int _idIterator;

        public Motorcycle(string name, string model, int year, int odometer)
        {
            _idIterator += 1;
            Id = _idIterator;
            Name = name;
            Model = model;
            Year = year;
            Odometer = odometer;
        }
    }
}
