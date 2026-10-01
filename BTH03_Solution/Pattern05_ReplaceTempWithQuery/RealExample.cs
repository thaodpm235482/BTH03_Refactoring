using System;

namespace Pattern05_ReplaceTempWithQuery._3_Real
{
    internal class RealExample
    {
        private double _workedHours = 45;
        private double _hourlyRate = 100000;

        public void DisplaySalaryInfo()
        {
            Console.WriteLine($"Lương cơ bản: {GetBaseSalary():N0} VNĐ");
            Console.WriteLine($"Lương tăng ca: {GetOvertimeSalary():N0} VNĐ");
            Console.WriteLine($"Thực nhận: {GetTotalSalary():N0} VNĐ");
        }

        private double GetBaseSalary() => Math.Min(_workedHours, 40) * _hourlyRate;
        private double GetOvertimeSalary() => Math.Max(0, _workedHours - 40) * _hourlyRate * 1.5;
        private double GetTotalSalary() => GetBaseSalary() + GetOvertimeSalary();
    }
}