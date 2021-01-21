using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplineInterpolation
{
    public class CustomPolynomial : IFunction
    {
        public double Value(double x)
        {
            //return (x + 4) * (x - 12) * (x + 9) / 200;
            //return (x + 4) * (x - 2) * (x - 5) * (x + 9) / 100; 
            //return (x - 10) * (x + 1) * (x + 12) * (x + 9) / 300;
            return x * (x - 2) * (x - 3) * (x - 7) * (x + 1) * (x + 4) * (x + 9) * (x + 11);
        }

        public double SecondDerivativeValue(double x)
        {
            //return (3 * x + 1) / 100;
            //return (3 * (2 * x * x + 6 * x - 15)) / 50;
            //return (6 * x * x + 36 * x - 91) / 150;
            return 2 * (-7914 + 30891 * x + 4614 * x * x - 8780 * x * x * x - 840 * x * x * x * x + 273 * x * x * x * x * x + 28 * x * x * x * x * x * x);
        }
    }

    // (x + 4) * (x - 12) * (x + 9) / 200;
    // (3 * x + 1) / 100;

    // (x + 4) * (x - 2) * (x - 5) * (x + 9) / 100;
    // (3 * (2 * x * x + 6 * x - 15)) / 50;

    // (x - 10) * (x + 1) * (x + 12) * (x + 9) / 300;
    // (6 * x * x + 36 * x - 91) / 150;



}
