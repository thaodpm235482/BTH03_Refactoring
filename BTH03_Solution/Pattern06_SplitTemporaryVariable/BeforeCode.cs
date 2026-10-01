using System;

namespace Pattern06_SplitTemporaryVariable._1_Before
{
    public class BeforeCode
    {
        public void CalculateGeometry(double height, double width)
        {
            // Biến temp được tái sử dụng cho 2 mục đích hoàn toàn khác nhau
            double temp = 2 * (height + width);
            Console.WriteLine($"Chu vi: {temp}");

            temp = height * width;
            Console.WriteLine($"Diện tích: {temp}");
        }
    }
}