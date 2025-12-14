
class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Mini Cooper Cookie", "3", 5.99, 2);
        Product product2 = new Product("Gotcha shake", "6", 10.99, 1);
        Product product3 = new Product("Don't order this please", "2", 99.99, 5);
        Product product4 = new Product("Coolguy special", "4", 1.99, 1);

        Address address1 = new Address("555 Nuggets St", "Realplace", "UT", "USA");
        Customer customer1 = new Customer("Food Lover", address1);
        Order order1 = new Order();

        order1.AddToCart(product2);
        order1.AddToCart(product4);
        order1.packingLabel();
        order1.shippingLabel(address1, customer1);
        order1.displayTotalCost(address1);

        Console.WriteLine();

        Address address2 = new Address("123 Frenchfry St", "Realplace", "UT", "USA");
        Customer customer2 = new Customer("Burger Mcburger Face", address2);
        Order order2 = new Order();

        order2.AddToCart(product3);
        order2.AddToCart(product4);
        order2.packingLabel();
        order2.shippingLabel(address2, customer2);
        order2.displayTotalCost(address2);

        Console.WriteLine();

        Address address3 = new Address("404 Notfound St", "Realplace", "UT", "USA");
        Customer customer3 = new Customer("Missingno", address3);
        Order order3 = new Order();

        order3.AddToCart(product3);
        order3.AddToCart(product2);
        order3.AddToCart(product1);
        order3.AddToCart(product4);
        order3.packingLabel();
        order3.shippingLabel(address3, customer3);
        order3.displayTotalCost(address3);
    }
}