using System.Collections.Generic;

namespace PrimeFactorsKataAcademy
{
    public class PrimeFactors
    {
        public static List<int> Get(int number)
        {
            var factors = new List<int>();

            for (int divisor = 2; number > 1; divisor++)
            {
                for (; number % divisor == 0; number /= divisor)
                {
                    factors.Add(divisor);
                }
            }

            return factors;
        }
    }
}