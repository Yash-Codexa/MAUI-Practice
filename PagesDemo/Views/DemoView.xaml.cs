using PagesDemo.ViewModels;

namespace PagesDemo.Views;

public partial class DemoView : ContentPage
{
	public DemoView()
	{
		InitializeComponent();

		BindingContext = new DemoViewModel();
	}
}