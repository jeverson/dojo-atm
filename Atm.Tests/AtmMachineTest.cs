using System;
using Atm;
using Xunit;

namespace Atm.Tests
{
    public class AtmMachineTest
    {
        private readonly AtmMachine _atm;
        public AtmMachineTest()
        {
            _atm = new AtmMachine();
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
        public void Atm_ShouldReturnOneBillOf10_When10IsRequested(int value, int of10, int of20, int of50, int of100)
        {
            var bills = _atm.Withdraw(value);
            Assert.Equal(of10, bills.Of10);
            Assert.Equal(of20, bills.Of20);
            Assert.Equal(of50, bills.Of50);
            Assert.Equal(of100, bills.Of100);
        }
    }
}
