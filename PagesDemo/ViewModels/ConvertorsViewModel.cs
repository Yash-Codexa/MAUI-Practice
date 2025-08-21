using System;
using PagesDemo.Models;

namespace PagesDemo.ViewModels;

public class ConvertorsViewModel
{
    public Data Data { get; set; }

    public ConvertorsViewModel()
    {
        Data = new Data()
        {
            Married="Yes"
        };
    }
}
