using System.Collections.Generic;

using Xunit;

namespace PrimeFactorsKataAcademy
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(new List<int>(), PrimeFactors.Get(1));
            Assert.Equal(new List<int> { 2 }, PrimeFactors.Get(2));
        }
    }
}