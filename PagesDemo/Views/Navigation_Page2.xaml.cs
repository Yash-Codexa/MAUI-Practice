using PagesDemo.Utilities;
using PagesDemo.ViewModels;

namespace PagesDemo.Views;

public partial class Navigation_Page2 : ContentPage
{
	public Navigation_Page2()
	{
		InitializeComponent();

		BindingContext = new Navigation_Page2_ViewModel();
	}

	// public Navigation_Page2(string name)
	// {
	// 	InitializeComponent();
	// 	txtName.Text = name;
	// }
	protected override void OnAppearing()
	{
		base.OnAppearing();
		NavUtilities.Examine(Navigation);
	}
	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Navigation_Page3());
    }

	private void Button_Clicked1(object sender, EventArgs e)
	{
		Navigation.PopAsync();
    }
}