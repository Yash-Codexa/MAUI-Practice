namespace PagesDemo.Views;

public partial class DynamicStyle_View : ContentPage
{
	public DynamicStyle_View()
	{
		InitializeComponent();
	}
	private void Button_Clicked(System.Object sender, System.EventArgs e)
	{
		Resources["DynamicStyle"] = Resources["greenStyle"];
	}
}