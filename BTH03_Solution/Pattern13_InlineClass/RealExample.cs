namespace Pattern13_InlineClass._3_Real
{
    // Ví dụ thực tế: Gộp thông tin địa chỉ Ship trực tiếp vào Order thay vì tách class Address riêng không cần thiết
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; } = string.Empty;

        // Inline Address fields
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;

        public string GetFullShippingAddress()
        {
            return $"{Street}, {City} - {ZipCode}";
        }
    }

    public class RealExample
    {
        public void Run()
        {
            var order = new Order
            {
                OrderId = 101,
                CustomerName = "Nguyen Van A",
                Street = "123 Le Loi",
                City = "Ho Chi Minh",
                ZipCode = "70000"
            };

            System.Console.WriteLine($"Don hang #{order.OrderId} - Khach hang: {order.CustomerName}");
            System.Console.WriteLine($"Dia chi giao hang: {order.GetFullShippingAddress()}");
        }
    }
}