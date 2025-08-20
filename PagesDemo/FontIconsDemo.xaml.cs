namespace PagesDemo;

public partial class FontIconsDemo : ContentPage
{
	public FontIconsDemo()
	{
		InitializeComponent();
	}
	private void FilesDemo_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new FilesDemo());
    }
}