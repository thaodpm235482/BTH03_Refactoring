using System;

namespace Pattern15_RemoveMiddleMan._3_Real
{
    public class Engine
    {
        public void Start() => Console.WriteLine("Động cơ đã khởi động!");
    }

    public class Car
    {
        public Engine Engine { get; set; } = new Engine();
    }

    internal class RealExample
    {
        public void Run()
        {
            Car car = new Car();
            car.Engine.Start(); // Truy cập trực tiếp thay vì qua hàm bọc trung gian
        }
    }
}