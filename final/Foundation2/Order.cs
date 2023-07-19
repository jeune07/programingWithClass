using System;
using System.Collections.Generic;

class Order
{
    private List<Product> products;
    public Customer Customer { get; }

    public Order(Customer customer)
    {
        products = new List<Product>();
        Customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (Product product in products)
        {
            totalPrice += product.GetTotalPrice();
        }

        decimal shippingCost = Customer.IsInUSA() ? 5 : 35;
        totalPrice += shippingCost;

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += $"Product: {product.Name}, ID: {product.ProductId}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "";
        shippingLabel += $"Customer Name: {Customer.Name}\n";
        shippingLabel += $"Address:\n{Customer.Address.GetAddressDetails()}";

        return shippingLabel;
    }
}