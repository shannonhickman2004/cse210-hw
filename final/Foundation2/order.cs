using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(string customerName, Address customerAddress)
    {
        _customer = new Customer(customerName, customerAddress);
        _products = new List<Product>();
    }

    public void AddProduct(string name, string productId, double price, int quantity)
    {
        _products.Add(new Product(name, productId, price, quantity));
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        totalCost += _customer.IsInUSA() ? 5 : 35;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (var product in _products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = _customer.GetName() + "\n";
        shippingLabel += _customer.GetAddress();
        return shippingLabel;
    }
}
