using System;

namespace Pattern08_ReplaceMethodWithMethodObject._1_Before
{
    public class BeforeCode
    {
        public double Price(double primaryBasePrice, int quantity, double discount)
        {
            // Hàm quá dài chứa nhiều biến tạm chéo nhau
            double delta = 1.5;
            double temp1 = (primaryBasePrice * quantity) + delta;
            double temp2 = (primaryBasePrice * discount) + 100;
            if (quantity > 50) temp2 += 50;
            return temp1 - temp2;
        }
    }
}