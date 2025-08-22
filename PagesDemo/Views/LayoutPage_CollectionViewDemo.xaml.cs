using PagesDemo.ViewModels;

namespace PagesDemo.Views;

public partial class LayoutPage_CollectionViewDemo : ContentPage
{
	public LayoutPage_CollectionViewDemo()
	{
		InitializeComponent();

		BindingContext = new CollectionView_Demo_ViewModel();
	}

	private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		var element = e.CurrentSelection;
    }

}