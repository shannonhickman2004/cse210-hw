using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(string customerName, Address customerAddress)
    {
        customer = new Customer(customerName, customerAddress);
        products = new List<Product>();
    }

    public void AddProduct(string name, string productId, double price, int quantity)
    {
        products.Add(new Product(name, productId, price, quantity));
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }
        totalCost += customer.IsInUSA() ? 5 : 35;
        return totalCost;
    }

 public string GetPackingLabel()
{
    string packingLabel = "";
    foreach (var product in products)
    {
        packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
    }
    return packingLabel;
}

public string GetShippingLabel()
{
    string shippingLabel = customer.GetName() + "\n";
    shippingLabel += customer.GetAddress();
    return shippingLabel;
}
}
