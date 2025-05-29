using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _postalCode;
    private string _country;

    public Address(string address, string city, string stateProvince, string postalCode, string country)
    {
        _streetAddress = address;
        _city = city;
        _stateProvince = stateProvince;
        _postalCode = postalCode;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA" || _country.ToUpper() == "US";
    }


    public string GetFormattedAddress()
    {
        return _streetAddress + "\n" + _city + ", " + _stateProvince + _postalCode + "\n" + _country; 
    }
}