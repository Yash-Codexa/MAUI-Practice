namespace PagesDemo.Views;

public partial class EmptyList_View : ContentPage
{
	public EmptyList_View()
	{
		InitializeComponent();
	}
	private void Switch_Toggled(System.Object sender, Microsoft.Maui.Controls.ToggledEventArgs e)
	{
		var isToggled = e.Value;
		collectionView.EmptyView = isToggled ? Resources["NoResultsView"] : Resources["ConnectivityIssue"];
	}
}