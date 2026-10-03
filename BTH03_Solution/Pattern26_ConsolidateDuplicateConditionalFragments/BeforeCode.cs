namespace Pattern26_ConsolidateDuplicateConditionalFragments
{
    public class BeforeCode
    {
        public void ProcessOrder(bool isSpecialDeal, double price)
        {
            double total;
            if (isSpecialDeal)
            {
                total = price * 0.95;
                SendHeader(total);
            }
            else
            {
                total = price * 0.98;
                SendHeader(total);
            }
        }

        private void SendHeader(double total) { }
    }
}