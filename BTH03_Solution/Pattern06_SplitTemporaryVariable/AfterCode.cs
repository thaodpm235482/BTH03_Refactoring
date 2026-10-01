using System;

namespace Pattern06_SplitTemporaryVariable._2_After
{
    public class AfterCode
    {
        public void CalculateGeometry(double height, double width)
        {
            // Tách thành 2 biến riêng biệt có ý nghĩa rõ ràng
            double perimeter = 2 * (height + width);
            Console.WriteLine($"Chu vi: {perimeter}");

            double area = height * width;
            Console.WriteLine($"Diện tích: {area}");
        }
    }
}