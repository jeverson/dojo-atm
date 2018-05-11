using System;

namespace Atm
{
    public class AtmMachine : ICanWithdrawMoney
    {
        public MoneyAmount Withdraw(int valueToWithdraw)
        {
            var of100 = valueToWithdraw / 100;
            var remaining = valueToWithdraw % 100;

            var of50 = remaining / 50;
            remaining = remaining % 50;

            var of20 = remaining / 20;
            remaining = remaining % 20;

            var of10 = remaining / 10;

            return new MoneyAmount(of10, of20, of50, of100);
        }
    }
}