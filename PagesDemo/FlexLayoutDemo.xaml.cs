using ControlsDemo;

namespace LayoutDemo;

public partial class FlexLayoutDemo : ContentPage
{
	public FlexLayoutDemo()
	{
		InitializeComponent();
	}
	private void PresentationController_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new PresentationControlsDemo());
	}
}