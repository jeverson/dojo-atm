using System;

namespace Atm
{
    public interface ICanWithdrawMoney
    {
        MoneyAmount Withdraw(int value);
    }
}
