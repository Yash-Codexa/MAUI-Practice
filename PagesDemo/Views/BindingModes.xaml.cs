namespace PagesDemo.Views;

public partial class BindingModes : ContentPage
{
	public BindingModes()
	{
		InitializeComponent();
	}
	private void PropertyNotifyChange_Clicked(System.Object sender, System.EventArgs e)
	{
		Navigation.PushAsync(new ChangeNotifyDemo());
	}
}