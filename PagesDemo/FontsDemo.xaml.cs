namespace PagesDemo;

public partial class FontsDemo : ContentPage
{
	public FontsDemo()
	{
		InitializeComponent();
	}

	private void FontIcons_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new FontIconsDemo());
    }
}