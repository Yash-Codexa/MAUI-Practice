namespace ControlsDemo;

public partial class ActivityControllerDemo : ContentPage
{
	public ActivityControllerDemo()
	{
		InitializeComponent();
	}
	private void DisplayController_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new DisplayControllerDemo());
    }
}