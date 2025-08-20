using PagesDemo.Views;

namespace PagesDemo;

public partial class DataBindingDesign : ContentPage
{



	public DataBindingDesign()
	{
		InitializeComponent();
	}

	private void BindingContext_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new BindingContext());
    }
}