namespace Rewards_page;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Brands-Regular.otf", "FAB");
                fonts.AddFont("Regular.otf", "FAR");
                fonts.AddFont("Solid.otf", "FAS");
            });

		return builder.Build();
	}
}
