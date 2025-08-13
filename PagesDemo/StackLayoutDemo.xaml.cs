namespace LayoutDemo;

public partial class StackLayoutDemo : ContentPage
{
	public StackLayoutDemo()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new VerticalStackLayoutDemo());
    }
}