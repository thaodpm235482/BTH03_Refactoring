using System.Collections.Generic;

namespace Pattern18_ChangeValueToReference._2_After
{
    public class Customer
    {
        public string Name { get; }
        private static readonly Dictionary<string, Customer> _instances = new Dictionary<string, Customer>();

        private Customer(string name) => Name = name;

        // Quản lý tập trung để dùng chung tham chiếu (Reference)
        public static Customer GetNamed(string name)
        {
            if (!_instances.ContainsKey(name))
            {
                _instances[name] = new Customer(name);
            }
            return _instances[name];
        }
    }

    public class Order
    {
        public Customer Customer { get; }
        public Order(string customerName) => Customer = Customer.GetNamed(customerName);
    }
}