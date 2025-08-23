using PagesDemo.DevsPark_MVVM.Models;
using PagesDemo.DevsPark_MVVM.ViewModels;
using PagesDemo.Utilities;

namespace PagesDemo.DevsPark_MVVM.Pages.Frozen.SnowActivities;

public partial class SnowBoarding : ContentPage
{
	public SnowBoarding(PlacesViewModel vm)
	{
		InitializeComponent();

		vm.SetCurrentPlace(this.GetName());
        BindingContext = vm;
	}
}