using System;
using System.Numerics;
using System.Reflection.Emit;


public class Order
{
    private List<Product> _products;
    private Customer _customer;


    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double OrderTotal()
    {
        int domestic = 5;
        int international = 35;
        double total = 0;

        if (_customer.LivesInUSA() == true)
        {
            foreach (Product product in _products)
            {
                total += product.ProductOrderTotal();
            }
            return total + domestic;
        }
        else
        {
            foreach (Product product in _products)
            {
                total += product.ProductOrderTotal();
            }
            return total + international;
        }
    }

    public string ShippingLabel()
    {
        return _customer.GetCustFullName() + "\n" + _customer.CustAddress();
    }

    public string PackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += ($"Product: {product.GetProductName()} (ID: {product.GetProductId()})\n");
        }

        return label;
    }
}