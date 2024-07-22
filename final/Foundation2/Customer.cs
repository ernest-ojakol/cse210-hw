public class Customer{
    private string _name;
    private Address _address;

    public Customer(string name, Address address){
        _name=name;
        _address=address;
    }

    public string GetName(){
        return _name;
    }

    public Address GetAddress(){
        return _address;
    }

    public bool IsInTheUSA(){
        if(_address.GetCountry().Equals("USA")){
            return true;
        }else{
            return false;
        }
    }

    public string GetShippingLabel(){
        return $"{_name} | {_address.GetAddressString()}";
    }
}