namespace LayoutDemo;

public partial class HorizontalStackLayoutDemo : ContentPage
{
	public HorizontalStackLayoutDemo()
	{
		InitializeComponent();
	}

	private void Grid_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new GridLayoutDemo());
    }
}