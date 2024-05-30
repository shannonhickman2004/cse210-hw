using System;

class Program
{
    static void Main(string[] args)
    {
        // List of addresses
        Address address1 = new Address("13856 S Carnoustie", "Herriman", "UT", "USA");
        Address address2 = new Address("45 Hedgehog", "Toronto", "ON", "Canada");

        // List of orders
        Order order1 = new Order("Kaitlin Smith", address1);
        order1.AddProduct("Laptop", "Chrome525", 1553, 1);
        order1.AddProduct("Monitor", "Monitor123", 313, 2);

        Order order2 = new Order("Jane Smith", address2);
        order2.AddProduct("Keyboard", "Key323", 35, 1);
        order2.AddProduct("Mouse", "Mouse12", 40, 1);

        // Order details
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}
