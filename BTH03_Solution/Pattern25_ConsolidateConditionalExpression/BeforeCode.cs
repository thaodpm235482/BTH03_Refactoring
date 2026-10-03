namespace Pattern25_ConsolidateConditionalExpression
{
    public class BeforeCode
    {
        public double DisabilityAmount(int seniority, int monthsDisabled, bool isPartTime)
        {
            if (seniority < 2) return 0;
            if (monthsDisabled > 12) return 0;
            if (isPartTime) return 0;
            return 100.0;
        }
    }
}