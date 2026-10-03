namespace Pattern17_ReplaceDataValueWithObject._2_After
{
    public class Customer
    {
        public string Name { get; }
        public Customer(string name) => Name = name;
    }

    public class Order
    {
        // Thay biến chuỗi bằng đối tượng Customer
        public Customer Customer { get; set; }

        public Order(string customerName)
        {
            Customer = new Customer(customerName);
        }
    }
}