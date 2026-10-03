using System;

namespace Pattern20_ReplaceArrayWithObject._3_Real
{
    public class SportsTeam
    {
        public string TeamName { get; set; } = "Manchester City";
        public int Score { get; set; } = 88;

        public void Display()
        {
            Console.WriteLine($"Đội: {TeamName} | Điểm số: {Score}");
        }
    }

    internal class RealExample
    {
        public void Run()
        {
            SportsTeam team = new SportsTeam();
            team.Display();
        }
    }
}