using System;

public class Product
{
    private string _productName;
    private int _productId;
    private double _price;
    private int _qty;

    public Product(string product, int productId, double price, int qty)
    {
        _productName = product;
        _productId = productId;
        _price = price;
        _qty = qty;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductId()
    {
        return _productId;
    }

    public double ProductOrderTotal()
    {
        return _price * _qty;
    }

}