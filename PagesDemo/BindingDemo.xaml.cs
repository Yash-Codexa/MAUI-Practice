using PagesDemo.Models;

namespace PagesDemo;

public partial class BindingDemo : ContentPage
{
	public BindingDemo()
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

		Binding personBinding = new Binding();

		personBinding.Source = persons;
		personBinding.Path = "Name";

		txtName.SetBinding(Label.TextProperty, personBinding);
	}

	private void bindingXAML_Clicked(Object sender, EventArgs e)
	{
		Navigation.PushAsync(new DataBindingDesign());
	}
}