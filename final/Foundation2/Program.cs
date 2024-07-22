using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1=new Address("Mutungo Zone 4, Cecilia Road, 10","Kampala","Central","Uganda");
        Customer customer1=new Customer("Ernest Ojakol",address1);
        Product product1=new Product("Pampers",101,71000.00,1);
        Product product2=new Product("Coke Zero",102,1000.00,4);
        Product product3=new Product("Cakes",103,500.00,4);
        List<Product> products1 = new List<Product>{product1,product2,product3};
        Order order1=new Order(products1,customer1);

        Address address2=new Address("41st Browning Street","South Park","Colorado","USA");
        Customer customer2=new Customer("Eric Cartman",address2);
        Product product4=new Product("Diet Coke",101,7.00,1);
        Product product5=new Product("Pizza",102,20.00,1);
        Product product6=new Product("Chipotle",103,30.00,2);
        List<Product> products2 = new List<Product>{product4,product5,product6};
        Order order2=new Order(products2,customer2);

        Console.WriteLine($"Order 1 Packing Label:\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Order 1 Shipping Label: {order1.GetShippingLabel()}");
        Console.WriteLine($"Order 1 Total Cost: {order1.GetTotalPrice()}\n\n");

        Console.WriteLine($"Order 2 Packing Label:\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Order 2 Shipping Label: {order2.GetShippingLabel()}");
        Console.WriteLine($"Order 2 Total Cost: {order2.GetTotalPrice()}\n\n");

    }
}