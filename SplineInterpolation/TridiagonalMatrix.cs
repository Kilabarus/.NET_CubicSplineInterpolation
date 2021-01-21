using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplineInterpolation
{
    class TridiagonalMatrix : ICloneable<TridiagonalMatrix>
    {
        public Vector a { get; private set; }
        public Vector b { get; private set; }
        public Vector c { get; private set; }

        public int Size { get; private set; }

        public TridiagonalMatrix(Vector a, Vector b, Vector c)
        {
            Size = a.Size;

            this.a = a.Clone();
            this.b = b.Clone();
            this.c = c.Clone();            
        }

        public TridiagonalMatrix Clone()
        {            
            return new TridiagonalMatrix(a, b, c);
        }        
    }
}
