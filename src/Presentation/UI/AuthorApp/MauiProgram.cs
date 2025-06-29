using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Application.Author.Commands;
using Infrastructure;
using System.Reflection;
using Application;

namespace AuthorApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddMediatR(cfg =>
		{
			cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
		});

		builder.Services.AddApplications();
		builder.Services.AddApplicationServices();
		builder.Services.AddInfrastructureServices();
		builder.Services.RegisterPageModels();
		builder.Services.RegisterPages();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
