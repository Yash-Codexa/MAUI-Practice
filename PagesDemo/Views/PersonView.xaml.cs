using PagesDemo.ViewModels;

namespace PagesDemo.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();

		BindingContext = new PersonViewModel();
	}
}