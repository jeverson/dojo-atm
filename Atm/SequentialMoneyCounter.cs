using System;

namespace Atm
{
    public class SequentialMoneyCounter : IMoneyCounter
    {
        public MoneyAmount GetMinimalNumberOfBills(int value)
        {
            var of100 = value / 100;
            var remaining = value % 100;

            var of50 = remaining / 50;
            remaining = remaining % 50;

            var of20 = remaining / 20;
            remaining = remaining % 20;

            var of10 = remaining / 10;

            return new MoneyAmount(of10, of20, of50, of100);
        }
    }
}