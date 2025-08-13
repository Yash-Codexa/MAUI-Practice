namespace ControlsDemo;

public partial class CommandInitiaterControllsDemo : ContentPage
{
	public CommandInitiaterControllsDemo()
	{
		InitializeComponent();
	}
	private void BtnTest_Clicked(object? sender, EventArgs e)
	{
		DisplayAlert("Test", "Test DisplayAlert", "Ok");
	}
	private void RadioButton_CheckedChanged(object? sender, CheckedChangedEventArgs e)
	{
		DisplayAlert("RadioButton", $"Changed; {e.Value}", "Ok");
	}
	private void searchControl_SearchButtonPressed(object? sender, EventArgs e)
	{
		DisplayAlert("Searching", $"Searching; {searchControl.Text}", "Ok");
	}

	private void SwipeItem_Invoked(object sender, EventArgs e)
	{
		DisplayAlert("Swipe",$"Element tapped","Ok");
    }

	private void ValueController_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ValueControllerDemo());
    }
}