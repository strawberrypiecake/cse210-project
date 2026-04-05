using System.Collections.Generic;
using System.Text;

public class Order
{
    public List<Product> products;
    public Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal GetTotalPrice()
    {
        decimal total = 0;

        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }

        decimal shipping = customer.LivesInUSA() ? 5m : 35m;
        return total + shipping;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder("Packing Label:\n");

        foreach (var product in products)
        {
            label.AppendLine($"{product.name} (ID: {product.productId})");
        }

        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.name}\n{customer.address.GetFullAddress()}";
    }
}
