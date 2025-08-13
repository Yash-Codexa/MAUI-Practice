namespace LayoutDemo;

public partial class VerticalStackLayoutDemo : ContentPage
{
	public VerticalStackLayoutDemo()
	{
		InitializeComponent();
	}
	private void Btn_Clicked(object? sender, EventArgs e)
	{
		Navigation.PushAsync(new HorizontalStackLayoutDemo());
	}
}