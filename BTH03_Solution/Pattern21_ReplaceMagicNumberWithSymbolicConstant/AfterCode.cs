namespace Pattern21_ReplaceMagicNumberWithSymbolicConst
{
    public class AfterCode
    {
        private const double GravitationalConstant = 9.81;

        public double CalculatePotentialEnergy(double mass, double height)
        {
            return mass * GravitationalConstant * height;
        }
    }
}