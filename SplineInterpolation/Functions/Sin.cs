using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplineInterpolation
{
    public class Sin : IFunction
    {
        public double Value(double x)
        {
            return Math.Sin(x);
        }        

        public double SecondDerivativeValue(double x)
        {
            return -Value(x);
        }
    }
}
