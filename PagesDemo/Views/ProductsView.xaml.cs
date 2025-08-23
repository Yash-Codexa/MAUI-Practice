using System.Diagnostics;
using PagesDemo.ViewModels;

namespace PagesDemo.Views;

public partial class ProductsView : ContentPage
{
	public ProductsView()
	{
		InitializeComponent();

		BindingContext = new ProductsViewModel();
	}
	private void CollectionView_Scrolled(System.Object sender, Microsoft.Maui.Controls.ItemsViewScrolledEventArgs e)
	{
		Debug.Write("------------------");
		Debug.WriteLine("HorizontalDelta: " + e.HorizontalDelta);
		Debug.WriteLine("Horizontaloffset: " + e.HorizontalOffset);
		Debug.WriteLine("VerticalDelta: " + e.VerticalDelta);
		Debug.WriteLine("VerticalDelta: " + e.VerticalOffset);
		Debug.WriteLine("FirstVisibleItemIndex: " + e.FirstVisibleItemIndex);
		Debug.WriteLine("CenterItemIndex: " + e.CenterItemIndex);
		Debug.WriteLine("LastVisibleItemIndex: " + e.LastVisibleItemIndex);
		Debug.Write("------------------");

	}
	private void Button_Clicked(System.Object sender, System.EventArgs e)
	{
		var vm = BindingContext as ProductsViewModel;

		// vm?.Products.Add(new Models.ProductsGroup("New Group", new List<Models.Product>
		// {
		// 	new Models.Product{
		// 		Id=100,
		// 		Name="BitCoin",
		// 		Price=00
		// 	}
		// }));

		var product = vm.Products.SelectMany(p => p).FirstOrDefault(x => x.Id == 10);



		collectionView.ScrollTo(product);
	}

	private void Button_Clicked1(object sender, EventArgs e)
	{
				var vm = BindingContext as ProductsViewModel;

		vm?.Products.Add(new Models.ProductsGroup("New Group", new List<Models.Product>
		{
			new Models.Product{
				Id=100,
				Name="BitCoin",
				Price=00
			}
		}));

		var product = vm.Products.SelectMany(p => p).FirstOrDefault(x => x.Id == 10);
    }
}