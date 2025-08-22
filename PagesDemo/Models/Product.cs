using System;

namespace PagesDemo.Models;

public class Product
{
    public int Id{ get; set; }
    public string Name { get; set; }

    public decimal Price { get; set; }

    public string Images { get; set; }

    public int Stock { get; set; }

    public bool HasOffer { get; set; }
    
    public decimal OfferPrice{ get; set; }
    

}
