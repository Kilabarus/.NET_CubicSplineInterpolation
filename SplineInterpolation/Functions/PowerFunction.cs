using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplineInterpolation
{
    public class PowerFunction : IFunction
    {
        public double Value(double x)
        {
            return Math.Pow(x, 3);
        }

        public double SecondDerivativeValue(double x)
        {
            return 6 * x;
        }
    }
}
