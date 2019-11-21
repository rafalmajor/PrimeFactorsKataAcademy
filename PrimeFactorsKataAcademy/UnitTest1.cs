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
            Assert.Equal(new List<int> { 3 }, PrimeFactors.Get(3));
            Assert.Equal(new List<int> { 2, 2 }, PrimeFactors.Get(4));
            Assert.Equal(new List<int> { 5 }, PrimeFactors.Get(5));
            Assert.Equal(new List<int> { 2, 3 }, PrimeFactors.Get(6));
        }
    }
}