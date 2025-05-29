using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(new Customer("Janet", "Jackson", new Address("123 Sunnyside Dr", "Sun City", "GA", "12345", "USA")));
        order1.AddProduct(new Product("shoes", 343434, 37.55, 1));
        order1.AddProduct(new Product("socks", 87543, 17.60, 2));
        order1.AddProduct(new Product("shirt", 989654, 41.22, 1));
        order1.AddProduct(new Product("shirt", 384773, 32, 1));

        Console.WriteLine();
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total: ${order1.OrderTotal():F2}");
        Console.WriteLine("\n-------------------------------");

        Order order2 = new Order(new Customer("Kent", "Thompson", new Address("173 Russell Way", "Sun City", "London", "W1P GHQ", "UK")));
        order2.AddProduct(new Product("16g wire spool", 23452, 18.99, 3));
        order2.AddProduct(new Product("wrench", 23687, 14.60, 1));
        order2.AddProduct(new Product("hammor", 2958569, 24.50, 1));

        Console.WriteLine();
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total: ${order2.OrderTotal():F2}");
        Console.WriteLine("\n-------------------------------");

    }
}