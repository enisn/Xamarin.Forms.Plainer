using Microsoft.Maui.Hosting;
using Plainer.Maui;

namespace Sandbox.PlainerMAUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.ConfigureMauiHandlers(handlers =>
		{
			handlers.AddPlainer();
		});

		return builder.Build();
	}
}
