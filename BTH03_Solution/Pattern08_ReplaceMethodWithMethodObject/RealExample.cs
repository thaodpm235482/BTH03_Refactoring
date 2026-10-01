using System;

namespace Pattern08_ReplaceMethodWithMethodObject._3_Real
{
    public class LoanEvaluator
    {
        private double _income;
        private double _debt;

        public LoanEvaluator(double income, double debt)
        {
            _income = income;
            _debt = debt;
        }

        public void EvaluateRisk()
        {
            double debtToIncomeRatio = _debt / _income;
            bool isHighRisk = debtToIncomeRatio > 0.4;

            Console.WriteLine($"Tỷ lệ nợ/thu nhập: {debtToIncomeRatio:P1}");
            Console.WriteLine($"Đánh giá rủi ro: {(isHighRisk ? "RỦI RO CAO" : "AN TOÀN")}");
        }
    }

    internal class RealExample
    {
        public void ProcessLoan(double income, double debt)
        {
            LoanEvaluator evaluator = new LoanEvaluator(income, debt);
            evaluator.EvaluateRisk();
        }
    }
}