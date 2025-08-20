using System.ComponentModel;
using PagesDemo.Models;

namespace PagesDemo.Views;

public partial class ChangeNotifyDemo : ContentPage, INotifyPropertyChanged
{
	Persons persons = new Persons();
	public ChangeNotifyDemo()
	{
		InitializeComponent();

		persons = new Persons
		{
			Name = "john",
			Phone = "1234234",
			Address = "abcdef"
		};

		BindingContext = persons;
	}
	private void btn_Clicked(Object sender, EventArgs e)
	{

		persons = new Persons
		{
			Name = "Peter",
			Phone = "00000",
			Address = "Some Address"
		};

	}
	private void HangMan_Clicked(System.Object sender, System.EventArgs e)
	{
		Navigation.PushAsync(new HangMan_Home());
	}
}