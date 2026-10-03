using System;

namespace Pattern18_ChangeValueToReference._3_Real
{
    internal class RealExample
    {
        public void Run()
        {
            _2_After.Order order1 = new _2_After.Order("Công ty A");
            _2_After.Order order2 = new _2_After.Order("Công ty A");

            bool isSameReference = ReferenceEquals(order1.Customer, order2.Customer);
            Console.WriteLine($"Hai đơn hàng dùng chung 1 đối tượng Khách hàng: {isSameReference}");
        }
    }
}