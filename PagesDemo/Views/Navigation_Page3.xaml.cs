using PagesDemo.Utilities;

namespace PagesDemo.Views;

public partial class Navigation_Page3 : ContentPage
{
	public Navigation_Page3()
	{
		InitializeComponent();
	}
	protected override void OnAppearing()
	{
		base.OnAppearing();
		NavUtilities.Examine(Navigation);
    }
	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PopAsync();
    }

	private void Button_Clicked1(object sender, EventArgs e)
	{
		Navigation.PopToRootAsync();
    }

	private void Button_Clicked2(object sender, EventArgs e)
	{
		NavUtilities.InsertPage(Navigation);
    }

	private void Button_Clicked3(object sender, EventArgs e)
	{
		NavUtilities.DeletePage(Navigation, "Navigation_Page_Extra");
    }
}