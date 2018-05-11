using System.Collections.Generic;

namespace Atm
{
    public class MoneyAmount
    {
        public MoneyAmount(int of10, int of20, int of50, int of100)
        {
            Of10 = of10;
            Of20 = of20;
            Of50 = of50;
            Of100 = of100;
        }

        public int Of10 { get; private set; }
        public int Of20 { get; private set; }
        public int Of50 { get; private set; }
        public int Of100 { get; private set; }
    }
}