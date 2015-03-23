using System;
using System.Numerics;

namespace Fibonacci
{
    public static class Fibonaci
    {
        /// <summary>
        ///     algorithm:   http://www.m-hikari.com/imf-password2008/1-4-2008/ulutasIMF1-4-2008.pdf
        ///     python impl: https://vinayakgarg.wordpress.com/2012/11/07/fastest-way-to-compute-fibonacci-number/
        /// </summary>
        public static BigInteger FastDouble(BigInteger n)
        {
            if (n >= 0)
            {
                return FastDoubleFibonaci(n);
            }
            n = -n;
            if (n%2 == 0)
            {
                return -FastDoubleFibonaci(n);
            }

            return FastDoubleFibonaci(n);
        }

        private static BigInteger FastDoubleFibonaci(BigInteger n)
        {
            if (n <= 2)
            {
                return 1;
            }

            BigInteger k = n/2;
            BigInteger a = FastDouble(k + 1);
            BigInteger b = FastDouble(k);
            if (n%2 == 1)
            {
                return a*a + b*b;
            }
            return b*(2*a - b);
        }

        /// <summary>
        ///     Computes the nth term of the Fibonacci sequence.
        /// </summary>
        public static long Nth(long nth)
        {
            if (nth <= -92 || nth >= 92)
            {
                throw new ArgumentOutOfRangeException("nth",
                    String.Format("'{0}' would result in an Int64.[Min|Max]Value overflow.", nth));
            }

            return (long) FastDouble(nth);
        }

        /// <summary>
        ///     Computes the nth term of the Fibonacci sequence.
        /// </summary>
        public static BigInteger Nth(BigInteger nth)
        {
            return FastDouble(nth);
        }
    }
}