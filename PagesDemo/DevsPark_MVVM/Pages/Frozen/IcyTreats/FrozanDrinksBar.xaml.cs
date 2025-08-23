using PagesDemo.DevsPark_MVVM.ViewModels;
using PagesDemo.Utilities;

namespace PagesDemo.DevsPark_MVVM.Pages.Frozen.IcyTreats;

public partial class FrozanDrinksBar : ContentPage
{
	public FrozanDrinksBar(PlacesViewModel vm)
	{
		InitializeComponent();

		vm.SetCurrentPlace(this.GetName());
        BindingContext = vm;
	}
}