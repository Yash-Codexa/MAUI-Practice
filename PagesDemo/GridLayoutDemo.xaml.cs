namespace LayoutDemo;

public partial class GridLayoutDemo : ContentPage
{
	public GridLayoutDemo()
	{
		InitializeComponent();
	}
	private void Absolute_Clicked(object? sender, EventArgs e)
	{
		Navigation.PushAsync(new AbsoluteLayoutDemo());
	}
}