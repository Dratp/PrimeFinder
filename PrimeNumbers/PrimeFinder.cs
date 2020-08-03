using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbers
{
    public class PrimeFinder
    {
        public int GetPrime(int sequence)
        {
            List<int> Optimus = new List<int>();
            Optimus.Add(2);     // Seeding the prime number list with the first prime number
            Optimus.Add(3);

            for(int i = 4; Optimus.Count < sequence; i++)
            {
                int countPrimes = Optimus.Count;
                for(int pindex = 0; pindex < countPrimes; pindex++)
                {
                    if (i % Optimus[pindex] == 0)
                    {
                        break;   
                    }
                    else if (pindex == countPrimes-1)
                    {
                        Optimus.Add(i);
                    }
                }
            }
            return Optimus[sequence-1];
        }
    }
}
