namespace Pattern26_ConsolidateDuplicateConditionalFragments
{
    public class AfterCode
    {
        public void ProcessOrder(bool isSpecialDeal, double price)
        {
            double total;
            if (isSpecialDeal)
                total = price * 0.95;
            else
                total = price * 0.98;

            SendHeader(total); // Đưa đoạn code trùng lặp ra ngoài điều kiện
        }

        private void SendHeader(double total) { }
    }
}