namespace LayoutDemo;

public partial class AbsoluteLayoutDemo : ContentPage
{
	public AbsoluteLayoutDemo()
	{
		InitializeComponent();
	}
	private void Flex_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new FlexLayoutDemo());
    }
}