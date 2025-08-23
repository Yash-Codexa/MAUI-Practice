using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PagesDemo.Models;



public partial class FakePerson : ObservableObject
     {
          [ObservableProperty]
          [NotifyPropertyChangedFor(nameof(FullName))]
          private string firstName;
          [ObservableProperty]
          private string m_lastName;

          public string FullName
          {
               get
               {
                    return $"{FirstName} {LastName}";
               }
          }

        partial void OnFirstNameChanged(string value)
        {
               Console.WriteLine(value);
        }
    }
