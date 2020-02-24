using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CoreLab.Models
{
    public class AddNumbers
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Sum2Num { get; set; }

        public AddNumbers() { }

        public AddNumbers(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public double AddTheNumbers()
        {
            Sum2Num = Num1 + Num2;
            return Sum2Num;
        }
    }
}
