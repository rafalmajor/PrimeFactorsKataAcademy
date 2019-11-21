using System.Collections.Generic;

namespace PrimeFactorsKataAcademy
{
    public class PrimeFactors
    {
        public static List<int> Get(int number)
        {
            var factors = new List<int>();
            if (number > 1)
            {
                if (number % 2 == 0)
                {
                    factors.Add(2);
                    number /= 2;
                }

                if (number > 1)
                {
                    factors.Add(number);
                }
            }

            return factors;
        }
    }
}