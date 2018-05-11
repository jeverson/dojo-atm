using System;
using Atm;
using Xunit;

namespace Atm.Tests
{
    public class SequentialMoneyCounterTest
    {
        private readonly IMoneyCounter counter;
        public SequentialMoneyCounterTest()
        {
            counter = new SequentialMoneyCounter();
        }

        [Theory]
        [InlineData(10, 1, 0, 0, 0)]
        [InlineData(20, 0, 1, 0, 0)]
        [InlineData(30, 1, 1, 0, 0)]
        [InlineData(40, 0, 2, 0, 0)]
        [InlineData(50, 0, 0, 1, 0)]
        [InlineData(60, 1, 0, 1, 0)]
        [InlineData(100, 0, 0, 0, 1)]
        [InlineData(400, 0, 0, 0, 4)]
        public void Counter_ShouldReturnLowestNumberOfBills_ForRequestedValue(int value, int of10, int of20, int of50, int of100)
        {
            var bills = counter.GetMinimalNumberOfBills(value);
            Assert.Equal(of10, bills.Of10);
            Assert.Equal(of20, bills.Of20);
            Assert.Equal(of50, bills.Of50);
            Assert.Equal(of100, bills.Of100);
        }
    }
}
