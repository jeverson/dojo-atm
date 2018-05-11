using System;

namespace Atm
{
    public class AtmMachine : ICanWithdrawMoney
    {
        private readonly IMoneyCounter counter;

        public AtmMachine(IMoneyCounter counter)
        {
            this.counter = counter;
        }

        public MoneyAmount Withdraw(int valueToWithdraw)
        {
            return counter.GetMinimalNumberOfBills(valueToWithdraw);
        }
    }
}