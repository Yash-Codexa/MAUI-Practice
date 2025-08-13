using LayoutDemo;

namespace PagesDemo;

public partial class TabbedPageDemo : TabbedPage
{
	public TabbedPageDemo()
	{
		InitializeComponent();
	}

	private void StackLayout_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new StackLayoutDemo());
    }
	
}