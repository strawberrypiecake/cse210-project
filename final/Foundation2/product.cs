public class Product
{
    public string name;
    public string productId;
    public decimal pricePerUnit;
    public int quantity;

    public Product(string name, string productId, decimal pricePerUnit, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return pricePerUnit * quantity;
    }
}
