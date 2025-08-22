using PagesDemo.ViewModels;

namespace PagesDemo.Views;

public partial class CollectionView_Demo_View : ContentPage
{
	public CollectionView_Demo_View()
	{
		InitializeComponent();

		BindingContext = new CollectionView_Demo_ViewModel();
	}
}