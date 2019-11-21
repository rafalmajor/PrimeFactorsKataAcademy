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
                factors.Add(2);
            }

            return factors;
        }
    }
}