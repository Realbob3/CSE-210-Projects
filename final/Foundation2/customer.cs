public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public string GetCustomer()
    {
        return _customerName;
    }

    public Customer(string customerName, Address customerAddress)
    {
        _customerName   = customerName;
        _customerAddress = customerAddress;
    }
}