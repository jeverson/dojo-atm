using System;

namespace Atm
{
    public class LoopingMoneyCounter : IMoneyCounter
    {
        public MoneyAmount GetMinimalNumberOfBills(int value)
        {
            var billTypes = new int[] {100, 50, 20, 10};
            var numberOfBills = new int[4];
            
            var remaining = value;
        
            for(var i = 0; i < billTypes.Length; i++) {
                numberOfBills[i] = remaining / billTypes[i];
                remaining = remaining % billTypes[i];
            }

            return new MoneyAmount(numberOfBills[3], numberOfBills[2],  numberOfBills[1],  numberOfBills[0]);
        }
    }
}