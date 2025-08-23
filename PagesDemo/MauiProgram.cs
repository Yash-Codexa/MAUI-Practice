using CommunityToolkit.Maui;
using DotNet.Meteor.HotReload.Plugin;
using Microsoft.Extensions.Logging;
using PagesDemo.DevsPark_MVVM.Pages.DesertMirage.NightAdventures;
using PagesDemo.DevsPark_MVVM.Pages.DesertMirage.OasisFun;
using PagesDemo.DevsPark_MVVM.Pages.Frozen.IcyTreats;
using PagesDemo.DevsPark_MVVM.Pages.Frozen.SnowActivities;
using PagesDemo.DevsPark_MVVM.Pages.TropicalParadise.BeachAttractions;
using PagesDemo.DevsPark_MVVM.Pages.TropicalParadise.JungleAdventures;
using PagesDemo.DevsPark_MVVM.ViewModels;

namespace PagesDemo;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();

		builder.UseMauiApp<App>().UseMauiCommunityToolkit();

		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Valestine.ttf", "CustomFont");
				fonts.AddFont("Bison.ttf", "MainFont");
				fonts.AddFont("fontello.ttf", "Icons");
				fonts.AddFont("Sublima-ExtraBold.otf", "SublimaBold");
				fonts.AddFont("Sublima-ExtraLight.otf", "SublimaLight");
				fonts.AddFont("Kanit-Bold.ttf", "KanitBold");
				fonts.AddFont("Kanit-Regular.ttf", "KanitRegular");
			}).EnableHotReload();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddTransient<NightDuneBuggy>();
		builder.Services.AddTransient<StarGazing>();
		builder.Services.AddTransient<OasisPools>();
		builder.Services.AddTransient<CamelRides>();
		builder.Services.AddTransient<FrozanDrinksBar>();
		builder.Services.AddTransient<IceCreamWorld>();
		builder.Services.AddTransient<IceSculptures>();
		builder.Services.AddTransient<SnowBoarding>();
		builder.Services.AddTransient<SurfLessons>();
		builder.Services.AddTransient<WavePool>();
		builder.Services.AddTransient<AnimalShows>();
		builder.Services.AddTransient<ZipLines>();

		builder.Services.AddTransient<PlacesViewModel>();

		return builder.Build();
	}
}
