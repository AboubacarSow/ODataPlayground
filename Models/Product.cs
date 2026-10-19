using System.ComponentModel.DataAnnotations;

namespace OdataRESTAPI.Models;

public class Product
{
    public int Id {get; init;}
    public string Name{get;  set;}
    public double Price {get; set;}

    public Product()
    {
        Name = string.Empty;
    }

    public Product(string name,double price)
    {
        Name = name;
        Price  = price;
    }
}

internal record Category (int Id, string Name);