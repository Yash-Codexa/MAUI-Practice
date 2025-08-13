namespace ControlsDemo;

public partial class ValueControllerDemo : ContentPage
{
	public ValueControllerDemo()
	{
		InitializeComponent();
	}
	private void slider_ValueChanged(object sender, EventArgs e)
	{
		lblSlider.Text = slider.Value.ToString();
	}
	private void stepper_ValueChanged(object sender, EventArgs e)
	{
		if (stepper != null)
		{
			lblStepper.Text = stepper.Value.ToString();
		}
	}
	private void EditText_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new EditTextDemo());
	}
}