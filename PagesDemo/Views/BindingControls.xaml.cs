namespace PagesDemo.Views;

public partial class BindingControls : ContentPage
{
	public BindingControls()
	{
		InitializeComponent();
	}
	private void BindingModes_Clicked(System.Object sender, System.EventArgs e)
	{
		Navigation.PushAsync(new BindingModes());
	 }
}