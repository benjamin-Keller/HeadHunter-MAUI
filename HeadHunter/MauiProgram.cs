using Microsoft.Extensions.Logging;
using HeadHunter.Data;
using HeadHunter.Data.Handlers;
using Blazored.SessionStorage;
using Blazored.LocalStorage;
using HeadHunter.Resources;

namespace HeadHunter;

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

		builder.Services.AddMauiBlazorWebView();
        builder.Services.AddBlazoredSessionStorage();
        builder.Services.AddBlazoredLocalStorage();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif
		
        builder.Services.AddSingleton<StateContainer>();
        builder.Services.AddTransient<HttpClient>();
        builder.Services.AddTransient<EventsService>();
        builder.Services.AddTransient<LockfileService>();
        builder.Services.AddTransient<AuthService>();
        builder.Services.AddTransient<AuthHandler>();
        builder.Services.AddTransient<StoreService>();
        builder.Services.AddTransient<WeaponsService>();
        builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}
