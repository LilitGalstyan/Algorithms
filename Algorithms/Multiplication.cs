using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Algorithms
{
    class Multiplication
    {
        static BigInteger Multiply(BigInteger x, BigInteger y)
        {
            int x_length = x.ToString().Length;
            int y_length = y.ToString().Length;

            BigInteger n = (BigInteger)Math.Max(Math.Pow(10, x_length / 2), Math.Pow(10, y_length / 2));

            BigInteger a = x / n;
            BigInteger b = x % n;
            BigInteger c = y / n;
            BigInteger d = y % n;

            if (n == 1)
            {
                return x * y;
            }

            BigInteger ac = Multiply(a, c);
            BigInteger bd = Multiply(b, d);
            BigInteger ad_plus_bc = Multiply(a, d) + Multiply(b, c);

            return (n * n) * ac + n * ad_plus_bc + bd;
        }
    }
}
