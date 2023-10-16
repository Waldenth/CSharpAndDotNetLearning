using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Ex03
{
    class Primes
    {
        private long min;
        private long max;

        public Primes() : this(2, 200) { }
        public Primes(long minmum,long maxmum)
        {
            if (minmum < 2)
                min = 2;
            else
                min = minmum;
            max = maxmum;
        }

        public IEnumerator GetEnumerator()
        {
            for(long possiblePrime=min; possiblePrime <= max; possiblePrime++)
            {
                bool isPrime = true;
                for(long possibleFactor = 2; 
                    possibleFactor <= (long)Math.Floor(Math.Sqrt(possiblePrime));
                    possibleFactor++)
                {
                    long remainAfterDivision = possiblePrime % possibleFactor;
                    if (remainAfterDivision == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    yield return possiblePrime;
                }
            }
        }
    }
}
