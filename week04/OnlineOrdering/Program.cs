using System;

class Program
{
    static void Main(string[] args)
    {
       // Order 1 (USA)
        Address address1 = new Address("123 Main St", "Dallas", "TX", "USA");
        Customer customer1 = new Customer("Joe Dean", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Keyboard", "P1001", 25.99, 2));
        order1.AddProduct(new Product("Mouse", "P1002", 15.50, 1));

        // Order 2 (International)
        Address address2 = new Address("456 Moore St", "Gauteng", "GP", "South Africa");
        Customer customer2 = new Customer("Sphesihle Phekula", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop Stand", "P2001", 45.00, 1));
        order2.AddProduct(new Product("USB Hub", "P2002", 20.00, 2));
        order2.AddProduct(new Product("Webcam", "P2003", 60.00, 1));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");
        Console.WriteLine();

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
    
    }
}