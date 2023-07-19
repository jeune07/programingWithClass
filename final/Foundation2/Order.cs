using System;
using System.Collections.Generic;

class Order
{
    private List<Product> products;
    public Customer Customer { get; }

    public Order(Customer _customer)
    {
        products = new List<Product>();
        Customer = _customer;
    }

    public void AddProduct(Product _product)
    {
        products.Add(_product);
    }

    public decimal CalculateTotalPrice()
    {
        decimal _totalPrice = 0;
        foreach (Product _product in products)
        {
            _totalPrice += _product.GetTotalPrice();
        }

        decimal _shippingCost = Customer.IsInUSA() ? 5 : 35;
        _totalPrice += _shippingCost;

        return _totalPrice;
    }

    public string GetPackingLabel()
    {
        string _packingLabel = "";
        foreach (Product _product in products)
        {
            _packingLabel += $"Product: {_product.Name}, ID: {_product.ProductId}\n";
        }

        return _packingLabel;
    }

    public string GetShippingLabel()
    {
        string _shippingLabel = "";
        _shippingLabel += $"Customer Name: {Customer.Name}\n";
        _shippingLabel += $"Address:\n{Customer.Address.GetAddressDetails()}";

        return _shippingLabel;
    }
}