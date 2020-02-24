using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CoreLab.Models
{
    public class Divide
    {
        public int Dividend { get; set; }
        public int Divisor { get; set; }
        public int Quotient { get; set; }
        public int Remainder { get; set; }

        public Divide() { }

        public Divide(int dividend, int divisor)
        {
            Dividend = dividend;
            Divisor = divisor;
        }

        public int GetQuotient()
        {
            Quotient = Dividend / Divisor;
            return Quotient;
        }


        public int GetRemainder()
        {
            Remainder = Dividend % Divisor;
            return Remainder;
        }
    }


}
