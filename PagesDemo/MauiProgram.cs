using CommunityToolkit.Maui;
using DotNet.Meteor.HotReload.Plugin;
using Microsoft.Extensions.Logging;

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
			}).EnableHotReload();

#if DEBUG
		builder.Logging.AddDebug();
#endif



		return builder.Build();
	}
}
