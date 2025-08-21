using System;
using PagesDemo.Models;

namespace PagesDemo.ViewModels;

public class PersonViewModel
{
    public Person Person{ get; set; }
    public PersonViewModel()
    {
        Person = new Person
        {
            Name = "Yash",
            Age = 19,
            Married = false,
            BirthDate = new DateTime(2005, 12, 29),
            Weight = 70,
            LunchTime=new TimeSpan(10,0,0)
        };
    }
        
}
