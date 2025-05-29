using System;


public class Customer
{
    private string _firstName;
    private string _lastName;
    private Address _address;

    public Customer(string firstName, string lastName, Address address)
    {
        _firstName = firstName;
        _lastName = lastName;
        _address = address;
    }

    public string GetCustFullName()
    {
        return _firstName + " " + _lastName;
    }

    public string CustAddress()
    {
        return _address.GetFormattedAddress();
    }
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}