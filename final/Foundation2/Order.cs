public class Order{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> product,Customer customer){
        _products=product;
        _customer=customer;
    }

    public List<Product> GetProducts(){
        return _products;
    }

    public Customer GetCustomer(){
        return _customer;
    }

    public int GetShippingCost(){
        if(_customer.IsInTheUSA()){
            return 5;
        }else{
            return 35;
        }
    }

    public string GetPackingLabel(){
        string packingLabel="";

        foreach(Product product in _products){
            packingLabel=packingLabel+$"{product.GetProductId()} | {product.GetName()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel(){
        return $"{_customer.GetShippingLabel()}";
    }

    public double GetTotalPrice(){
        double totalPrice=0.0;
        foreach(Product product in _products){
            double cost=product.GetTotalCost();
            totalPrice=totalPrice+cost;
        }
        totalPrice=totalPrice+GetShippingCost();
        return totalPrice;
    }
}