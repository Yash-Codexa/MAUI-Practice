using PagesDemo.Utilities;
using PagesDemo.ViewModels;

namespace PagesDemo.Views;

public partial class Navigation_Page1 : ContentPage
{
	public Navigation_Page1()
	{
		InitializeComponent();

		BindingContext = new Navigation_Page1_ViewModel();
	}
	
	protected override void OnAppearing()
	{
		base.OnAppearing();
		NavUtilities.Examine(Navigation);
	}
	private void Button_Clicked(System.Object sender, System.EventArgs e)
	{
		var currentViewModel = ((Navigation_Page1_ViewModel)BindingContext).Name;

		Navigation.PushAsync(new Navigation_Page2
		{
			BindingContext = new Navigation_Page2_ViewModel
			{
				Name = currentViewModel
			}
		});
	}
	private void Button_Clicked_1(System.Object sender, System.EventArgs e)
	{
		Navigation.PushAsync(new Navigation_Page3());
	}

	private void Button_Clicked1(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new Navigation_Page_Extra());
    }
}