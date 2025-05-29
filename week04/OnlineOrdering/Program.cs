using System;

class Program
{
    static void Main(string[] args)
    {
        // First order (USA)
        var address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        var customer1 = new Customer("John Doe", address1);
        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A100", 999.99m, 1));
        order1.AddProduct(new Product("Mouse", "B200", 25.50m, 2));

        // Second order (International)
        var address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        var customer2 = new Customer("Jane Smith", address2);
        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Desk Lamp", "C300", 45.00m, 1));
        order2.AddProduct(new Product("Notebook", "D400", 3.75m, 3));
        order2.AddProduct(new Product("Pen Set", "E500", 12.00m, 1));

        // Display order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");
        Console.WriteLine(new string('-', 40));

        // Display order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
        Console.WriteLine(new string('-', 40));
    }
}
