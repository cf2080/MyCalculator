using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Divide(int divident, int divisor)
        {
            return divident / divisor;
            //throw new NotImplementedException();
        }
    }
}
