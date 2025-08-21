using PagesDemo.ViewModels;

namespace PagesDemo.Views;

public partial class ConvertorsView : ContentPage
{
	public ConvertorsView()
	{
		InitializeComponent();

		BindingContext = new ConvertorsViewModel();
	}
}