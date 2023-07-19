using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "City 1", "State 1", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Product 1", "P1", 10.5m, 2);
        Product product2 = new Product("Product 2", "P2", 15.25m, 3);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        decimal totalPrice1 = order1.CalculateTotalPrice();
        string packingLabel1 = order1.GetPackingLabel();
        string shippingLabel1 = order1.GetShippingLabel();

        Console.WriteLine("Order 1:");
        Console.WriteLine("Total Price: $" + totalPrice1);
        Console.WriteLine("Packing Label:\n" + packingLabel1);
        Console.WriteLine("Shipping Label:\n" + shippingLabel1);
        Console.WriteLine();

        Address address2 = new Address("456 Elm St", "City 2", "State 2", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);

        Product product3 = new Product("Product 3", "P3", 20.0m, 1);
        Product product4 = new Product("Product 4", "P4", 12.75m, 2);
        Product product5 = new Product("Product 5", "P5", 8.0m, 4);

        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        decimal totalPrice2 = order2.CalculateTotalPrice();
        string packingLabel2 = order2.GetPackingLabel();
        string shippingLabel2 = order2.GetShippingLabel();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Total Price: $" + totalPrice2);
        Console.WriteLine("Packing Label:\n" + packingLabel2);
        Console.WriteLine("Shipping Label:\n" + shippingLabel2);
        Console.WriteLine();
    }
}