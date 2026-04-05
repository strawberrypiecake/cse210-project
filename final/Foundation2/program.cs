using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Widget A", "W001", 9.99m, 3));
        order1.AddProduct(new Product("Widget B", "W002", 14.99m, 1));
        order1.AddProduct(new Product("Widget C", "W003", 4.99m, 5));

        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Gadget X", "G001", 24.99m, 2));
        order2.AddProduct(new Product("Gadget Y", "G002", 49.99m, 1));

        foreach (Order order in new[] { order1, order2 })
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalPrice():F2}");
            Console.WriteLine(new string('-', 40));
        }

        Console.ReadKey();
    }
}
