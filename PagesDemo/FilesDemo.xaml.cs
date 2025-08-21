using System.Text.Json;
using PagesDemo.Models;

namespace PagesDemo;

public partial class FilesDemo : ContentPage
{
	public FilesDemo()
	{
		InitializeComponent();
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();
		await LoadMauiAsset();
	}
	async Task LoadMauiAsset()
	{
		using var stream = await FileSystem.OpenAppPackageFileAsync("data.json");
		using var reader = new StreamReader(stream);

		var contents = reader.ReadToEnd();

		var p = JsonSerializer.Deserialize<Person>(contents);
	}
	private void CodeQuoates_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new CodeQuoates_Home());
    }
}

// public class Person
// {
// 	public String? Name { get; set; }
// 	public int Age { get; set; }
// }