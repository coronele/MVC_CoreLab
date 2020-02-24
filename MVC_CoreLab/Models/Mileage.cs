using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CoreLab.Models
{
    public class Mileage
    {
        public double Mpg { get; set; }
        public double Gallons { get; set; }
        public double Distance { get; set; }
        public double Range { get; set; }

        public Mileage() { }

        public Mileage(double mpg, double gallons, double distance)
        {
            Mpg = mpg;
            Gallons = gallons;
            Distance = distance;
        }

        public double RemainingRange()
        {
            Range = Mpg * Gallons;
            return Range;
        }

        public bool EnoughGas()
        {
            if (Range > Distance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
