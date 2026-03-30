using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation2 World!");
        Address address1 = new Address("Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Bob", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("Book", 1, 20, 3);
        Product product2 = new Product("DVD", 2, 15, 2);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total cost: ${order1.CalculateTotal()}");
        Console.WriteLine();
        Address address2 = new Address("123 NW 1st St", "Portland", "OR", "USA");
        Customer customer2 = new Customer("Robert", address2);
        Order order2 = new Order(customer2);
        Product product3 = new Product("Laptop", 3, 300, 1);
        Product product4 = new Product("Game", 4, 50, 2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total cost: ${order2.CalculateTotal()}");
    }
}