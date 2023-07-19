using System;

class Program
{
    static void Main(string[] args)
    {
        Address _address1 = new Address("123 Main St", "City 1", "State 1", "USA");
        Customer _customer1 = new Customer("John Doe", _address1);
        Order _order1 = new Order(_customer1);

        Product _product1 = new Product("Product 1", "P1", 10.5m, 2);
        Product _product2 = new Product("Product 2", "P2", 15.25m, 3);

        _order1.AddProduct(_product1);
        _order1.AddProduct(_product2);

        decimal totalPrice1 = _order1.CalculateTotalPrice();
        string packingLabel1 = _order1.GetPackingLabel();
        string shippingLabel1 = _order1.GetShippingLabel();

        Console.WriteLine("Order 1:");
        Console.WriteLine("Total Price: $" + totalPrice1);
        Console.WriteLine("Packing Label:\n" + packingLabel1);
        Console.WriteLine("Shipping Label:\n" + shippingLabel1);
        Console.WriteLine();

        Address _address2 = new Address("456 Elm St", "City 2", "State 2", "Canada");
        Customer _customer2 = new Customer("Jane Smith", _address2);
        Order _order2 = new Order(_customer2);

        Product _product3 = new Product("Product 3", "P3", 20.0m, 1);
        Product _product4 = new Product("Product 4", "P4", 12.75m, 2);
        Product _product5 = new Product("Product 5", "P5", 8.0m, 4);

        _order2.AddProduct(_product3);
        _order2.AddProduct(_product4);
        _order2.AddProduct(_product5);

        decimal _totalPrice2 = _order2.CalculateTotalPrice();
        string _packingLabel2 = _order2.GetPackingLabel();
        string _shippingLabel2 = _order2.GetShippingLabel();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Total Price: $" + _totalPrice2);
        Console.WriteLine("Packing Label:\n" + _packingLabel2);
        Console.WriteLine("Shipping Label:\n" + _shippingLabel2);
        Console.WriteLine();
    }
}