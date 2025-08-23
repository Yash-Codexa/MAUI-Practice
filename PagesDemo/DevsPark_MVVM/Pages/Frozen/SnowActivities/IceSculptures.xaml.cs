using PagesDemo.DevsPark_MVVM.ViewModels;
using PagesDemo.Utilities;

namespace PagesDemo.DevsPark_MVVM.Pages.Frozen.SnowActivities;

public partial class IceSculptures : ContentPage
{
	public IceSculptures(PlacesViewModel vm)
	{
		InitializeComponent();

		vm.SetCurrentPlace(this.GetName());
        BindingContext = vm;
	}
}