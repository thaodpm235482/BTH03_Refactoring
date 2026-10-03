using System;

namespace Pattern16_SelfEncapsulateField._3_Real
{
    public class TemperatureRange
    {
        private double _celsius;

        public double Celsius
        {
            get => _celsius;
            set => _celsius = Math.Max(-273.15, value); // Đảm bảo đóng gói có validation
        }

        public bool IsFreezing() => Celsius <= 0;
    }

    internal class RealExample
    {
        public void Run()
        {
            TemperatureRange temp = new TemperatureRange();
            temp.Celsius = -5;
            Console.WriteLine($"Nhiệt độ âm: {temp.IsFreezing()}");
        }
    }
}