using PagesDemo;

namespace ControlsDemo;

public partial class DisplayControllerDemo : ContentPage
{
	public DisplayControllerDemo()
	{
		InitializeComponent();
	}
	private void ColorMaker_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ColorMaker_Home());
    }
}