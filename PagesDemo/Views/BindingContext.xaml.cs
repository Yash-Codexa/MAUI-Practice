using PagesDemo.Models;

namespace PagesDemo.Views;

public partial class BindingContext : ContentPage
{
	public BindingContext()
	{
		InitializeComponent();
	}

	private void btn_Clicked(Object sender, EventArgs e)
	{
		var persons = new Persons
		{
			Name = "john",
			Phone = "1234234",
			Address = "abcdef"
		};

		BindingContext = persons;
	}
	private void BindingControls_Clicked(Object sender, EventArgs e)
	{
		Navigation.PushAsync(new BindingControls());
	}
}