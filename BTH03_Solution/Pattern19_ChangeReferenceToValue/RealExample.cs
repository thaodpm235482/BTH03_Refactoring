using System;

namespace Pattern19_ChangeReferenceToValue._3_Real
{
    internal class RealExample
    {
        public void Run()
        {
            _2_After.Currency c1 = new _2_After.Currency("USD");
            _2_After.Currency c2 = new _2_After.Currency("USD");

            Console.WriteLine($"So sánh giá trị 2 đồng tiền: {c1.Equals(c2)}");
        }
    }
}