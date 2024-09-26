using Microsoft.Extensions.Logging;
using DatabaseService.Services;
using BilvaerkstedMauiApp1.ViewModels;
using BilvaerkstedMauiApp1.Views;

namespace BilvaerkstedMauiApp1;

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
            });

        builder.Services.AddSingleton<DatabaseServiceClass>(s => 
            ActivatorUtilities.CreateInstance<DatabaseServiceClass>(s, Path.Combine(FileSystem.AppDataDirectory, "bilvaerksted.db3")));

        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<MainPageViewModel>();
        builder.Services.AddTransient<TasksPage>();
        builder.Services.AddTransient<TasksViewModel>();
        builder.Services.AddTransient<InvoicePage>();
        builder.Services.AddTransient<InvoiceViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}