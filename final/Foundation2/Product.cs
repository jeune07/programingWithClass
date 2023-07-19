using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; }
    public string ProductId { get; }
    public decimal Price { get; }
    public int Quantity { get; }

    public Product(string _name, string _productId, decimal _price, int _quantity)
    {
        Name = _name;
        ProductId = _productId;
        Price = _price;
        Quantity = _quantity;
    }

    public decimal GetTotalPrice()
    {
        return Price * Quantity;
    }
}

