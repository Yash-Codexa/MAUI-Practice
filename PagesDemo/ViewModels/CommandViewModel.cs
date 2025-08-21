using System;
using System.Windows.Input;
using CommunityToolkit.Maui.Extensions;
using PagesDemo.Views;

namespace PagesDemo.ViewModels;

public class CommandViewModel
{
    public ICommand ClickCommand { get; }
    public ICommand SearchCommand { get; }

    public string SearchTerm{ get; set; }

    public CommandViewModel()
    {
        ClickCommand = new Command(Alert);

        SearchCommand = new Command((s) =>
        {
            var data = s;
        }
        );
    }

    private void Alert()
    {
        App.Current.MainPage.DisplayAlert("Title", "message", "Ok");
    }
}
