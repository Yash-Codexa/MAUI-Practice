using System;

namespace PagesDemo.Models;

public class ProductsGroup : List<Product>
{
    public string Name { get; set; }

    public ProductsGroup(string name, List<Product> products) : base(products)
    {
        Name = name;
    }
}
