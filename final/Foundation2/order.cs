using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();

    public void AddToCart(Product product)
    {
        _products.Add(product);
    }

    public void packingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.getProductID()}: {product.getProductName()}");
        }
    }

    public void shippingLabel(Address address, Customer customer)
    {
        Console.WriteLine(address.GetShippingLabel(customer));
    }

    public void displayTotalCost(Address address)
    {
        Console.WriteLine($"Total: {totalCost(address)}");
    }

    private double calculateCost()
    {
        double cost = 0;
        foreach (Product p in _products)
        {
            cost += p.getPrice() * p.getQuantity();
        }
        return cost;
    }

    private double calculateShippingCost(Address address)
    {
        return (address.GetCountry() == "USA") ? 5 : 35;
    }

    private double totalCost(Address address)
    {
        return calculateCost() + calculateShippingCost(address);
    }
}