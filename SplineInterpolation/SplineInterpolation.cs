using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplineInterpolation
{
    public class SplineInterpolation
    {        
        double leftBorder, rightBorder, A, B, h;

        IFunction func;
        public double[,] functionValuesTable;

        Vector b, c, d;

        int N;
        
        public SplineInterpolation(IFunction func, double a, double b, double A, double B, int N)
        {
            this.func = func;

            this.leftBorder = a;
            this.rightBorder = b;

            this.A = A;
            this.B = B;

            this.N = N;
            
            this.b = new Vector(N);
            this.c = new Vector(N);
            this.d = new Vector(N);

            this.h = (b - a) / N;
        }

        public double f(int i)
        {
            return functionValuesTable[i, 1];
        }

        public double f(int i, int j)
        {
            return (functionValuesTable[j, 1] - functionValuesTable[i, 1]) / h;
        }

        public double f(int i, int j, int k)
        {
            return (f(j, k) - f(i, j)) / (2 * h);
        }

        public void InitializeParameters()
        {
            InitializeFunctionValues();

            Find_c();
            Find_d();
            Find_b();
        }

        private void InitializeFunctionValues()
        {
            functionValuesTable = new double[N + 1, 2];
            double x;

            for (int i = 0; i <= N; ++i)
            {
                x = leftBorder + i * h;

                functionValuesTable[i, 0] = x;
                functionValuesTable[i, 1] = func.Value(x);
            }
        }

        private void Find_c()
        {
            TridiagonalMatrix SOLE_Matrix = InitializeMatrixForSOLE();
            Vector SOLE_RightVector = InitializeRightVectorForSOLE();

            c = (new SystemOfLinearEquations(SOLE_Matrix, SOLE_RightVector)).Solve();
        }

        private TridiagonalMatrix InitializeMatrixForSOLE()
        {
            Vector lowerDiagonal = new Vector(N);
            for (int i = 2; i <= N - 1; ++i)
            {
                lowerDiagonal[i] = 0.5;
            }

            Vector diagonal = new Vector(N);
            for (int i = 2; i <= N; ++i)
            {
                diagonal[i] = 2;
            }
            diagonal[1] = 4;

            Vector upperDiagonal = new Vector(N);
            for (int i = 2; i <= N - 1; ++i)
            {
                upperDiagonal[i] = 0.5;
            }
            upperDiagonal[1] = 1;

            return new TridiagonalMatrix(lowerDiagonal, diagonal, upperDiagonal);
        }

        private Vector InitializeRightVectorForSOLE()
        {
            Vector res = new Vector(N);

            for (int i = 2; i <= N - 1; ++i)
            {
                res[i] = 3 * f(i - 1, i, i + 1);
            }

            res[1] = 6 * f(0, 1, 2) - (A / 2);
            res[N] = B;

            return res;
        }

        private void Find_d()
        {
            for (int i = 2; i <= N; ++i)
            {
                d[i] = (c[i] - c[i - 1]) / (3 * h);
            }

            d[1] = (2 * c[1] - A) / (6 * h);
        }

        private void Find_b()
        {
            for (int i = 1; i <= N; ++i)
            {
                b[i] = c[i] * h - d[i] * h * h + (f(i) - f(i - 1)) / h;
            }
        }        

        public double Value(double x)
        {
            int i = FindSplineIndex(x);
            double diff = x - functionValuesTable[i, 0];

            return f(i) + b[i] * diff + c[i] * diff * diff + d[i] * diff * diff * diff;
        }

        private int FindSplineIndex(double x)
        {
            if (x < leftBorder || x > rightBorder)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = 1; i <= N; ++i)
            {
                if (functionValuesTable[i, 0] >= x)
                {
                    return i;
                }
            }

            return N;
        }        
    }    
}
