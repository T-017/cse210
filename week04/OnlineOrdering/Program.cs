using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Orders from USA:");

        Address address1 = new Address("123 Main St", "Anytown", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25.50, 1));
        order1.AddProduct(new Product("Keyboard", "P003", 45.00, 1));
        order1.AddProduct(new Product("Monitor", "P004", 199.99, 2));
        order1.AddProduct(new Product("USB Cable", "P005", 10.00, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\n" + order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order1.GetTotalCost():F2}\n");


        Console.WriteLine("Orders from outside USA:");

        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", "P006", 299.99, 1));
        order2.AddProduct(new Product("Headphones", "P007", 89.99, 1));
        order2.AddProduct(new Product("Charger", "P008", 19.99, 1));
        order2.AddProduct(new Product("Case", "P009", 29.99, 1));
        order2.AddProduct(new Product("Screen Protector", "P010", 15.00, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\n" + order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order2.GetTotalCost():F2}\n");
    }
}