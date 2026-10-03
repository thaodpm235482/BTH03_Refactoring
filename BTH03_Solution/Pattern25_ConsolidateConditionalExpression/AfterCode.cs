namespace Pattern25_ConsolidateConditionalExpression
{
    public class AfterCode
    {
        public double DisabilityAmount(int seniority, int monthsDisabled, bool isPartTime)
        {
            if (IsNotEligibleForDisability(seniority, monthsDisabled, isPartTime))
                return 0;

            return 100.0;
        }

        private bool IsNotEligibleForDisability(int seniority, int monthsDisabled, bool isPartTime)
        {
            return seniority < 2 || monthsDisabled > 12 || isPartTime;
        }
    }
}