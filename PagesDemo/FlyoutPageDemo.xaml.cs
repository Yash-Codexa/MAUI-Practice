namespace PagesDemo;

public partial class FlyoutPageDemo : FlyoutPage
{
	public FlyoutPageDemo()
	{
		InitializeComponent();
	}
	private void button_TabbedPage(object sender, EventArgs e)
	{
		Navigation.PushAsync(new TabbedPageDemo());
    }
}