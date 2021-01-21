using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplineInterpolation
{
    class SystemOfLinearEquations
    {        
        public TridiagonalMatrix Matrix { get; }
        public int N { get; }

        public Vector a { get { return Matrix.a; } }
        public Vector b { get { return Matrix.b; } }
        public Vector c { get { return Matrix.c; } }

        public Vector f { get; }

        public SystemOfLinearEquations(TridiagonalMatrix matrix, Vector v)
        {
            if (matrix.Size != v.Size)
            {
                throw new ArgumentOutOfRangeException();
            }

            Matrix = matrix.Clone();
            f = v.Clone();
            N = f.Size;
        }

        public Vector Solve()
        {
            StepOne();

            return ReverseSubstitution();
        }

        public void StepOne()
        {
            double R;           

            for (int i = 1; i <= N - 1; ++i)
            {
                R = 1 / b[i];
                b[i] = 1;
                c[i] *= R;
                f[i] *= R;

                R = -a[i + 1];
                b[i + 1] += R * c[i];
                f[i + 1] += R * f[i];
            }

            f[N] /= b[N];
            b[N] = 1;        
        }

        public Vector ReverseSubstitution()
        {
            Vector x = new Vector(N);

            x[N] = f[N];

            for (int i = N - 1; i >= 1; --i)
            {
                x[i] = f[i] - x[i + 1] * c[i];
            }

            return x;
        }
    }
}
