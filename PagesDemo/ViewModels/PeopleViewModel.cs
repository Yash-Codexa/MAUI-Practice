using System;
using PagesDemo.Models;

namespace PagesDemo.ViewModels;

public class PeopleViewModel
{
    public List<Person> People { get; set; } = new List<Person>(); 

    public PeopleViewModel()
    {
        People.Add(new Person() { Name="Yash",Age=19,Married=false,BirthDate = new DateTime(2005, 12, 29),Weight = 70,LunchTime=new TimeSpan(10,0,0)});
        People.Add(new Person() { Name="Virat",Age=19,Married=true,BirthDate = new DateTime(2001, 2, 4),Weight = 55,LunchTime=new TimeSpan(11,0,0)});
        People.Add(new Person() { Name="Ansh",Age=19,Married=false,BirthDate = new DateTime(2006, 5, 6),Weight = 60,LunchTime=new TimeSpan(1,0,0)});
        People.Add(new Person() { Name="Raj",Age=19,Married=true,BirthDate = new DateTime(2000, 6, 12),Weight = 66,LunchTime=new TimeSpan(12,0,0)});
        People.Add(new Person() { Name="Sarvil",Age=19,Married=false,BirthDate = new DateTime(2002, 7, 8),Weight = 88,LunchTime=new TimeSpan(5,0,0)});
    }
}
