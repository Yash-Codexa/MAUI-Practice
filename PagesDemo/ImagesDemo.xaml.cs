namespace PagesDemo;

public partial class ImagesDemo : ContentPage
{
	public ImagesDemo()
	{
		InitializeComponent();
	}
		private void FontsDemo_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new FontsDemo());
    }
}