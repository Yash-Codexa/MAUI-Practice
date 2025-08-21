using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using PropertyChanged;

namespace PagesDemo.ViewModels;

[AddINotifyPropertyChangedInterface]
public partial class NotifyPropertyChangedViewModel 
{

    public int Number1 { get; set; }
    public int Number2 { get; set; }
    public int Result { get; set; }

    public ICommand AddCommand => new Command(() => Result = Number1 + Number2);

    // private int result;
    // private int number1;
    // private int number2;

    // public int Number1 { get => number1; set
    //     {
    //         number1 = value;
    //         OnPropertyChanged();
    //     } }
    // public int Number2 { get => number2; set
    //     {
    //         number2 = value;
    //         OnPropertyChanged();
    //     }
    // }
    // public int Result
    // {
    //     get => result; set
    //     {
    //         result = value;
    //         OnPropertyChanged();
    //     }
    // }

    // public ICommand AddCommand => new Command(() => Result = Number1 + Number2);

    // public event PropertyChangedEventHandler? PropertyChanged;

    // protected void OnPropertyChanged([CallerMemberName] string propName=null)
    // {
    //     PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    // }

}
