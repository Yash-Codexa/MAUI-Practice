using PagesDemo.Utilities;

namespace PagesDemo.Views;

public partial class Navigation_Page_Extra : ContentPage
{
	public Navigation_Page_Extra()
	{
		InitializeComponent();

	}
	protected override void OnAppearing()
	{
		base.OnAppearing();
		NavUtilities.Examine(Navigation);
    }

    protected override bool OnBackButtonPressed()
    {
        return true;
    }

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PopModalAsync();
	}
}