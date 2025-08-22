using PagesDemo.ViewModels;

namespace PagesDemo.Views;

public partial class Calculator_View : ContentPage
{
	public Calculator_View()
	{
		InitializeComponent();

		BindingContext = new Calculator_ViewModel();
	}
}