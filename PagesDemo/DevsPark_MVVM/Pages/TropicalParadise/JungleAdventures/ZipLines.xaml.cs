using PagesDemo.DevsPark_MVVM.ViewModels;
using PagesDemo.Utilities;

namespace PagesDemo.DevsPark_MVVM.Pages.TropicalParadise.JungleAdventures;

public partial class ZipLines : ContentPage
{
	public ZipLines(PlacesViewModel vm)
	{
		InitializeComponent();

		vm.SetCurrentPlace(this.GetName());
        BindingContext = vm;
	}
}