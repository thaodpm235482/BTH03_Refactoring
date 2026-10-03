namespace Pattern18_ChangeValueToReference._1_Before
{
    public class Customer
    {
        public string Name { get; }
        public Customer(string name) => Name = name;
    }

    public class Order
    {
        // Mỗi đơn hàng lại new ra 1 Customer độc lập (Value Object)
        public Customer Customer { get; }
        public Order(string customerName) => Customer = new Customer(customerName);
    }
}