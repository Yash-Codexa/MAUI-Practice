using PagesDemo.ViewModels;

namespace PagesDemo.Views;

public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();

		BindingContext = new CommandViewModel();
	}
}