using System;

namespace Pattern08_ReplaceMethodWithMethodObject._2_After
{
    public class BeforeCode
    {
        public double Price(double primaryBasePrice, int quantity, double discount)
        {
            return new PriceCalculator(this, primaryBasePrice, quantity, discount).Compute();
        }
    }

    // Chuyển phương thức thành một Class riêng biệt (Method Object)
    public class PriceCalculator
    {
        private readonly BeforeCode _beforeCode;
        private double _primaryBasePrice;
        private int _quantity;
        private double _discount;
        private double _temp1;
        private double _temp2;

        public PriceCalculator(BeforeCode beforeCode, double primaryBasePrice, int quantity, double discount)
        {
            _beforeCode = beforeCode;
            _primaryBasePrice = primaryBasePrice;
            _quantity = quantity;
            _discount = discount;
        }

        public double Compute()
        {
            _temp1 = (_primaryBasePrice * _quantity) + 1.5;
            _temp2 = (_primaryBasePrice * _discount) + 100;
            if (_quantity > 50) _temp2 += 50;
            return _temp1 - _temp2;
        }
    }
}