using PagesDemo.ViewModels;

namespace PagesDemo.Views;

public partial class NotifyPropertyChanged : ContentPage
{
	public NotifyPropertyChanged()
	{
		InitializeComponent();
		BindingContext = new NotifyPropertyChangedViewModel();
	}
}