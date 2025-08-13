using System.Diagnostics;

namespace ControlsDemo;

public partial class EditTextDemo : ContentPage
{
	public EditTextDemo()
	{
		InitializeComponent();
	}
	private void Entry_TextChanged(object sender, EventArgs e)
	{
		Debug.WriteLine(txtName.Text);
	}
	private void Entry_TextCompleted(object sender, EventArgs e)
	{
		Debug.WriteLine(txtName.Text);
	}
	private void ActivityIndicator_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ActivityControllerDemo());
	}
}