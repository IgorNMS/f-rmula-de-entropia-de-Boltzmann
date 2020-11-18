using System;

namespace EntropyCalc
{
    public class BoltzmanConst
    {
        public decimal Constant()
        {
            Decimal Const = 1.3807m;
            double Power;

            Power = Math.Pow(10, -23);
            return Const * (decimal)Power;
        }
    }
}