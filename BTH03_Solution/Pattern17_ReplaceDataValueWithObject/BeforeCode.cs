namespace Pattern17_ReplaceDataValueWithObject._1_Before
{
    public class Order
    {
        // Khách hàng chỉ lưu dưới dạng chuỗi đơn thuần
        public string Customer { get; set; }

        public Order(string customer)
        {
            Customer = customer;
        }
    }
}