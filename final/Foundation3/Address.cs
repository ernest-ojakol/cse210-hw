public class Address{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string state, string country){
        _streetAddress=streetAddress;
        _city=city;
        _stateProvince=state;
        _country=country;
    }

    public string GetStreetAddress(){
        return _streetAddress;
    }

    public string GetCity(){
        return _city;
    }

    public string GetStateProvince(){
        return _stateProvince;
    }

    public string GetCountry(){
        return _country;
    }

    public string GetAddressString(){
        return $"{_streetAddress}, {_city}, {_stateProvince}, {_country}";
    }
}