using System;
using Xunit;

namespace PrimeNumbers.Test
{
    public class GetPrimeTests
    {
        [Theory]
        [InlineData(1,2)]
        [InlineData(10, 29)]
        [InlineData(6, 13)]
        [InlineData(3, 5)]
        [InlineData(2,3)]
        [InlineData(22,79)]
        public void TestMultiple(int sequence, int expected)
        {
            PrimeFinder primetime = new PrimeFinder();
            int prime = primetime.GetPrime(sequence);
            Assert.Equal(expected, prime);
        }
    }
}
