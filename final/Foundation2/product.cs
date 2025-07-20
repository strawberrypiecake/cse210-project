public class Product
{
    private string _name;
    private string _productId;
    private decimal _pricePerUnit;
    private int _quantity;

    public Product(string name, string productId, decimal pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public string GetName() => _name;
    public string GetProductId() => _productId;
    public decimal GetTotalCost() => _pricePerUnit * _quantity;

    public void SetName(string name) => _name = name;
    public void SetProductId(string id) => _productId = id;
    public void SetPricePerUnit(decimal price) => _pricePerUnit = price;
    public void SetQuantity(int qty) => _quantity = qty;
}