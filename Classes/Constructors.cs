#region Constructors

#endregion

namespace Classes;

public static class Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id) 
            : this()
        {
            Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            Name = name;
        }
    }

    public class Order
    {
    }

    public static void ConstructorsProgram()
    {
        Console.WriteLine("Start -> Constructors");

        var customer = new Customer();

        var order = new Order();

        customer.Orders.Add(order);

        Console.WriteLine("Finish -> Constructors");
    }
}