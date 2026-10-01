using System;

namespace Pattern06_SplitTemporaryVariable._3_Real
{
    internal class RealExample
    {
        public void CalculateTravelDistance(double primaryForce, double mass, int delay)
        {
            // Giai đoạn 1: Tăng tốc
            double primaryAcc = primaryForce / mass;
            double distancePhase1 = 0.5 * primaryAcc * delay * delay;

            // Giai đoạn 2: Gia tốc tích hợp thêm lực phụ
            double secondaryForce = 150.0;
            double secondaryAcc = (primaryForce + secondaryForce) / mass;
            double distancePhase2 = distancePhase1 + (primaryAcc * delay);

            Console.WriteLine($"Khoảng cách giai đoạn 1: {distancePhase1:N2}m");
            Console.WriteLine($"Khoảng cách giai đoạn 2: {distancePhase2:N2}m");
        }
    }
}