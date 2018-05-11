using System;

namespace Atm
{
    public interface IMoneyCounter
    {
        MoneyAmount GetMinimalNumberOfBills(int value);
    }
}