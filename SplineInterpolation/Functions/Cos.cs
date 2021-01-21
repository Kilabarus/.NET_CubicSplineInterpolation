using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplineInterpolation
{
    public class Cos : IFunction
    {        
        public double Value(double x)
        {
            return Math.Cos(x);
        }

        public double SecondDerivativeValue(double x)
        {
            return -Value(x);
        }
    }
}
