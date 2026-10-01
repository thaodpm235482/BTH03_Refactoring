using System;

namespace Pattern10_MoveMethod._3_Real
{
    public class ShippingCarrier
    {
        public string Name { get; set; } = "Giao Hàng Nhanh";
        public double BaseRate { get; set; } = 30000;

        // Chuyển hàm tính phí vận chuyển vào đúng lớp ShippingCarrier
        public double CalculateFee(double weightKg)
        {
            return BaseRate + (weightKg * 5000);
        }
    }

    internal class RealExample
    {
        public void ProcessShipping()
        {
            ShippingCarrier carrier = new ShippingCarrier();
            double packageWeight = 2.5; // 2.5 kg
            double fee = carrier.CalculateFee(packageWeight);

            Console.WriteLine($"Đơn vị vận chuyển: {carrier.Name}");
            Console.WriteLine($"Khối lượng: {packageWeight} kg");
            Console.WriteLine($"Phí giao hàng: {fee:N0} VNĐ");
        }
    }
}