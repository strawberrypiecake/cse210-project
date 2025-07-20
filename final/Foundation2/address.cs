public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.Trim().ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
    }

    public void SetStreet(string street) => _street = street;
    public void SetCity(string city) => _city = city;
    public void SetState(string state) => _stateOrProvince = state;
    public void SetCountry(string country) => _country = country;

    public string GetStreet() => _street;
    public string GetCity() => _city;
    public string GetState() => _stateOrProvince;
    public string GetCountry() => _country;
}