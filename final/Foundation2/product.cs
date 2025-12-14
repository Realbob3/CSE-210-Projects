public class Product
{
    private string _productName;
    private string _productID;
    private double _productPrice;
    private double _productQuantity;

    public string getProductName()
    {
        return _productName;
    }

    public string getProductID()
    {
        return _productID;
    }

    public double getPrice()
    {
        return _productPrice;
    }

    public double getQuantity()
    {
        return _productQuantity;
    }

    public Product(string productName, string productID, double productPrice, int productQuantity)
    {
        _productName   = productName;
        _productID     = productID;
        _productPrice  = productPrice;
        _productQuantity = productQuantity;
    }
}