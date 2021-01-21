using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplineInterpolation
{
    public interface IFunction
    {
        double Value(double x);
        double SecondDerivativeValue(double x);        
    }
}
