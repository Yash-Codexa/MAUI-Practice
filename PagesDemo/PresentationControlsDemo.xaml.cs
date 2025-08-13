namespace ControlsDemo;

public partial class PresentationControlsDemo : ContentPage
{
	public PresentationControlsDemo()
	{
		InitializeComponent();
	}

	private void CMDController_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new CommandInitiaterControllsDemo());
    }
}