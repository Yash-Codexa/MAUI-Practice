using PagesDemo.DevsPark_MVVM.ViewModels;
using PagesDemo.Utilities;

namespace PagesDemo.DevsPark_MVVM.Pages.DesertMirage.OasisFun;

public partial class CamelRides : ContentPage
{
	public CamelRides(PlacesViewModel vm)
	{
		InitializeComponent();

		vm.SetCurrentPlace(this.GetName());
        BindingContext = vm;
	}
}